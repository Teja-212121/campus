﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { InstituteStudentRow } from "./InstituteStudentRow";

export interface InstituteStudentColumns {
    Id: Column<InstituteStudentRow>;
    StudentPrn: Column<InstituteStudentRow>;
    SchoolName: Column<InstituteStudentRow>;
    ClassTitle: Column<InstituteStudentRow>;
    Division: Column<InstituteStudentRow>;
    RollNumber: Column<InstituteStudentRow>;
    Description: Column<InstituteStudentRow>;
    AcademicYearName: Column<InstituteStudentRow>;
}

export class InstituteStudentColumns extends ColumnsBase<InstituteStudentRow> {
    static readonly columnsKey = 'Institute.InstituteStudent';
    static readonly Fields = fieldsProxy<InstituteStudentColumns>();
}