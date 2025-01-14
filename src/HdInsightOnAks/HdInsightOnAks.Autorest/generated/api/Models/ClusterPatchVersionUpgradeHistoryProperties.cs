// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Cluster patch version upgrade history properties.</summary>
    public partial class ClusterPatchVersionUpgradeHistoryProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPatchVersionUpgradeHistoryProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPatchVersionUpgradeHistoryPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryProperties __clusterInPlaceUpgradeHistoryProperties = new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterInPlaceUpgradeHistoryProperties();

        /// <summary>Component name to upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string ComponentName { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).ComponentName; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).ComponentName = value ?? null; }

        /// <summary>Severity of this upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string Severity { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).Severity; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).Severity = value ?? null; }

        /// <summary>Source build number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string SourceBuildNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).SourceBuildNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).SourceBuildNumber = value ?? null; }

        /// <summary>Version with three part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string SourceClusterVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).SourceClusterVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).SourceClusterVersion = value ?? null; }

        /// <summary>Version with three part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string SourceOssVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).SourceOssVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).SourceOssVersion = value ?? null; }

        /// <summary>Target build number.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string TargetBuildNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).TargetBuildNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).TargetBuildNumber = value ?? null; }

        /// <summary>Version with three part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string TargetClusterVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).TargetClusterVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).TargetClusterVersion = value ?? null; }

        /// <summary>Version with three part.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string TargetOssVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).TargetOssVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).TargetOssVersion = value ?? null; }

        /// <summary>Result of this upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string UpgradeResult { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).UpgradeResult; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).UpgradeResult = value ; }

        /// <summary>Type of upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string UpgradeType { get => "PatchVersionUpgrade"; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).UpgradeType = "PatchVersionUpgrade"; }

        /// <summary>Time when created this upgrade history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string UtcTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).UtcTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterUpgradeHistoryPropertiesInternal)__clusterInPlaceUpgradeHistoryProperties).UtcTime = value ; }

        /// <summary>
        /// Creates an new <see cref="ClusterPatchVersionUpgradeHistoryProperties" /> instance.
        /// </summary>
        public ClusterPatchVersionUpgradeHistoryProperties()
        {
            this.__clusterInPlaceUpgradeHistoryProperties.UpgradeType = "PatchVersionUpgrade";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__clusterInPlaceUpgradeHistoryProperties), __clusterInPlaceUpgradeHistoryProperties);
            await eventListener.AssertObjectIsValid(nameof(__clusterInPlaceUpgradeHistoryProperties), __clusterInPlaceUpgradeHistoryProperties);
        }
    }
    /// Cluster patch version upgrade history properties.
    public partial interface IClusterPatchVersionUpgradeHistoryProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryProperties
    {

    }
    /// Cluster patch version upgrade history properties.
    internal partial interface IClusterPatchVersionUpgradeHistoryPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterInPlaceUpgradeHistoryPropertiesInternal
    {

    }
}