﻿import { PreAcademicScoreForm, PreAcademicScoreRow, PreAcademicScoreService } from '@/ServerTypes/Masters';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('GXpert.Masters.PreAcademicScoreDialog')
export class PreAcademicScoreDialog extends EntityDialog<PreAcademicScoreRow, any> {
    protected getFormKey() { return PreAcademicScoreForm.formKey; }
    protected getRowDefinition() { return PreAcademicScoreRow; }
    protected getService() { return PreAcademicScoreService.baseUrl; }

    protected form = new PreAcademicScoreForm(this.idPrefix);
}