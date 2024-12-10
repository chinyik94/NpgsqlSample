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

Partial Public Class Audit_PatientReferral
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property PatientReferralID As Integer
    Public Property PrimaryClinicianID_FK As Nullable(Of Integer)
    Public Property SecondaryClinicianID_FK As Nullable(Of Integer)
    Public Property PatientAwareDiagnose As Nullable(Of Boolean)
    Public Property FamilyAwareDiagnose As Nullable(Of Boolean)
    Public Property PatientAwarePrognosis As Nullable(Of Boolean)
    Public Property FamilyAwarePrognosis As Nullable(Of Boolean)
    Public Property PatientAwareDiagnoseReason As String
    Public Property FamilyAwareDiagnoseReason As String
    Public Property PatientAwarePrognosisReason As String
    Public Property FamilyAwarePrognosisReason As String
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property PrimaryNurseID_FK As Nullable(Of Integer)
    Public Property SecondaryNurseID_FK As Nullable(Of Integer)

End Class