using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.LiveSessions;

[ConnectionKey("Default"), Module("LiveSessions"), TableName("Polls")]
[DisplayName("Poll"), InstanceName("Poll")]
[ReadPermission(PermissionKeys.LiveSessionsManagement.View)]
[ModifyPermission(PermissionKeys.LiveSessionsManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
[LookupScript("LiveSessions.Poll")]
public sealed class PollRow : LoggingRow<PollRow.RowFields>, IIdRow, INameRow
{
    const string jLiveSessionLog = nameof(jLiveSessionLog);
    const string jBloomsTaxonomy = nameof(jBloomsTaxonomy);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Question"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Question { get => fields.Question[this]; set => fields.Question[this] = value; }

    [DisplayName("E Question Type"), Column("eQuestionType"), NotNull]
    public EQuestionType? EQuestionType { get => (EQuestionType?)fields.EQuestionType[this]; set => fields.EQuestionType[this] = (short?)value; }

    [DisplayName("Option1"), Size(500), NotNull]
    public string Option1 { get => fields.Option1[this]; set => fields.Option1[this] = value; }

    [DisplayName("Option2"), Size(500), NotNull]
    public string Option2 { get => fields.Option2[this]; set => fields.Option2[this] = value; }

    [DisplayName("Option3"), Size(500)]
    public string Option3 { get => fields.Option3[this]; set => fields.Option3[this] = value; }

    [DisplayName("Option4"), Size(500)]
    public string Option4 { get => fields.Option4[this]; set => fields.Option4[this] = value; }

    [DisplayName("Option5"), Size(500)]
    public string Option5 { get => fields.Option5[this]; set => fields.Option5[this] = value; }

    [DisplayName("Right Answer"), Size(500)]
    public string RightAnswer { get => fields.RightAnswer[this]; set => fields.RightAnswer[this] = value; }

    [DisplayName("Live Session Log"), ForeignKey(typeof(LiveSessionLogRow)), LeftJoin(jLiveSessionLog)]
    [ServiceLookupEditor(typeof(LiveSessionLogRow))]
    public int? LiveSessionLogId { get => fields.LiveSessionLogId[this]; set => fields.LiveSessionLogId[this] = value; }

    [DisplayName("Total Attempts"), NotNull]
    public short? TotalAttempts { get => fields.TotalAttempts[this]; set => fields.TotalAttempts[this] = value; }

    [DisplayName("Average Response Time"), NotNull]
    public float? AverageResponseTime { get => fields.AverageResponseTime[this]; set => fields.AverageResponseTime[this] = value; }

    [DisplayName("Number Of Correct"), NotNull]
    public short? NumberOfCorrect { get => fields.NumberOfCorrect[this]; set => fields.NumberOfCorrect[this] = value; }

    [DisplayName("Number Of Wrong"), NotNull]
    public short? NumberOfWrong { get => fields.NumberOfWrong[this]; set => fields.NumberOfWrong[this] = value; }

    [DisplayName("Blooms Taxonomy"), NotNull, ForeignKey("BloomsTaxanomy", "Id"), LeftJoin(jBloomsTaxonomy)]
    [TextualField(nameof(BloomsTaxonomyCoginitiveSkill))]
    [LookupEditor("Masters.BloomsTaxanomy")]
    public int? BloomsTaxonomyId { get => fields.BloomsTaxonomyId[this]; set => fields.BloomsTaxonomyId[this] = value; }

    [DisplayName("Weightage"), NotNull]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Blooms Taxonomy Coginitive Skill"), Expression($"{jBloomsTaxonomy}.[CoginitiveSkill]")]
    public string BloomsTaxonomyCoginitiveSkill { get => fields.BloomsTaxonomyCoginitiveSkill[this]; set => fields.BloomsTaxonomyCoginitiveSkill[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Question;
        public Int16Field EQuestionType;
        public StringField Option1;
        public StringField Option2;
        public StringField Option3;
        public StringField Option4;
        public StringField Option5;
        public StringField RightAnswer;
        public Int32Field LiveSessionLogId;
        public Int16Field TotalAttempts;
        public SingleField AverageResponseTime;
        public Int16Field NumberOfCorrect;
        public Int16Field NumberOfWrong;
        public Int32Field BloomsTaxonomyId;
        public SingleField Weightage;
        public BooleanField IsActive;

        public StringField BloomsTaxonomyCoginitiveSkill;
    }
}