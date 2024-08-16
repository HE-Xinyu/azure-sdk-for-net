// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime
{
    internal class LoadBalancerOperationSource : IOperationSource<LoadBalancerResource>
    {
        private readonly ArmClient _client;

        internal LoadBalancerOperationSource(ArmClient client)
        {
            _client = client;
        }

        LoadBalancerResource IOperationSource<LoadBalancerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LoadBalancerData.DeserializeLoadBalancerData(document.RootElement);
            return new LoadBalancerResource(_client, data);
        }

        async ValueTask<LoadBalancerResource> IOperationSource<LoadBalancerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LoadBalancerData.DeserializeLoadBalancerData(document.RootElement);
            return new LoadBalancerResource(_client, data);
        }
    }
}
