﻿using System.Text.Json.Serialization;

namespace Invise.Core.ChromeApi.Settings;
public class ChromeLanguageInfo
{
    [JsonPropertyName("Language")]
    public EChromeLanguage Language { get; internal set; }

    [JsonPropertyName("Local")]
    public string Locale { get; internal set; }

    [JsonPropertyName("AcceptList")]
    public string AcceptLanguageList { get; internal set; }

    [JsonPropertyName("Name")]
    public string Name { get; internal set; }
}
