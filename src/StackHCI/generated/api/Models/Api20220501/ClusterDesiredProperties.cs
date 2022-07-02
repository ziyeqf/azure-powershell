// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>Desired properties of the cluster.</summary>
    public partial class ClusterDesiredProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IClusterDesiredProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IClusterDesiredPropertiesInternal
    {

        /// <summary>Backing field for <see cref="DiagnosticLevel" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.DiagnosticLevel? _diagnosticLevel;

        /// <summary>Desired level of diagnostic data emitted by the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.DiagnosticLevel? DiagnosticLevel { get => this._diagnosticLevel; set => this._diagnosticLevel = value; }

        /// <summary>Backing field for <see cref="WindowsServerSubscription" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.WindowsServerSubscription? _windowsServerSubscription;

        /// <summary>Desired state of Windows Server Subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.WindowsServerSubscription? WindowsServerSubscription { get => this._windowsServerSubscription; set => this._windowsServerSubscription = value; }

        /// <summary>Creates an new <see cref="ClusterDesiredProperties" /> instance.</summary>
        public ClusterDesiredProperties()
        {

        }
    }
    /// Desired properties of the cluster.
    public partial interface IClusterDesiredProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>Desired level of diagnostic data emitted by the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Desired level of diagnostic data emitted by the cluster.",
        SerializedName = @"diagnosticLevel",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.DiagnosticLevel) })]
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.DiagnosticLevel? DiagnosticLevel { get; set; }
        /// <summary>Desired state of Windows Server Subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Desired state of Windows Server Subscription.",
        SerializedName = @"windowsServerSubscription",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.WindowsServerSubscription) })]
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.WindowsServerSubscription? WindowsServerSubscription { get; set; }

    }
    /// Desired properties of the cluster.
    internal partial interface IClusterDesiredPropertiesInternal

    {
        /// <summary>Desired level of diagnostic data emitted by the cluster.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.DiagnosticLevel? DiagnosticLevel { get; set; }
        /// <summary>Desired state of Windows Server Subscription.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.WindowsServerSubscription? WindowsServerSubscription { get; set; }

    }
}