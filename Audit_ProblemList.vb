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

Partial Public Class Audit_ProblemList
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property ProblemListID As Integer
    Public Property DiseaseID_FK As Integer
    Public Property ProblemInfo As String
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property TypeOfGoal As Nullable(Of Integer)
    Public Property DiseaseSubInfoID_FK As Nullable(Of Integer)

End Class
