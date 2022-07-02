// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Outputs for the pipeline job</summary>
    public partial class PipelineJobOutputs :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputs,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IPipelineJobOutputsInternal
    {

        /// <summary>Creates an new <see cref="PipelineJobOutputs" /> instance.</summary>
        public PipelineJobOutputs()
        {

        }
    }
    /// Outputs for the pipeline job
    public partial interface IPipelineJobOutputs :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IAssociativeArray<Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IJobOutput>
    {

    }
    /// Outputs for the pipeline job
    internal partial interface IPipelineJobOutputsInternal

    {

    }
}