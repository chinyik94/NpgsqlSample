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

Partial Public Class PatientWound
    Public Property PatientWoundID As Integer
    Public Property PatientID_FK As Nullable(Of Integer)
    Public Property InitialCareAssessmentID_FK As Nullable(Of Integer)
    Public Property OccurDate As Nullable(Of Date)
    Public Property SeenDate As Nullable(Of Date)
    Public Property Site As String
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property LocationOfWound As String
    Public Property CareReportID_FK As Nullable(Of Integer)
    Public Property ActionDescription As String
    Public Property Remarks As String
    Public Property Category As String
    Public Property Stage As String
    Public Property WoundStatusID_FK As Nullable(Of Integer)
    Public Property Comments As String
    Public Property Status As String
    Public Property StatusRemark As String
    Public Property LocationRemark As String

    Public Overridable Property CareReport As CareReport
    Public Overridable Property Code As Code
    Public Overridable Property InitialCareAssessment As InitialCareAssessment
    Public Overridable Property Patient As Patient
    Public Overridable Property PatientWoundDraft As ICollection(Of PatientWoundDraft) = New HashSet(Of PatientWoundDraft)
    Public Overridable Property PatientWoundVisit As ICollection(Of PatientWoundVisit) = New HashSet(Of PatientWoundVisit)

End Class
