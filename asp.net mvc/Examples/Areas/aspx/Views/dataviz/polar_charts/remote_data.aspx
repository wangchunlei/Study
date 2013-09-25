<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/aspx/Views/Shared/DataViz.Master" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<asp:Content ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<div class="chart-wrapper">
    <%= Html.Kendo().Chart<Domas.Web.Mvc.Examples.Models.Chart.AntennaGainItem>()
        .Name("chart")
        .Title("Antenna Gain (dB)")
        .DataSource(ds => ds.Read(read => read.Action("_AntennaGain", "Polar_Charts")))
        .Series(series =>
        {
            series.PolarLine(model => model.Azimuth, model => model.Gain);
        })
        .XAxis(axis => axis.Numeric()
            .MajorUnit(30)
        )
    %>
</div>
</asp:Content>
