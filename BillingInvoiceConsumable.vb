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

Partial Public Class BillingInvoiceConsumable
    Public Property BillingInvoiceConsumableID As Integer
    Public Property BillingInvoiceID_FK As Integer
    Public Property ItemID_FK As Integer
    Public Property Quantity As Integer
    Public Property UnitPrice As Decimal
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

    Public Overridable Property BillingInvoice As BillingInvoice
    Public Overridable Property Item As Item

End Class
