// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class StorageQueue : Resource
    {
        /// <summary>
        /// Initializes a new instance of the StorageQueue class.
        /// </summary>
        public StorageQueue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageQueue class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="metadata">A name-value pair that represents queue
        /// metadata.</param>
        /// <param name="approximateMessageCount">Integer indicating an
        /// approximate number of messages in the queue. This number is not
        /// lower than the actual number of messages in the queue, but could be
        /// higher.</param>
        public StorageQueue(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), int? approximateMessageCount = default(int?))
            : base(id, name, type)
        {
            Metadata = metadata;
            ApproximateMessageCount = approximateMessageCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a name-value pair that represents queue metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets integer indicating an approximate number of messages in the
        /// queue. This number is not lower than the actual number of messages
        /// in the queue, but could be higher.
        /// </summary>
        [JsonProperty(PropertyName = "properties.approximateMessageCount")]
        public int? ApproximateMessageCount { get; private set; }

    }
}