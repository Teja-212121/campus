﻿import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { EExamStatus } from "../Web/Enums.EExamStatus";
import { PlayListContentRow } from "./PlayListContentRow";

export interface PlayListContentColumns {
    Id: Column<PlayListContentRow>;
    PlayListTitle: Column<PlayListContentRow>;
    ContentTitle: Column<PlayListContentRow>;
    ExamTitle: Column<PlayListContentRow>;
    LiveSessionMeetingId: Column<PlayListContentRow>;
    AssignmentTitle: Column<PlayListContentRow>;
    ModuleTitle: Column<PlayListContentRow>;
    SortOrder: Column<PlayListContentRow>;
    EPublishStatus: Column<PlayListContentRow>;
}

export class PlayListContentColumns extends ColumnsBase<PlayListContentRow> {
    static readonly columnsKey = 'Playlist.PlayListContent';
    static readonly Fields = fieldsProxy<PlayListContentColumns>();
}

[EExamStatus]; // referenced types