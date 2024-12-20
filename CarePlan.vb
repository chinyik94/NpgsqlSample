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

Partial Public Class CarePlan
    Public Property CarePlanID As Integer
    Public Property PatientID_FK As Nullable(Of Integer)
    Public Property DiagnosisID_FK As Nullable(Of Integer)
    Public Property CarePlanStatusID_FK As Nullable(Of Integer)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Nullable(Of Boolean)
    Public Property InitialCareAssessmentID_FK As Nullable(Of Integer)
    Public Property CarePlanDetailID_FK As Nullable(Of Integer)
    Public Property CarePlanName As String
    Public Property IsClosed As Nullable(Of Boolean)
    Public Property PersonInCharge As Nullable(Of Integer)
    Public Property CarePlanType As String
    Public Property Remark As String

    Public Overridable Property CarePlanStatus As CarePlanStatus
    Public Overridable Property Diagnosis As Diagnosis
    Public Overridable Property Patient As Patient
    Public Overridable Property CarePlanSub As ICollection(Of CarePlanSub) = New HashSet(Of CarePlanSub)
    Public Overridable Property CareReport As ICollection(Of CareReport) = New HashSet(Of CareReport)

End Class
