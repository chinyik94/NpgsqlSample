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

Partial Public Class Audit_CarePlanSubProblemList
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property CarePlanSubProblemListID As Integer
    Public Property CarePlanSubID_FK As Integer
    Public Property ProblemListID_FK As Integer
    Public Property PLReviewDate As Nullable(Of Date)
    Public Property PLStatus As String
    Public Property PersonInChargeID_FK As Nullable(Of Integer)
    Public Property TypeOfGoal As Nullable(Of Integer)
    Public Property Goal As String

End Class