// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class JobScale : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PollingInterval))
            {
                writer.WritePropertyName("pollingInterval"u8);
                writer.WriteNumberValue(PollingInterval.Value);
            }
            if (Optional.IsDefined(MinExecutions))
            {
                writer.WritePropertyName("minExecutions"u8);
                writer.WriteNumberValue(MinExecutions.Value);
            }
            if (Optional.IsDefined(MaxExecutions))
            {
                writer.WritePropertyName("maxExecutions"u8);
                writer.WriteNumberValue(MaxExecutions.Value);
            }
            if (Optional.IsCollectionDefined(Rules))
            {
                writer.WritePropertyName("rules"u8);
                writer.WriteStartArray();
                foreach (var item in Rules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static JobScale DeserializeJobScale(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> pollingInterval = default;
            Optional<int> minExecutions = default;
            Optional<int> maxExecutions = default;
            Optional<IList<JobScaleRule>> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pollingInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pollingInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minExecutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minExecutions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxExecutions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxExecutions = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JobScaleRule> array = new List<JobScaleRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobScaleRule.DeserializeJobScaleRule(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new JobScale(Optional.ToNullable(pollingInterval), Optional.ToNullable(minExecutions), Optional.ToNullable(maxExecutions), Optional.ToList(rules));
        }
    }
}
