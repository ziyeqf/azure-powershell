// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class BatchDeploymentsUpdateAcceptedResponseHeaders :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IBatchDeploymentsUpdateAcceptedResponseHeaders,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IBatchDeploymentsUpdateAcceptedResponseHeadersInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IHeaderSerializable
    {

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="RetryAfter" /> property.</summary>
        private int? _retryAfter;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public int? RetryAfter { get => this._retryAfter; set => this._retryAfter = value; }

        /// <summary>Backing field for <see cref="XmsAsyncOperationTimeout" /> property.</summary>
        private global::System.TimeSpan? _xmsAsyncOperationTimeout;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public global::System.TimeSpan? XmsAsyncOperationTimeout { get => this._xmsAsyncOperationTimeout; set => this._xmsAsyncOperationTimeout = value; }

        /// <summary>
        /// Creates an new <see cref="BatchDeploymentsUpdateAcceptedResponseHeaders" /> instance.
        /// </summary>
        public BatchDeploymentsUpdateAcceptedResponseHeaders()
        {

        }

        /// <param name="headers"></param>
        void Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IHeaderSerializable.ReadHeaders(global::System.Net.Http.Headers.HttpResponseHeaders headers)
        {
            if (headers.TryGetValues("x-ms-async-operation-timeout", out var __xMSAsyncOperationTimeoutHeader0))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IBatchDeploymentsUpdateAcceptedResponseHeadersInternal)this).XmsAsyncOperationTimeout = System.Linq.Enumerable.FirstOrDefault(__xMSAsyncOperationTimeoutHeader0) is string __headerXMSAsyncOperationTimeoutHeader0 ? global::System.TimeSpan.TryParse( __headerXMSAsyncOperationTimeoutHeader0, out global::System.TimeSpan __headerXMSAsyncOperationTimeoutHeader0Value ) ? __headerXMSAsyncOperationTimeoutHeader0Value : default(global::System.TimeSpan?) : default(global::System.TimeSpan?);
            }
            if (headers.TryGetValues("Location", out var __locationHeader1))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IBatchDeploymentsUpdateAcceptedResponseHeadersInternal)this).Location = System.Linq.Enumerable.FirstOrDefault(__locationHeader1) is string __headerLocationHeader1 ? __headerLocationHeader1 : (string)null;
            }
            if (headers.TryGetValues("Retry-After", out var __retryAfterHeader2))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.IBatchDeploymentsUpdateAcceptedResponseHeadersInternal)this).RetryAfter = System.Linq.Enumerable.FirstOrDefault(__retryAfterHeader2) is string __headerRetryAfterHeader2 ? int.TryParse( __headerRetryAfterHeader2, out int __headerRetryAfterHeader2Value ) ? __headerRetryAfterHeader2Value : default(int?) : default(int?);
            }
        }
    }
    public partial interface IBatchDeploymentsUpdateAcceptedResponseHeaders

    {
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"Retry-After",
        PossibleTypes = new [] { typeof(int) })]
        int? RetryAfter { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"x-ms-async-operation-timeout",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? XmsAsyncOperationTimeout { get; set; }

    }
    internal partial interface IBatchDeploymentsUpdateAcceptedResponseHeadersInternal

    {
        string Location { get; set; }

        int? RetryAfter { get; set; }

        global::System.TimeSpan? XmsAsyncOperationTimeout { get; set; }

    }
}