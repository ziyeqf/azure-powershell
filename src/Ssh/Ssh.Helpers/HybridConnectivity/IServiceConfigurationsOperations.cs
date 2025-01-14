// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.HybridConnectivity
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServiceConfigurationsOperations operations.
    /// </summary>
    public partial interface IServiceConfigurationsOperations
    {
        /// <summary>
        /// Gets the details about the service to the resource.
        /// </summary>
        /// <param name='resourceUri'>
        /// The fully qualified Azure Resource manager identifier of the
        /// resource to be connected.
        /// </param>
        /// <param name='endpointName'>
        /// The endpoint name.
        /// </param>
        /// <param name='serviceConfigurationName'>
        /// The service name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceConfigurationResource>> GetWithHttpMessagesAsync(string resourceUri, string endpointName, string serviceConfigurationName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create or update a service in serviceConfiguration for the endpoint
        /// resource.
        /// </summary>
        /// <param name='resourceUri'>
        /// The fully qualified Azure Resource manager identifier of the
        /// resource to be connected.
        /// </param>
        /// <param name='endpointName'>
        /// The endpoint name.
        /// </param>
        /// <param name='serviceConfigurationName'>
        /// The service name.
        /// </param>
        /// <param name='serviceConfigurationResource'>
        /// Service details
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServiceConfigurationResource>> CreateOrupdateWithHttpMessagesAsync(string resourceUri, string endpointName, string serviceConfigurationName, ServiceConfigurationResource serviceConfigurationResource, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
