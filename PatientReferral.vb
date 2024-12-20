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

Partial Public Class PatientReferral
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

    Public Overridable Property InitialCareAssessment As ICollection(Of InitialCareAssessment) = New HashSet(Of InitialCareAssessment)
    Public Overridable Property Patient As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property PatientClinician As PatientClinician
    Public Overridable Property PatientClinician1 As PatientClinician
    Public Overridable Property PatientClinician2 As PatientClinician
    Public Overridable Property PatientClinician3 As PatientClinician
    Public Overridable Property Code As ICollection(Of Code) = New HashSet(Of Code)

End Class
