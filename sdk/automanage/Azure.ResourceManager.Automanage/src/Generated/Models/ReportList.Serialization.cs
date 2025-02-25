// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class ReportList
    {
        internal static ReportList DeserializeReportList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AutomanageConfigurationProfileAssignmentReportData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AutomanageConfigurationProfileAssignmentReportData> array = new List<AutomanageConfigurationProfileAssignmentReportData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutomanageConfigurationProfileAssignmentReportData.DeserializeAutomanageConfigurationProfileAssignmentReportData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ReportList(Optional.ToList(value));
        }
    }
}
