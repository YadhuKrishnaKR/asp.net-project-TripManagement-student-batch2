<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="MyBooking.aspx.cs" Inherits="tripping.MyBooking" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../LogIn.css" rel="stylesheet" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="datadiv border bg-info">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="BOOKING_ID" CssClass="row">
  <ItemTemplate>
       <h1 class="text-light">Welcome <asp:Label ID="Label1" runat="server" Text='<%# Eval("APPUSER_NAME") %>' />, This is your Booking Details</h1>
      <div class="row w-100">
    <div class="col-md-3 mb-3">
      <asp:ImageMap ID="ImageMap1" runat="server" AlternateText='<%# Eval("IMAGE") %>' Height="114px" Width="152px" />
    </div>
    <div class="col-md-9 mb-3">
     <div class="margening">
          <asp:Label ID="lblid" runat="server" CssClass="mb-3" Text='<%# Eval("BOOKING_ID") %>' Visible="false" />
      <h4><asp:Label ID="lblpackage" runat="server" Text='<%# Eval("PACKAGE_NAME") %>' /></h4>
     
      <p><asp:Label ID="lblhotel" runat="server" Text='<%# Eval("HOTEL_NAME") %>' /></p>
      <p><asp:Label ID="lblactivity" runat="server" Text='<%# Eval("ACTIVITY_NAME") %>' /></p>
     </div>
    </div>
    </div>
  </ItemTemplate>
</asp:DataList>

</div>

</asp:Content>
