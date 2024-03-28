using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Content.Columns;

[ColumnsScript("Content.Content")]
[BasedOnRow(typeof(ContentRow), CheckNames = true)]
public class ContentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Title { get; set; }
    public string Description { get; set; }
    public short EContentType { get; set; }
    public string FileKeyUrl { get; set; }
    public string Iv { get; set; }
    public string MediaFile { get; set; }
    public string HlsFile { get; set; }
    public string FilePath { get; set; }
    public string FilePathFallBack1 { get; set; }
    public string FilePathFallBack2 { get; set; }
    public string MediaInfo { get; set; }
    public string ThumbNail { get; set; }
    public string Poster { get; set; }
    public int Length { get; set; }
    public int Size { get; set; }
    public int NumberOfPages { get; set; }
    public int LikesCount { get; set; }
    public int DisLikesCount { get; set; }
    public int HandRaiseCount { get; set; }
    public string SearchTags { get; set; }
    public short EDifficultyLevel { get; set; }
    
    public bool AllowDownload { get; set; }
    public int DurationInSeconds { get; set; }
    public bool EnableComments { get; set; }
    public string EncodingStatus { get; set; }
    public string FriendlyToken { get; set; }
    public short EContentState { get; set; }
    public int Views { get; set; }
    public bool IsFeatured { get; set; }
    public bool IsReviewed { get; set; }
    public bool IsListed { get; set; }
    public double ThumbnailTime { get; set; }
    public string Md5sum { get; set; }
    public bool IsUserFeatured { get; set; }
    public long SizeInBytes { get; set; }
    public short MediaVersion { get; set; }
    public string Username { get; set; }
    public string DownloadFilePrimaryUrl { get; set; }
    public string DownloadFileFallback1Url { get; set; }
    public string DownloadFileFallback2Url { get; set; }
    public string M3u8FilePrimaryUrl { get; set; }
    public string M3u8FileFallback1Url { get; set; }
    public string M3u8FileFallback2Url { get; set; }
}