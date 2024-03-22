using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Syllabus;

[ConnectionKey("Default"), Module("Syllabus"), TableName("Subjects")]
[DisplayName("Subject"), InstanceName("Subject")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript("Syllabus.Subject")]
public sealed class SubjectRow : LoggingRow<SubjectRow.RowFields>, IIdRow, INameRow
{
    const string jClass = nameof(jClass);
    const string jMedium = nameof(jMedium);
    const string jCourse = nameof(jCourse);
    const string jSemester=nameof(jSemester);   

    [DisplayName("Id"), Identity, IdProperty, LookupInclude]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Title"), Size(500), NotNull, QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description"), Size(2000)]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Sort Order"), NotNull]
    public short? SortOrder { get => fields.SortOrder[this]; set => fields.SortOrder[this] = value; }

    [DisplayName("Class"), NotNull, ForeignKey(typeof(ClassRow)), LeftJoin(jClass), TextualField(nameof(ClassTitle))]
    [ServiceLookupEditor(typeof(ClassRow)), LookupInclude]
    public int? ClassId { get => fields.ClassId[this]; set => fields.ClassId[this] = value; }

    [DisplayName("Course"), NotNull, ForeignKey("Course", "Id"), LeftJoin(jCourse)]
    [ServiceLookupEditor(typeof(CourseRow)), LookupInclude]
    public int? CourseId { get => fields.CourseId[this]; set => fields.CourseId[this] = value; }

    [DisplayName("CourseName"), Expression($"{jCourse}.[Title]")]
    public string CourseName { get => fields.CourseName[this]; set => fields.CourseName[this] = value; }

    [DisplayName("Semester"), NotNull, ForeignKey("Semester", "Id"), LeftJoin(jSemester)]
    [ServiceLookupEditor(typeof(SemesterRow)), LookupInclude]
    public int? SemesterId { get => fields.SemesterId[this]; set => fields.SemesterId[this] = value; }

    [DisplayName("SemesterName"), Expression($"{jSemester}.[Title]")]
    public string SemesterName { get => fields.SemesterName[this]; set => fields.SemesterName[this] = value; }

    /*[DisplayName("Medium"), NotNull, ForeignKey(typeof(MediumRow)), LeftJoin(jMedium), TextualField(nameof(MediumTitle))]
    [ServiceLookupEditor(typeof(MediumRow)), LookupInclude]
    public int? MediumId { get => fields.MediumId[this]; set => fields.MediumId[this] = value; }*/

    [DisplayName("Weightage")]
    public float? Weightage { get => fields.Weightage[this]; set => fields.Weightage[this] = value; }

    [DisplayName("Thumbnail"), Size(500),FileUploadEditor]
    public string Thumbnail { get => fields.Thumbnail[this]; set => fields.Thumbnail[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Class Title"), Origin(jClass, nameof(ClassRow.Title))]
    public string ClassTitle { get => fields.ClassTitle[this]; set => fields.ClassTitle[this] = value; }

  /*  [DisplayName("Medium Title"), Origin(jMedium, nameof(MediumRow.Title))]
    public string MediumTitle { get => fields.MediumTitle[this]; set => fields.MediumTitle[this] = value; }
*/
    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public StringField Title;
        public StringField Description;
        public Int16Field SortOrder;
        public Int32Field ClassId;
        public Int32Field CourseId;
        public StringField CourseName;
        public Int32Field SemesterId;
        public StringField SemesterName;
        /* public Int32Field MediumId;*/
        public SingleField Weightage;
        public StringField Thumbnail;
        public BooleanField IsActive;

        public StringField ClassTitle;
      /*  public StringField MediumTitle;*/
    }
}