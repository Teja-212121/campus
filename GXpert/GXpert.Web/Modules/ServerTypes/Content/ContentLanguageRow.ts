﻿import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ContentLanguageRow {
    Id?: number;
    Name?: string;
    Description?: string;
    IsActive?: number;
    InsertUserId?: number;
    InsertDate?: string;
    UpdateUserId?: number;
    UpdateDate?: string;
}

export abstract class ContentLanguageRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Content.ContentLanguage';
    static readonly lookupKey = 'Content.ContentLanguage';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ContentLanguageRow>('Content.ContentLanguage') }
    static async getLookupAsync() { return getLookupAsync<ContentLanguageRow>('Content.ContentLanguage') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContentLanguageRow>();
}