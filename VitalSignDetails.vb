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

Partial Public Class VitalSignDetails
    Public Property id As Integer
    Public Property vitalSignTypeId As Integer
    Public Property vitalSignId As Integer
    Public Property detailValue As Decimal
    Public Property IsDeleted As Boolean

    Public Overridable Property NotificationVitalSignDetails As ICollection(Of NotificationVitalSignDetails) = New HashSet(Of NotificationVitalSignDetails)
    Public Overridable Property PatientAMT As ICollection(Of PatientAMT) = New HashSet(Of PatientAMT)
    Public Overridable Property PatientBradenScale As ICollection(Of PatientBradenScale) = New HashSet(Of PatientBradenScale)
    Public Overridable Property PatientEBASDEP As ICollection(Of PatientEBASDEP) = New HashSet(Of PatientEBASDEP)
    Public Overridable Property PatientGCS As ICollection(Of PatientGCS) = New HashSet(Of PatientGCS)
    Public Overridable Property PatientMBI As ICollection(Of PatientMBI) = New HashSet(Of PatientMBI)
    Public Overridable Property PatientMFS As ICollection(Of PatientMFS) = New HashSet(Of PatientMFS)
    Public Overridable Property PatientMMSE As ICollection(Of PatientMMSE) = New HashSet(Of PatientMMSE)
    Public Overridable Property PatientRAF As ICollection(Of PatientRAF) = New HashSet(Of PatientRAF)
    Public Overridable Property VitalSigns As VitalSigns
    Public Overridable Property VitalSignTypes As VitalSignTypes

End Class
