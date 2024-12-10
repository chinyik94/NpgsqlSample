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

Partial Public Class SystemForDisease
    Public Property SystemID As Integer
    Public Property System As String
    Public Property IsSystemUsed As Boolean
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property GroupCode As Nullable(Of Integer)

    Public Overridable Property CarePlanDetail As ICollection(Of CarePlanDetail) = New HashSet(Of CarePlanDetail)
    Public Overridable Property Disease As ICollection(Of Disease) = New HashSet(Of Disease)

End Class
