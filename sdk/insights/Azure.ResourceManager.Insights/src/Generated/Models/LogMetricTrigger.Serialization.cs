// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class LogMetricTrigger : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ThresholdOperator))
            {
                writer.WritePropertyName("thresholdOperator");
                writer.WriteStringValue(ThresholdOperator.Value.ToString());
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold");
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(MetricTriggerType))
            {
                writer.WritePropertyName("metricTriggerType");
                writer.WriteStringValue(MetricTriggerType.Value.ToString());
            }
            if (Optional.IsDefined(MetricColumn))
            {
                writer.WritePropertyName("metricColumn");
                writer.WriteStringValue(MetricColumn);
            }
            writer.WriteEndObject();
        }

        internal static LogMetricTrigger DeserializeLogMetricTrigger(JsonElement element)
        {
            Optional<ConditionalOperator> thresholdOperator = default;
            Optional<double> threshold = default;
            Optional<MetricTriggerType> metricTriggerType = default;
            Optional<string> metricColumn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("thresholdOperator"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    thresholdOperator = new ConditionalOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("metricTriggerType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    metricTriggerType = new MetricTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricColumn"))
                {
                    metricColumn = property.Value.GetString();
                    continue;
                }
            }
            return new LogMetricTrigger(Optional.ToNullable(thresholdOperator), Optional.ToNullable(threshold), Optional.ToNullable(metricTriggerType), metricColumn.Value);
        }
    }
}
