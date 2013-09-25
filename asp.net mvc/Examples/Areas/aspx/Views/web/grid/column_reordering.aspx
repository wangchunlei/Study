<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/aspx/Views/Shared/Web.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<%: Html.Kendo().Grid<Domas.Web.Mvc.Examples.Models.OrderViewModel>()
    .Name("grid")
    .Pageable()
    .Sortable()
    .Scrollable()
    .HtmlAttributes(new { style = "height:430px;" })
    .Columns(columns =>
    {
        columns.Bound(o => o.OrderDate).Width(110).Format("{0:MM/dd/yyyy}");
        columns.Bound(o => o.ShipCountry).Width(110);
        columns.Bound(o => o.ShipCity).Width(110);
        columns.Bound(o => o.ShipName).Width(200);
        columns.Bound(o => o.ShippedDate).Format("{0:MM/dd/yyyy}");
        columns.Bound(o => o.OrderID).Width(60);
    })
    .DataSource(dataSource => dataSource
        .Ajax()
        .PageSize(15)
        .Read(read => read.Action("Orders_Read", "Grid"))
     )
    .Resizable(resize => resize.Columns(true))
    .Reorderable(reorder => reorder.Columns(true))
%>
</asp:Content>