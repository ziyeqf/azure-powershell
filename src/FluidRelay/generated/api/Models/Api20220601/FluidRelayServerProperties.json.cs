// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Extensions;

    /// <summary>The properties of a Fluid Relay Service resource.</summary>
    public partial class FluidRelayServerProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject into a new instance of <see cref="FluidRelayServerProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal FluidRelayServerProperties(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_fluidRelayEndpoint = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject>("fluidRelayEndpoints"), out var __jsonFluidRelayEndpoints) ? Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.FluidRelayEndpoints.FromJson(__jsonFluidRelayEndpoints) : FluidRelayEndpoint;}
            {_encryption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject>("encryption"), out var __jsonEncryption) ? Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.EncryptionProperties.FromJson(__jsonEncryption) : Encryption;}
            {_frsTenantId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonString>("frsTenantId"), out var __jsonFrsTenantId) ? (string)__jsonFrsTenantId : (string)FrsTenantId;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)ProvisioningState;}
            {_storagesku = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonString>("storagesku"), out var __jsonStoragesku) ? (string)__jsonStoragesku : (string)Storagesku;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Models.Api20220601.IFluidRelayServerProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject json ? new FluidRelayServerProperties(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="FluidRelayServerProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="FluidRelayServerProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != this._fluidRelayEndpoint ? (Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode) this._fluidRelayEndpoint.ToJson(null,serializationMode) : null, "fluidRelayEndpoints" ,container.Add );
            }
            AddIf( null != this._encryption ? (Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode) this._encryption.ToJson(null,serializationMode) : null, "encryption" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._frsTenantId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonString(this._frsTenantId.ToString()) : null, "frsTenantId" ,container.Add );
            }
            AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            AddIf( null != (((object)this._storagesku)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.FluidRelay.Runtime.Json.JsonString(this._storagesku.ToString()) : null, "storagesku" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}