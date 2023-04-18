﻿using System.Text.Json.Serialization;

namespace YTApi.Commons.Models;

/// <summary>
/// 貼文資料類別
/// </summary>
public partial class PostData
{
    /// <summary>
    /// 已勾選
    /// </summary>
    [JsonIgnore]
    public bool IsChecked { get; set; } = false;
}