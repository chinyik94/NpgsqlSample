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

Partial Public Class Audit_ScheduledTasks
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property ScheduleId As Integer
    Public Property ScheduleDescription As String
    Public Property PerformTask As String
    Public Property Everyday As Boolean
    Public Property Weekday As Boolean
    Public Property NDays As Integer
    Public Property WeekDays As String
    Public Property TimeStart As Nullable(Of Date)
    Public Property TimeEnd As Nullable(Of Date)
    Public Property Interval As Integer
    Public Property IntervalType As String
    Public Property StartDate As Nullable(Of Date)
    Public Property NextRun As Nullable(Of Date)
    Public Property LastRun As Nullable(Of Date)
    Public Property Status As String

End Class
