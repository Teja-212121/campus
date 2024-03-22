﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { InstituteTeacherRow } from "./InstituteTeacherRow";

export interface InstituteTeacherColumns {
    Id: Column<InstituteTeacherRow>;
    TeacherPrn: Column<InstituteTeacherRow>;
    SchoolName: Column<InstituteTeacherRow>;
    ClassTitle: Column<InstituteTeacherRow>;
    SubjectTitle: Column<InstituteTeacherRow>;
    Description: Column<InstituteTeacherRow>;
    AcademicYearName: Column<InstituteTeacherRow>;
    InsertDate: Column<InstituteTeacherRow>;
    InsertUserId: Column<InstituteTeacherRow>;
    UpdateDate: Column<InstituteTeacherRow>;
    UpdateUserId: Column<InstituteTeacherRow>;
    IsActive: Column<InstituteTeacherRow>;
}

export class InstituteTeacherColumns extends ColumnsBase<InstituteTeacherRow> {
    static readonly columnsKey = 'Institute.InstituteTeacher';
    static readonly Fields = fieldsProxy<InstituteTeacherColumns>();
}