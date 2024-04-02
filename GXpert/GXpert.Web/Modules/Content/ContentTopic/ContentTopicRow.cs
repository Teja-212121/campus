using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Content;

[ConnectionKey("Default"), Module("Content"), TableName("ContentTopics")]
[DisplayName("Content Topic"), InstanceName("Content Topic")]
[ReadPermission(PermissionKeys.ContentManagement.View)]
[ModifyPermission(PermissionKeys.ContentManagement.View)]
public sealed class ContentTopicRow : LoggingRow<ContentTopicRow.RowFields>, IIdRow
{
    const string jContent = nameof(jContent);
    const string jClass = nameof(jClass);
    const string jSubject = nameof(jSubject);
    const string jTopic = nameof(jTopic);
    const string jMedium = nameof(jMedium);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Content"), NotNull, ForeignKey(typeof(ContentRow)), LeftJoin(jContent), TextualField(nameof(ContentTitle))]
    [ServiceLookupEditor(typeof(ContentRow))]
    public int? ContentId { get => fields.ContentId[this]; set => fields.ContentId[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey("Classes", "Id"), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [LookupEditor("Syllabus.Class")]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Subject"), ForeignKey("Subjects", "Id"), LeftJoin(jSubject), TextualField(nameof(SubjectTitle))]
    [LookupEditor("Syllabus.Subject", CascadeFrom = "ClassId", CascadeField = "ClassId")]
    public int? SubjectId { get => fields.SubjectId[this]; set => fields.SubjectId[this] = value; }

    [DisplayName("Topic"), ForeignKey("Topics", "Id"), LeftJoin(jTopic), TextualField(nameof(TopicTitle))]
    [LookupEditor("Syllabus.Topic", CascadeFrom = "SubjectId", CascadeField = "SubjectId")]
    public int? TopicId { get => fields.TopicId[this]; set => fields.TopicId[this] = value; }

    [DisplayName("Medium"), ForeignKey("Mediums", "Id"), LeftJoin(jMedium), TextualField(nameof(MediumTitle))]
    [LookupEditor("Syllabus.Medium")]
    public int? MediumId { get => fields.MediumId[this]; set => fields.MediumId[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public short? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Content Title"), Origin(jContent, nameof(ContentRow.Title))]
    public string ContentTitle { get => fields.ContentTitle[this]; set => fields.ContentTitle[this] = value; }

    [DisplayName("Class Title"), Expression($"{jClass}.[Title]")]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

    [DisplayName("Subject Title"), Expression($"{jSubject}.[Title]")]
    public string SubjectTitle { get => fields.SubjectTitle[this]; set => fields.SubjectTitle[this] = value; }

    [DisplayName("Topic Title"), Expression($"{jTopic}.[Title]")]
    public string TopicTitle { get => fields.TopicTitle[this]; set => fields.TopicTitle[this] = value; }

    [DisplayName("Medium Title"), Expression($"{jMedium}.[Title]")]
    public string MediumTitle { get => fields.MediumTitle[this]; set => fields.MediumTitle[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field ContentId;
        public Int32Field ClassId;
        public Int32Field SubjectId;
        public Int32Field TopicId;
        public Int32Field MediumId;
        public Int16Field SortOrder;
        public BooleanField IsActive;

        public StringField ContentTitle;
        public StringField ClassTitle;
        public StringField SubjectTitle;
        public StringField TopicTitle;
        public StringField MediumTitle;
    }
}