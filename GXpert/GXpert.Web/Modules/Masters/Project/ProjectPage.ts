﻿import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ProjectGrid } from './ProjectGrid';

export default function pageInit() {
    initFullHeightGridPage(new ProjectGrid($('#GridDiv')).element);
}