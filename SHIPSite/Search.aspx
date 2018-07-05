<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="SHIPSite.WebForm4"  MasterPageFile="~/Site.Master"%>

<asp:Content ID="MainContent" runat="server" contentplaceholderid="MainContent">

    <style>
        table {
     table-layout:fixed;
    }

    td {
        word-wrap: break-word !important; white-space: normal !important;
    }
    strong{
        font-size:14px;
        font-weight:900;
    }
    </style>


    <div style="height: 506px">
        <div style="width: 100%; position: relative; top: 50%; text-align: center;">
            <asp:TextBox ID="notFound" runat="server" BorderWidth=0px Font-Size="Large" Font-Italic="true" Font-Names= "Helvetica Neue, Helvetica, Arial, sans-serif" ></asp:TextBox>
        </div>
    ​<div style="width: 100%; height: 750px; overflow:auto; position: relative; top: 10%; text-align: center; left: -7px; overflow-x:hidden" id="centerDiv">
        <asp:GridView ID="GridView1" runat="server" SelectMethod="GetRows"
        ItemType="SHIPSite.Row" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" OnRowDataBound="GridView1_RowDataBound" AutoGenerateColumns="False" Height="101px">
            <Columns>
                <asp:BoundField DataField="id"  HeaderText="ID" HeaderStyle-HorizontalAlign="Center"  ItemStyle-Width="50px" >
                </asp:BoundField>
                <asp:BoundField DataField="title" HeaderText="TITLE" />
                <asp:BoundField DataField="snippet" HeaderText="SNIPPET" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="750px">
                </asp:BoundField>
                <asp:BoundField DataField="abs" HeaderText="ABSTRACT" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black"/>
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </div>
</div>









</asp:Content>