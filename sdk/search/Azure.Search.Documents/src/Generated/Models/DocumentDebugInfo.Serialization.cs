// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class DocumentDebugInfo
    {
        internal static DocumentDebugInfo DeserializeDocumentDebugInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SemanticDebugInfo> semantic = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("semantic"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    semantic = SemanticDebugInfo.DeserializeSemanticDebugInfo(property.Value);
                    continue;
                }
            }
            return new DocumentDebugInfo(semantic.Value);
        }
    }
}
