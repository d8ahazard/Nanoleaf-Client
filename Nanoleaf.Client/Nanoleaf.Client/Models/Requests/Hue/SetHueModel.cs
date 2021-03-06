﻿using Newtonsoft.Json;

namespace Nanoleaf.Client.Models.Requests.Hue
{
    [JsonObject(Title = "hue")]
    internal class SetHueModel
    {
        public SetHueModel(int value) => Value = value;

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}