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

Partial Public Class Audit_TaskUserLog
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property TaskUserLogID As Integer
    Public Property TaskID_FK As Integer
    Public Property UserID_FK As Integer
    Public Property StartDate As Date
    Public Property EndDate As Date
    Public Property Status As String
    Public Property FailReason As String
    Public Property StatusDate As Nullable(Of Date)
    Public Property HideDashboard As Nullable(Of Boolean)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

End Class
