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

Partial Public Class Branch
    Public Property BranchID As Integer
    Public Property BranchName As String
    Public Property Address1 As String
    Public Property Address2 As String
    Public Property Address3 As String
    Public Property Contact As String
    Public Property Email As String
    Public Property Status As String
    Public Property IsSystemUsed As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean
    Public Property CurrencyID_FK As Nullable(Of Integer)

    Public Overridable Property Code As Code
    Public Overridable Property Users As ICollection(Of Users) = New HashSet(Of Users)

End Class
