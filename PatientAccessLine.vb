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

Partial Public Class PatientAccessLine
    Public Property PatientAccessLineID As Integer
    Public Property AccessLine As String
    Public Property CareReportID_FK As Integer
    Public Property DateOfInsertion As Date
    Public Property Patent As String
    Public Property PatentReSited As String
    Public Property PatentReSitedDate As Nullable(Of Date)
    Public Property PatentSite As String
    Public Property DateDueForChange As Date
    Public Property AccessLineRemarks As String
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)

    Public Overridable Property CareReport As CareReport

End Class
