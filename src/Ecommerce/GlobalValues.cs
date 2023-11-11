﻿using System.Text.Json.Serialization;

namespace Ecommerce
{
    public class GlobalValues
    {
        /// <summary>
        /// 
        /// </summary>
        public const int KEYLENGHT = 50;

        /// <summary>
        /// 
        /// </summary>
        public const int SHORTFIELD = 250;

        /// <summary>
        /// 
        /// </summary>
        public const int LARGEFIELD = 500;

        /// <summary>
        /// 
        /// </summary>
        public const int EXTRALARGEFIELD = 2000;
    }
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateSelectionOptions
    {
        All,
        Active,
        Inactive
    }
}
