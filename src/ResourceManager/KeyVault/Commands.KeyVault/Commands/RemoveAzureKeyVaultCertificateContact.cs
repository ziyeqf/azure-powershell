﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.KeyVault.Models;
using Microsoft.Azure.KeyVault;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.KeyVault
{
    /// <summary>
    /// Removes a given certificate contact from Key Vault for certificate management
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, CmdletNoun.AzureKeyVaultCertificateContact,
        DefaultParameterSetName = ByVaultNameParameterSet,
        HelpUri = Constants.KeyVaultHelpUri)]
    [OutputType(typeof(List<KeyVaultCertificateContact>))]
    public class RemoveAzureKeyVaultCertificateContact : KeyVaultCmdletBase
    {
        #region Parameter Set Names

        private const string ByVaultNameParameterSet = "VaultName";

        #endregion

        /// <summary>
        /// VaultName
        /// </summary>
        [Parameter(Mandatory = true,
                   ParameterSetName = ByVaultNameParameterSet,
                   Position = 0,
                   ValueFromPipelineByPropertyName = true,
                   HelpMessage = "Specifies the name of the vault from which this cmdlet removes the certificate contact.")]
        [ValidateNotNullOrEmpty]
        [ValidatePattern(Constants.VaultNameRegExString)]
        public string VaultName { get; set; }

        /// <summary>
        /// EmailAddress
        /// </summary>
        [Parameter(Mandatory = true,
                   Position = 1,
                   ValueFromPipelineByPropertyName = true,
                   HelpMessage = "Specifies the email address of the contact.")]
        [ValidateNotNullOrEmpty]
        public string EmailAddress { get; set; }

        /// <summary>
        /// PassThru parameter
        /// </summary>
        [Parameter(HelpMessage = "This cmdlet does not return an object by default. If this switch is specified, it returns the contact object.")]
        public SwitchParameter PassThru { get; set; }

        protected override void ProcessRecord()
        {
            Contacts existingContacts;

            try
            {
                existingContacts = this.DataServiceClient.GetCertificateContacts(VaultName);
            }
            catch (KeyVaultClientException kvce)
            {
                if (kvce.Status != System.Net.HttpStatusCode.NotFound)
                {
                    throw;
                }

                existingContacts = null;
            }

            List<Contact> existingContactList;

            if (existingContacts == null ||
                existingContacts.ContactsList == null)
            {
                existingContactList = new List<Contact>();
            }
            else
            {
                existingContactList = new List<Contact>(existingContacts.ContactsList);
            }

            var nContactsRemoved = existingContactList.RemoveAll(contact => string.Compare(contact.Email, EmailAddress, StringComparison.OrdinalIgnoreCase) == 0);

            if (nContactsRemoved == 0)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Provided email address '{0}' is not found.", EmailAddress));
            }

            if (existingContactList.Count == 0)
            {
                existingContactList = null;
            }

            var resultantContacts = this.DataServiceClient.SetCertificateContacts(VaultName, new Contacts { ContactsList = existingContactList });

            if (PassThru.IsPresent)
            {
                this.WriteObject(KeyVaultCertificateContact.FromKVCertificateContacts(resultantContacts));
            }
        }
    }
}
