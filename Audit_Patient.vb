'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Audit_Patient
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property PatientID As Integer
    Public Property Firstname As String
    Public Property Lastname As String
    Public Property NRIC As String
    Public Property DateOfBirth As Nullable(Of Date)
    Public Property Age As Nullable(Of Integer)
    Public Property PostalCode As String
    Public Property Photo As String
    Public Property CareManagerAssignedID As Nullable(Of Integer)
    Public Property CaseID As String
    Public Property DrugAllergy As String
    Public Property Status As String
    Public Property DischargeNoticePeriodInMonths As Nullable(Of Integer)
    Public Property AdmittedDate As Nullable(Of Date)
    Public Property ReasonOfAdmission As String
    Public Property AMD As Nullable(Of Boolean)
    Public Property ACP As Nullable(Of Boolean)
    Public Property PACEMAKER As Nullable(Of Boolean)
    Public Property ACID As Nullable(Of Boolean)
    Public Property MobilePhone As String
    Public Property HomePhone As String
    Public Property Email As String
    Public Property GenogramPicture As String
    Public Property ReferringDiagnosis As String
    Public Property MailForVitalAlert1 As String
    Public Property MailForVitalAlert2 As String
    Public Property MailForVitalAlert3 As String
    Public Property MailForFamilyNotification1 As String
    Public Property MailForFamilyNotification2 As String
    Public Property VisitingFrequency As String
    Public Property NumberOfChildren As Nullable(Of Integer)
    Public Property Occupation As String
    Public Property UpfrontPayment As Nullable(Of Boolean)
    Public Property CareReviewDate As Nullable(Of Date)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property PatientTypeID_FK As Nullable(Of Integer)
    Public Property MailingAddress1 As String
    Public Property MailingAddress2 As String
    Public Property MailingAddress3 As String
    Public Property GenderID_FK As Nullable(Of Integer)
    Public Property BloodTypeID_FK As Nullable(Of Integer)
    Public Property ResidentTypeID_FK As Nullable(Of Integer)
    Public Property MaritalStatusID_FK As Nullable(Of Integer)
    Public Property ReligionID_FK As Nullable(Of Integer)
    Public Property PatientProfileID_FK As Nullable(Of Integer)
    Public Property RaceID_FK As Nullable(Of Integer)
    Public Property PatientAdditionalInfoID_FK As Nullable(Of Integer)
    Public Property PatientReferralID_FK As Nullable(Of Integer)
    Public Property MedicalHistoryRemarks As String
    Public Property PatientMedicationID_FK As Nullable(Of Integer)
    Public Property PatientReferralByID_FK As Nullable(Of Integer)
    Public Property IdentificationNumber As String
    Public Property IdentificationAttachmentFilename As String
    Public Property IdentificationAttachmentPhysical As String
    Public Property OtherRace As String
    Public Property OtherLanguage As String
    Public Property PaymentMode As String
    Public Property InvoiceModeID_FK As Nullable(Of Integer)
    Public Property DisplayName As String
    Public Property OrderID As String
    Public Property Accepted As Nullable(Of Boolean)
    Public Property NursingStation As String
    Public Property AccessHospitalID_FK As Nullable(Of Integer)
    Public Property ActionDescription As String
    Public Property IntegrationSourceID As String

End Class
