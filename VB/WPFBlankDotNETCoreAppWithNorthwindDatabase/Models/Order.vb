Imports System.Collections.Generic

Namespace WPFBlankDotNETCoreAppWithNorthwindDatabase.Models

    Public Partial Class Order

        Public Sub New()
            OrderDetails = New HashSet(Of OrderDetail)()
        End Sub

        Public Property OrderId As Integer

        Public Property CustomerId As String

        Public Property EmployeeId As Integer?

        Public Property OrderDate As Date?

        Public Property RequiredDate As Date?

        Public Property ShippedDate As Date?

        Public Property ShipVia As Integer?

        Public Property Freight As Decimal?

        Public Property ShipName As String

        Public Property ShipAddress As String

        Public Property ShipCity As String

        Public Property ShipRegion As String

        Public Property ShipPostalCode As String

        Public Property ShipCountry As String

        Public Overridable Property Customer As Customer

        Public Overridable Property Employee As Employee

        Public Overridable Property ShipViaNavigation As Shipper

        Public Overridable Property OrderDetails As ICollection(Of OrderDetail)
    End Class
End Namespace
