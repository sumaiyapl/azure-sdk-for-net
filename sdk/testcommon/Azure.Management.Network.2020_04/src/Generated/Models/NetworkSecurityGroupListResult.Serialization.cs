// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class NetworkSecurityGroupListResult
    {
        internal static NetworkSecurityGroupListResult DeserializeNetworkSecurityGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<NetworkSecurityGroup>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NetworkSecurityGroup> array = new List<NetworkSecurityGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkSecurityGroup.DeserializeNetworkSecurityGroup(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkSecurityGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
