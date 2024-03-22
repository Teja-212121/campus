﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ClassRow } from "./ClassRow";

export interface ClassColumns {
    Id: Column<ClassRow>;
    Title: Column<ClassRow>;
    CourseName: Column<ClassRow>;
    Description: Column<ClassRow>;
    SortOrder: Column<ClassRow>;
    Weightage: Column<ClassRow>;
    Thumbnail: Column<ClassRow>;
}

export class ClassColumns extends ColumnsBase<ClassRow> {
    static readonly columnsKey = 'Syllabus.Class';
    static readonly Fields = fieldsProxy<ClassColumns>();
}