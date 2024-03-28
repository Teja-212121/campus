﻿import { Decorators } from "@serenity-is/corelib";

export enum EDifficultyLevel {
    EASY = 1,
    MODERATE = 5,
    DIFFICULT = 10,
    MULTIPLE_RIGHT_ANSWER = 11
}
Decorators.registerEnumType(EDifficultyLevel, 'GXpert.Web.Enums.EDifficultyLevel');