
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.cdisc.org/ns/odm/v1.3", IsNullable = false)]
public partial class StudyAudit_json
{

    private StudyAudit_jsonClinicalData[] clinicalDataField;

    private decimal studyAudit_jsonVersionField;

    private string fileTypeField;

    private string fileOIDField;

    private System.DateTime creationDateTimeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ClinicalData")]
    public StudyAudit_jsonClinicalData[] ClinicalData
    {
        get
        {
            return this.clinicalDataField;
        }
        set
        {
            this.clinicalDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal StudyAudit_jsonVersion
    {
        get
        {
            return this.studyAudit_jsonVersionField;
        }
        set
        {
            this.studyAudit_jsonVersionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileType
    {
        get
        {
            return this.fileTypeField;
        }
        set
        {
            this.fileTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FileOID
    {
        get
        {
            return this.fileOIDField;
        }
        set
        {
            this.fileOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime CreationDateTime
    {
        get
        {
            return this.creationDateTimeField;
        }
        set
        {
            this.creationDateTimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalData
{

    private StudyAudit_jsonClinicalDataSubjectData subjectDataField;

    private string studyOIDField;

    private ushort metaDataVersionOIDField;

    private string auditSubCategoryNameField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectData SubjectData
    {
        get
        {
            return this.subjectDataField;
        }
        set
        {
            this.subjectDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string StudyOID
    {
        get
        {
            return this.studyOIDField;
        }
        set
        {
            this.studyOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort MetaDataVersionOID
    {
        get
        {
            return this.metaDataVersionOIDField;
        }
        set
        {
            this.metaDataVersionOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public string AuditSubCategoryName
    {
        get
        {
            return this.auditSubCategoryNameField;
        }
        set
        {
            this.auditSubCategoryNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectData
{

    private StudyAudit_jsonClinicalDataSubjectDataAuditRecord auditRecordField;

    private StudyAudit_jsonClinicalDataSubjectDataSiteRef siteRefField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventData studyEventDataField;

    private string subjectKeyField;

    private string subjectKeyTypeField;

    private string subjectNameField;

    private string transactionTypeField;

    private string statusField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataAuditRecord AuditRecord
    {
        get
        {
            return this.auditRecordField;
        }
        set
        {
            this.auditRecordField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataSiteRef SiteRef
    {
        get
        {
            return this.siteRefField;
        }
        set
        {
            this.siteRefField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventData StudyEventData
    {
        get
        {
            return this.studyEventDataField;
        }
        set
        {
            this.studyEventDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string SubjectKey
    {
        get
        {
            return this.subjectKeyField;
        }
        set
        {
            this.subjectKeyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public string SubjectKeyType
    {
        get
        {
            return this.subjectKeyTypeField;
        }
        set
        {
            this.subjectKeyTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public string SubjectName
    {
        get
        {
            return this.subjectNameField;
        }
        set
        {
            this.subjectNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TransactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public string Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataAuditRecord
{

    private StudyAudit_jsonClinicalDataSubjectDataAuditRecordUserRef userRefField;

    private StudyAudit_jsonClinicalDataSubjectDataAuditRecordLocationRef locationRefField;

    private System.DateTime dateTimeStampField;

    private string reasonForChangeField;

    private uint sourceIDField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataAuditRecordUserRef UserRef
    {
        get
        {
            return this.userRefField;
        }
        set
        {
            this.userRefField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataAuditRecordLocationRef LocationRef
    {
        get
        {
            return this.locationRefField;
        }
        set
        {
            this.locationRefField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateTimeStamp
    {
        get
        {
            return this.dateTimeStampField;
        }
        set
        {
            this.dateTimeStampField = value;
        }
    }

    /// <remarks/>
    public string ReasonForChange
    {
        get
        {
            return this.reasonForChangeField;
        }
        set
        {
            this.reasonForChangeField = value;
        }
    }

    /// <remarks/>
    public uint SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataAuditRecordUserRef
{

    private string userOIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserOID
    {
        get
        {
            return this.userOIDField;
        }
        set
        {
            this.userOIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataAuditRecordLocationRef
{

    private uint locationOIDField;

    private uint studyEnvSiteNumberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint LocationOID
    {
        get
        {
            return this.locationOIDField;
        }
        set
        {
            this.locationOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint StudyEnvSiteNumber
    {
        get
        {
            return this.studyEnvSiteNumberField;
        }
        set
        {
            this.studyEnvSiteNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataSiteRef
{

    private uint locationOIDField;

    private uint studyEnvSiteNumberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint LocationOID
    {
        get
        {
            return this.locationOIDField;
        }
        set
        {
            this.locationOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint StudyEnvSiteNumber
    {
        get
        {
            return this.studyEnvSiteNumberField;
        }
        set
        {
            this.studyEnvSiteNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventData
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecord auditRecordField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormData formDataField;

    private string studyEventOIDField;

    private string studyEventRepeatKeyField;

    private uint instanceIdField;

    private bool instanceIdFieldSpecified;

    private string transactionTypeField;

    private string instanceNameField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecord AuditRecord
    {
        get
        {
            return this.auditRecordField;
        }
        set
        {
            this.auditRecordField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormData FormData
    {
        get
        {
            return this.formDataField;
        }
        set
        {
            this.formDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string StudyEventOID
    {
        get
        {
            return this.studyEventOIDField;
        }
        set
        {
            this.studyEventOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string StudyEventRepeatKey
    {
        get
        {
            return this.studyEventRepeatKeyField;
        }
        set
        {
            this.studyEventRepeatKeyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint InstanceId
    {
        get
        {
            return this.instanceIdField;
        }
        set
        {
            this.instanceIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool InstanceIdSpecified
    {
        get
        {
            return this.instanceIdFieldSpecified;
        }
        set
        {
            this.instanceIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TransactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public string InstanceName
    {
        get
        {
            return this.instanceNameField;
        }
        set
        {
            this.instanceNameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecord
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecordUserRef userRefField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecordLocationRef locationRefField;

    private System.DateTime dateTimeStampField;

    private object reasonForChangeField;

    private uint sourceIDField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecordUserRef UserRef
    {
        get
        {
            return this.userRefField;
        }
        set
        {
            this.userRefField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecordLocationRef LocationRef
    {
        get
        {
            return this.locationRefField;
        }
        set
        {
            this.locationRefField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateTimeStamp
    {
        get
        {
            return this.dateTimeStampField;
        }
        set
        {
            this.dateTimeStampField = value;
        }
    }

    /// <remarks/>
    public object ReasonForChange
    {
        get
        {
            return this.reasonForChangeField;
        }
        set
        {
            this.reasonForChangeField = value;
        }
    }

    /// <remarks/>
    public uint SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecordUserRef
{

    private string userOIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserOID
    {
        get
        {
            return this.userOIDField;
        }
        set
        {
            this.userOIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataAuditRecordLocationRef
{

    private uint locationOIDField;

    private uint studyEnvSiteNumberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint LocationOID
    {
        get
        {
            return this.locationOIDField;
        }
        set
        {
            this.locationOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint StudyEnvSiteNumber
    {
        get
        {
            return this.studyEnvSiteNumberField;
        }
        set
        {
            this.studyEnvSiteNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormData
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecord auditRecordField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupData itemGroupDataField;

    private string formOIDField;

    private byte formRepeatKeyField;

    private uint dataPageIdField;

    private string transactionTypeField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecord AuditRecord
    {
        get
        {
            return this.auditRecordField;
        }
        set
        {
            this.auditRecordField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupData ItemGroupData
    {
        get
        {
            return this.itemGroupDataField;
        }
        set
        {
            this.itemGroupDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string FormOID
    {
        get
        {
            return this.formOIDField;
        }
        set
        {
            this.formOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte FormRepeatKey
    {
        get
        {
            return this.formRepeatKeyField;
        }
        set
        {
            this.formRepeatKeyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint DataPageId
    {
        get
        {
            return this.dataPageIdField;
        }
        set
        {
            this.dataPageIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TransactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecord
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecordUserRef userRefField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecordLocationRef locationRefField;

    private System.DateTime dateTimeStampField;

    private string reasonForChangeField;

    private uint sourceIDField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecordUserRef UserRef
    {
        get
        {
            return this.userRefField;
        }
        set
        {
            this.userRefField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecordLocationRef LocationRef
    {
        get
        {
            return this.locationRefField;
        }
        set
        {
            this.locationRefField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateTimeStamp
    {
        get
        {
            return this.dateTimeStampField;
        }
        set
        {
            this.dateTimeStampField = value;
        }
    }

    /// <remarks/>
    public string ReasonForChange
    {
        get
        {
            return this.reasonForChangeField;
        }
        set
        {
            this.reasonForChangeField = value;
        }
    }

    /// <remarks/>
    public uint SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecordUserRef
{

    private string userOIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserOID
    {
        get
        {
            return this.userOIDField;
        }
        set
        {
            this.userOIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataAuditRecordLocationRef
{

    private uint locationOIDField;

    private uint studyEnvSiteNumberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint LocationOID
    {
        get
        {
            return this.locationOIDField;
        }
        set
        {
            this.locationOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint StudyEnvSiteNumber
    {
        get
        {
            return this.studyEnvSiteNumberField;
        }
        set
        {
            this.studyEnvSiteNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupData
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecord auditRecordField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemData itemDataField;

    private string itemGroupOIDField;

    private uint recordIdField;

    private byte itemGroupRepeatKeyField;

    private bool itemGroupRepeatKeyFieldSpecified;

    private string transactionTypeField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecord AuditRecord
    {
        get
        {
            return this.auditRecordField;
        }
        set
        {
            this.auditRecordField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemData ItemData
    {
        get
        {
            return this.itemDataField;
        }
        set
        {
            this.itemDataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemGroupOID
    {
        get
        {
            return this.itemGroupOIDField;
        }
        set
        {
            this.itemGroupOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint RecordId
    {
        get
        {
            return this.recordIdField;
        }
        set
        {
            this.recordIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte ItemGroupRepeatKey
    {
        get
        {
            return this.itemGroupRepeatKeyField;
        }
        set
        {
            this.itemGroupRepeatKeyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ItemGroupRepeatKeySpecified
    {
        get
        {
            return this.itemGroupRepeatKeyFieldSpecified;
        }
        set
        {
            this.itemGroupRepeatKeyFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TransactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecord
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecordUserRef userRefField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecordLocationRef locationRefField;

    private System.DateTime dateTimeStampField;

    private string reasonForChangeField;

    private uint sourceIDField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecordUserRef UserRef
    {
        get
        {
            return this.userRefField;
        }
        set
        {
            this.userRefField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecordLocationRef LocationRef
    {
        get
        {
            return this.locationRefField;
        }
        set
        {
            this.locationRefField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateTimeStamp
    {
        get
        {
            return this.dateTimeStampField;
        }
        set
        {
            this.dateTimeStampField = value;
        }
    }

    /// <remarks/>
    public string ReasonForChange
    {
        get
        {
            return this.reasonForChangeField;
        }
        set
        {
            this.reasonForChangeField = value;
        }
    }

    /// <remarks/>
    public uint SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecordUserRef
{

    private string userOIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserOID
    {
        get
        {
            return this.userOIDField;
        }
        set
        {
            this.userOIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataAuditRecordLocationRef
{

    private uint locationOIDField;

    private uint studyEnvSiteNumberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint LocationOID
    {
        get
        {
            return this.locationOIDField;
        }
        set
        {
            this.locationOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint StudyEnvSiteNumber
    {
        get
        {
            return this.studyEnvSiteNumberField;
        }
        set
        {
            this.studyEnvSiteNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemData
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecord auditRecordField;

    private Query queryField;

    private string itemOIDField;

    private string transactionTypeField;

    private string valueField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecord AuditRecord
    {
        get
        {
            return this.auditRecordField;
        }
        set
        {
            this.auditRecordField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public Query Query
    {
        get
        {
            return this.queryField;
        }
        set
        {
            this.queryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ItemOID
    {
        get
        {
            return this.itemOIDField;
        }
        set
        {
            this.itemOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TransactionType
    {
        get
        {
            return this.transactionTypeField;
        }
        set
        {
            this.transactionTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecord
{

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecordUserRef userRefField;

    private StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecordLocationRef locationRefField;

    private System.DateTime dateTimeStampField;

    private string reasonForChangeField;

    private uint sourceIDField;

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecordUserRef UserRef
    {
        get
        {
            return this.userRefField;
        }
        set
        {
            this.userRefField = value;
        }
    }

    /// <remarks/>
    public StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecordLocationRef LocationRef
    {
        get
        {
            return this.locationRefField;
        }
        set
        {
            this.locationRefField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DateTimeStamp
    {
        get
        {
            return this.dateTimeStampField;
        }
        set
        {
            this.dateTimeStampField = value;
        }
    }

    /// <remarks/>
    public string ReasonForChange
    {
        get
        {
            return this.reasonForChangeField;
        }
        set
        {
            this.reasonForChangeField = value;
        }
    }

    /// <remarks/>
    public uint SourceID
    {
        get
        {
            return this.sourceIDField;
        }
        set
        {
            this.sourceIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecordUserRef
{

    private string userOIDField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string UserOID
    {
        get
        {
            return this.userOIDField;
        }
        set
        {
            this.userOIDField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.cdisc.org/ns/odm/v1.3")]
public partial class StudyAudit_jsonClinicalDataSubjectDataStudyEventDataFormDataItemGroupDataItemDataAuditRecordLocationRef
{

    private uint locationOIDField;

    private uint studyEnvSiteNumberField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint LocationOID
    {
        get
        {
            return this.locationOIDField;
        }
        set
        {
            this.locationOIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
    public uint StudyEnvSiteNumber
    {
        get
        {
            return this.studyEnvSiteNumberField;
        }
        set
        {
            this.studyEnvSiteNumberField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mdsol.com/ns/odm/metadata")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.mdsol.com/ns/odm/metadata", IsNullable = false)]
public partial class Query
{

    private uint queryRepeatKeyField;

    private string valueField;

    private string statusField;

    private string responseField;

    private string recipientField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint QueryRepeatKey
    {
        get
        {
            return this.queryRepeatKeyField;
        }
        set
        {
            this.queryRepeatKeyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Response
    {
        get
        {
            return this.responseField;
        }
        set
        {
            this.responseField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Recipient
    {
        get
        {
            return this.recipientField;
        }
        set
        {
            this.recipientField = value;
        }
    }
}

