<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Generator.ascx.cs" Inherits="Aspose.SiteFinity.BarcodeGenerator.Generator" %>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css">
<style>
    .pagination-ys {
    /*display: inline-block;*/
    padding-left: 0;
    margin: 20px 0;
    border-radius: 4px;
}

.pagination-ys table > tbody > tr > td {
    display: inline;
}

.pagination-ys table > tbody > tr > td > a,
.pagination-ys table > tbody > tr > td > span {
    position: relative;
    float: left;
    padding: 8px 12px;
    line-height: 1.42857143;
    text-decoration: none;
    color: #dd4814;
    background-color: #ffffff;
    border: 1px solid #dddddd;
    margin-left: -1px;
}

.pagination-ys table > tbody > tr > td > span {
    position: relative;
    float: left;
    padding: 8px 12px;
    line-height: 1.42857143;
    text-decoration: none;    
    margin-left: -1px;
    z-index: 2;
    color: #aea79f;
    background-color: #f5f5f5;
    border-color: #dddddd;
    cursor: default;
}
</style>
<h2 class="sub-header" id="widgetTitle">Aspose Product Listing with Barcodes for SiteFinity</h2>
<div class="row">
    <asp:GridView ID="SitefinityProductsGridView" EmptyDataText="There are no products." Width="100%" EmptyDataRowStyle-CssClass="emptyClass"
        GridLines="None" BorderWidth="0" AutoGenerateColumns="false" ShowHeader="false"
        CssClass="table table-striped" ClientIDMode="Static" runat="server" AllowPaging="True" PageSize="5" OnPageIndexChanging="SitefinityProductsGridView_PageIndexChanging" >
        <Columns>            
            <asp:ImageField DataImageUrlField="ThumbURL" />
            <asp:BoundField DataField="ProductTitle" />
            <asp:BoundField DataField="DisplayPrice" />
            <asp:ImageField DataImageUrlField="ProductBarcode" />             
        </Columns>
        <PagerStyle CssClass="pagination-ys" />
    </asp:GridView>
</div>