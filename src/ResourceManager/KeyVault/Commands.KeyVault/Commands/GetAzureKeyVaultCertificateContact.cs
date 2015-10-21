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
using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.KeyVault
{
    /// <summary>
    /// Get-AzureKeyVaultCertificateContact gets the list of contacts for certificate objects in key vault.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, CmdletNoun.AzureKeyVaultCertificateContact,
        DefaultParameterSetName = ByVaultNameParameterSet,
        HelpUri = Constants.KeyVaultHelpUri)]
    [OutputType(typeof(List<KeyVaultCertificateContact>))]
    public class GetAzureKeyVaultCertificateContact : KeyVaultCmdletBase
    {
        #region Parameter Set Names

        private const string ByVaultNameParameterSet = "VaultName";

        #endregion

        #region Input Parameter Definitions

        /// <summary>
        /// VaultName
        /// </summary>
        [Parameter(Mandatory = true,
                   ParameterSetName = ByVaultNameParameterSet,
                   Position = 0,
                   ValueFromPipelineByPropertyName = true,
                   HelpMessage = "Specifies the name of the vault to which this cmdlet adds the certificate.")]
        [ValidateNotNullOrEmpty]
        [ValidatePattern(Constants.VaultNameRegExString)]
        public string VaultName { get; set; }

        #endregion

        protected override void ProcessRecord()
        {
            Contacts contacts;

            try
            {
                contacts = this.DataServiceClient.GetCertificateContacts(this.VaultName);
            }
            catch (KeyVaultClientException kvce)
            {
                if (kvce.Status != System.Net.HttpStatusCode.NotFound)
                {
                    throw;
                }

                contacts = null;
            }

            if (contacts == null ||
                contacts.ContactsList == null)
            {
                return;
            }

            var contactsModel = new List<KeyVaultCertificateContact>();

            foreach (var contact in contacts.ContactsList)
            {
                contactsModel.Add(KeyVaultCertificateContact.FromKVCertificateContact(contact));
            }

            this.WriteObject(contactsModel);
        }
    }
}
