// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class MetricSpecification
    {
        internal static MetricSpecification DeserializeMetricSpecification(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> displayName = default;
            Optional<string> displayDescription = default;
            Optional<string> unit = default;
            Optional<AggregationType> aggregationType = default;
            Optional<string> fillGapWithZero = default;
            Optional<string> category = default;
            Optional<IReadOnlyList<Dimension>> dimensions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayDescription"))
                {
                    displayDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aggregationType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    aggregationType = new AggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fillGapWithZero"))
                {
                    fillGapWithZero = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dimensions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Dimension> array = new List<Dimension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Dimension.DeserializeDimension(item));
                    }
                    dimensions = array;
                    continue;
                }
            }
            return new MetricSpecification(name.Value, displayName.Value, displayDescription.Value, unit.Value, Optional.ToNullable(aggregationType), fillGapWithZero.Value, category.Value, Optional.ToList(dimensions));
        }
    }
}
