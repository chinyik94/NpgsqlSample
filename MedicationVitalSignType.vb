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

Partial Public Class MedicationVitalSignType
    Public Property MedicationVitalSignTypeID As Integer
    Public Property MedicationID_FK As Integer
    Public Property VitalSignTypeID_FK As Integer
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

    Public Overridable Property Code As Code
    Public Overridable Property VitalSignTypes As VitalSignTypes

End Class
