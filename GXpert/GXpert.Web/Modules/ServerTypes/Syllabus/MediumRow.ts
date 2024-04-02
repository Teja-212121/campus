﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface MediumRow {
    Id?: number;
    Title?: string;
    Description?: string;
    IsActive?: boolean;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class MediumRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Title';
    static readonly localTextPrefix = 'Syllabus.Medium';
    static readonly lookupKey = 'Syllabus.Medium';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<MediumRow>('Syllabus.Medium') }
    static async getLookupAsync() { return getLookupAsync<MediumRow>('Syllabus.Medium') }

    static readonly deletePermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly insertPermission = 'Syllabus:SyllabusManagement:Modify';
    static readonly readPermission = 'Syllabus:SyllabusManagement:View';
    static readonly updatePermission = 'Syllabus:SyllabusManagement:Modify';

    static readonly Fields = fieldsProxy<MediumRow>();
}