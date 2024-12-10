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

Partial Public Class Notifications
    Public Property id As Integer
    Public Property userId As Integer
    Public Property notificationTypeCode As String
    Public Property isRead As Boolean
    Public Property isDeleted As Boolean
    Public Property createdDate As Date
    Public Property updatedDate As Nullable(Of Date)
    Public Property FacilityID_FK As Nullable(Of Integer)

    Public Overridable Property Facility As Facility
    Public Overridable Property NotificationChat As ICollection(Of NotificationChat) = New HashSet(Of NotificationChat)
    Public Overridable Property NotificationEvent As ICollection(Of NotificationEvent) = New HashSet(Of NotificationEvent)
    Public Overridable Property Types As Types
    Public Overridable Property Users As Users
    Public Overridable Property NotificationTask As ICollection(Of NotificationTask) = New HashSet(Of NotificationTask)
    Public Overridable Property NotificationVitalSignDetails As ICollection(Of NotificationVitalSignDetails) = New HashSet(Of NotificationVitalSignDetails)

End Class