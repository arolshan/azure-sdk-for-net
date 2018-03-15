// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for WebTestKind.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebTestKind
    {
        [EnumMember(Value = "ping")]
        Ping,
        [EnumMember(Value = "multistep")]
        Multistep
    }
    internal static class WebTestKindEnumExtension
    {
        internal static string ToSerializedValue(this WebTestKind? value)
        {
            return value == null ? null : ((WebTestKind)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this WebTestKind value)
        {
            switch( value )
            {
                case WebTestKind.Ping:
                    return "ping";
                case WebTestKind.Multistep:
                    return "multistep";
            }
            return null;
        }

        internal static WebTestKind? ParseWebTestKind(this string value)
        {
            switch( value )
            {
                case "ping":
                    return WebTestKind.Ping;
                case "multistep":
                    return WebTestKind.Multistep;
            }
            return null;
        }
    }
}