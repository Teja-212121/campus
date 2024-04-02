﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface LiveSessionLogRow {
    Id?: number;
    Date?: string;
    StartTime?: string;
    EndTime?: string;
    TeacherId?: number;
    ClassId?: number;
    SubjectId?: number;
    IsActive?: boolean;
    TeacherPrn?: string;
    ClassTitle?: string;
    SubjectTitle?: string;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class LiveSessionLogRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'LiveSessions.LiveSessionLog';
    static readonly lookupKey = 'LiveSessions.LiveSessionLog';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<LiveSessionLogRow>('LiveSessions.LiveSessionLog') }
    static async getLookupAsync() { return getLookupAsync<LiveSessionLogRow>('LiveSessions.LiveSessionLog') }

    static readonly deletePermission = 'LiveSessions:LiveSessionsManagement:Modify';
    static readonly insertPermission = 'LiveSessions:LiveSessionsManagement:Modify';
    static readonly readPermission = 'LiveSessions:LiveSessionsManagement:View';
    static readonly updatePermission = 'LiveSessions:LiveSessionsManagement:Modify';

    static readonly Fields = fieldsProxy<LiveSessionLogRow>();
}