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

Partial Public Class Facility
    Public Property FacilityID As Integer
    Public Property FacilityName As String
    Public Property OrganizationID_FK As Integer
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property C_id As String
    Public Property IntegrationSource As String
    Public Property Remarks As String

    Public Overridable Property Code As Code
    Public Overridable Property Notifications As ICollection(Of Notifications) = New HashSet(Of Notifications)
    Public Overridable Property Patient As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property UserCategory As ICollection(Of UserCategory) = New HashSet(Of UserCategory)

End Class
