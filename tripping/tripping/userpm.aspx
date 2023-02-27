<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="userpm.aspx.cs" Inherits="tripping.userpm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="height: 581px; background-image: url('image/varkala.jpg'); background-repeat: no-repeat;">
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="PACKAGE_ID" HeaderText="package Id" Visible="False" />
                    <asp:BoundField DataField="LOCATION_NAME" HeaderText="Location" />
                    <asp:BoundField DataField="IMAGE" HeaderText="Image" />
                    <asp:BoundField DataField="PACKAGE_NAME" HeaderText="Packagename" />
                    <asp:BoundField DataField="ACTIVITY_NAME" HeaderText="Activity " />
                    <asp:BoundField DataField="HOTEL_NAME" HeaderText="Hotelname" />
                    <asp:BoundField DataField="APPUSER_NAME" HeaderText="Username" />
                    <asp:BoundField DataField="CONTACT" HeaderText="Usercontact" />
                </Columns>
            </asp:GridView>
 </div>
        </asp:Content>
