// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.ContainerOrchestratorRuntime.Models;
using Azure.ResourceManager.Kubernetes;
using NUnit.Framework;

namespace Azure.ResourceManager.ContainerOrchestratorRuntime.Tests.Tests
{
    [TestFixture]
    public class StorageClassTests : ContainerOrchestratorRuntimeManagementTestBase
    {
        public StorageClassTests() : base(true)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateStorageClassAsync()
        {
            var nfsStorageClassTypeProperties = new NfsStorageClassTypeProperties("172.23.1.4", "/");
            var storageClassData = new ConnectedClusterStorageClassData
            {
                TypeProperties = nfsStorageClassTypeProperties
            };
            var storageClassCollection = new ConnectedClusterStorageClassCollection(Client, TestEnvironment.ConnectedCluster);
            await storageClassCollection.CreateOrUpdateAsync(WaitUntil.Completed, "testsc", storageClassData);
        }
    }
}
