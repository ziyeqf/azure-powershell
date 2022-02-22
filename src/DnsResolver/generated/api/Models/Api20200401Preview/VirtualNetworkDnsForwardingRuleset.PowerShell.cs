// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.PowerShell;

    /// <summary>Reference to DNS forwarding ruleset and associated virtual network link.</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualNetworkDnsForwardingRulesetTypeConverter))]
    public partial class VirtualNetworkDnsForwardingRuleset
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.VirtualNetworkDnsForwardingRuleset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRuleset"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRuleset DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualNetworkDnsForwardingRuleset(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.VirtualNetworkDnsForwardingRuleset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRuleset"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRuleset DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualNetworkDnsForwardingRuleset(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualNetworkDnsForwardingRuleset" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRuleset FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.VirtualNetworkDnsForwardingRuleset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualNetworkDnsForwardingRuleset(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkLinkSubResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.VirtualNetworkLinkSubResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLink = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ISubResource) content.GetValueForProperty("VirtualNetworkLink",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLink, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualNetworkLinkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLinkId = (string) content.GetValueForProperty("VirtualNetworkLinkId",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLinkId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.VirtualNetworkDnsForwardingRuleset"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualNetworkDnsForwardingRuleset(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkLinkSubResourceProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.VirtualNetworkLinkSubResourcePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("VirtualNetworkLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLink = (Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.ISubResource) content.GetValueForProperty("VirtualNetworkLink",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLink, Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.SubResourceTypeConverter.ConvertFrom);
            }
            if (content.Contains("VirtualNetworkLinkId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLinkId = (string) content.GetValueForProperty("VirtualNetworkLinkId",((Microsoft.Azure.PowerShell.Cmdlets.DnsResolver.Models.Api20200401Preview.IVirtualNetworkDnsForwardingRulesetInternal)this).VirtualNetworkLinkId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Reference to DNS forwarding ruleset and associated virtual network link.
    [System.ComponentModel.TypeConverter(typeof(VirtualNetworkDnsForwardingRulesetTypeConverter))]
    public partial interface IVirtualNetworkDnsForwardingRuleset

    {

    }
}