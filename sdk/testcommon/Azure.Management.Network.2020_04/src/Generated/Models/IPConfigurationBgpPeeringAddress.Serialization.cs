// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class IPConfigurationBgpPeeringAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IpconfigurationId))
            {
                writer.WritePropertyName("ipconfigurationId");
                writer.WriteStringValue(IpconfigurationId);
            }
            if (Optional.IsCollectionDefined(CustomBgpIpAddresses))
            {
                writer.WritePropertyName("customBgpIpAddresses");
                writer.WriteStartArray();
                foreach (var item in CustomBgpIpAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IPConfigurationBgpPeeringAddress DeserializeIPConfigurationBgpPeeringAddress(JsonElement element)
        {
            Optional<string> ipconfigurationId = default;
            Optional<IReadOnlyList<string>> defaultBgpIpAddresses = default;
            Optional<IList<string>> customBgpIpAddresses = default;
            Optional<IReadOnlyList<string>> tunnelIpAddresses = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipconfigurationId"))
                {
                    ipconfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultBgpIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    defaultBgpIpAddresses = array;
                    continue;
                }
                if (property.NameEquals("customBgpIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customBgpIpAddresses = array;
                    continue;
                }
                if (property.NameEquals("tunnelIpAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tunnelIpAddresses = array;
                    continue;
                }
            }
            return new IPConfigurationBgpPeeringAddress(ipconfigurationId.Value, Optional.ToList(defaultBgpIpAddresses), Optional.ToList(customBgpIpAddresses), Optional.ToList(tunnelIpAddresses));
        }
    }
}
