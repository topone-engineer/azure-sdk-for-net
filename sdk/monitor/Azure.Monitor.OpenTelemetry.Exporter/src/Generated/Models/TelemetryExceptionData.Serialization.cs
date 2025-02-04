// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class TelemetryExceptionData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("exceptions"u8);
            writer.WriteStartArray();
            foreach (var item in Exceptions)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(SeverityLevel))
            {
                if (SeverityLevel != null)
                {
                    writer.WritePropertyName("severityLevel"u8);
                    writer.WriteStringValue(SeverityLevel.Value.ToString());
                }
                else
                {
                    writer.WriteNull("severityLevel");
                }
            }
            if (Optional.IsDefined(ProblemId))
            {
                writer.WritePropertyName("problemId"u8);
                writer.WriteStringValue(ProblemId);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Measurements))
            {
                writer.WritePropertyName("measurements"u8);
                writer.WriteStartObject();
                foreach (var item in Measurements)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("ver"u8);
            writer.WriteNumberValue(Version);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }
    }
}
