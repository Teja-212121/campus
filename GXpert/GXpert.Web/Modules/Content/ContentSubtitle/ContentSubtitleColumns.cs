﻿using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.ContentSubtitle")]
[BasedOnRow(typeof(ContentSubtitleRow), CheckNames = true)]
public class ContentSubtitleColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string SubtitleFile { get; set; }
    public string ContentTitle { get; set; }
    public string LanguageName { get; set; }
    public string Username { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}