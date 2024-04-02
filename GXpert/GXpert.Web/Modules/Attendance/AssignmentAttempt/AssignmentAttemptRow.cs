using GXpert.Web.Enums;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using Serenity.Extensions.Entities;
using System;
using System.ComponentModel;

namespace GXpert.Attendance;

[ConnectionKey("Default"), Module("Attendance"), TableName("AssignmentAttempts")]
[DisplayName("Assignment Attempt"), InstanceName("Assignment Attempt")]
[ReadPermission(PermissionKeys.AttendanceManagement.View)]
[ModifyPermission(PermissionKeys.AttendanceManagement.Modify)]
[ServiceLookupPermission("Administration:General")]
public sealed class AssignmentAttemptRow : LoggingRow<AssignmentAttemptRow.RowFields>, IIdRow, INameRow
{
    const string jAssignment = nameof(jAssignment);
    const string jStudent = nameof(jStudent);
    const string jTeacher = nameof(jTeacher);
    const string jPlayList = nameof(jPlayList);
    const string jActivation = nameof(jActivation);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Assignment"), NotNull, ForeignKey("Assignments", "Id"), LeftJoin(jAssignment), TextualField(nameof(AssignmentTitle))]
    [LookupEditor("Exams.Assignment")]
    public int? AssignmentId { get => fields.AssignmentId[this]; set => fields.AssignmentId[this] = value; }

    [DisplayName("Student"), ForeignKey("Students", "Id"), LeftJoin(jStudent), TextualField(nameof(StudentPrn))]
    [LookupEditor("Users.Student")]
    public int? StudentId { get => fields.StudentId[this]; set => fields.StudentId[this] = value; }

    [DisplayName("File Uploaded"), NotNull, QuickSearch, NameProperty, FileUploadEditor]
    public string FileUploaded { get => fields.FileUploaded[this]; set => fields.FileUploaded[this] = value; }

    [DisplayName("E Status"), Column("eStatus"), Size(255)]
    public EExamAttemptStatus? EStatus { get => (EExamAttemptStatus?)fields.EStatus[this]; set => fields.EStatus[this] = (short?)value; }

    [DisplayName("Teacher"), ForeignKey("Teachers", "Id"), LeftJoin(jTeacher), TextualField(nameof(TeacherPrn))]
    [LookupEditor("Users.Teacher")]
    public int? TeacherId { get => fields.TeacherId[this]; set => fields.TeacherId[this] = value; }

    [DisplayName("Play List"), NotNull, ForeignKey("PlayLists", "Id"), LeftJoin(jPlayList), TextualField(nameof(PlayListTitle))]
    [LookupEditor("Playlist.PlayList")]
    public int? PlayListId { get => fields.PlayListId[this]; set => fields.PlayListId[this] = value; }

    [DisplayName("Activation"), NotNull, ForeignKey("Activations", "Id"), LeftJoin(jActivation), TextualField(nameof(ActivationDeviceId))]
    [LookupEditor("Activation.Activation")]
    public int? ActivationId { get => fields.ActivationId[this]; set => fields.ActivationId[this] = value; }

    [DisplayName("Is Active"), DefaultValue(1)]
    public bool? IsActive { get => fields.IsActive[this]; set => fields.IsActive[this] = value; }

    [DisplayName("Assignment Title"), Expression($"{jAssignment}.[Title]")]
    public string AssignmentTitle { get => fields.AssignmentTitle[this]; set => fields.AssignmentTitle[this] = value; }

    [DisplayName("Student Prn"), Expression($"{jStudent}.[PRN]")]
    public string StudentPrn { get => fields.StudentPrn[this]; set => fields.StudentPrn[this] = value; }

    [DisplayName("Teacher Prn"), Expression($"{jTeacher}.[PRN]")]
    public string TeacherPrn { get => fields.TeacherPrn[this]; set => fields.TeacherPrn[this] = value; }

    [DisplayName("Play List Title"), Expression($"{jPlayList}.[Title]")]
    public string PlayListTitle { get => fields.PlayListTitle[this]; set => fields.PlayListTitle[this] = value; }

    [DisplayName("Activation Device Id"), Expression($"{jActivation}.[DeviceId]")]
    public string ActivationDeviceId { get => fields.ActivationDeviceId[this]; set => fields.ActivationDeviceId[this] = value; }

    public class RowFields : LoggingRowFields
    {
        public Int32Field Id;
        public Int32Field AssignmentId;
        public Int32Field StudentId;
        public StringField FileUploaded;
        public Int16Field EStatus;
        public Int32Field TeacherId;
        public Int32Field PlayListId;
        public Int32Field ActivationId;
        public BooleanField IsActive;

        public StringField AssignmentTitle;
        public StringField StudentPrn;
        public StringField TeacherPrn;
        public StringField PlayListTitle;
        public StringField ActivationDeviceId;
    }
}