<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="userpm.aspx.cs" Inherits="tripping.userpm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="PackageManagers/cordinator.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="row w-100">
    <div class="col-lg-12">
        <br />
        <br />
        <h1 class="text-center text-white">USERS BOOKED DETAILS</h1>
          <div class=" m-5">
            <div class="table-responsive">
                <div class=" m-2">
                    <div class="table-responsive">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped bg-primary" >
                            <Columns>
                                <asp:BoundField DataField="PACKAGE_ID" HeaderText="Package ID" Visible="False" />
                                <asp:BoundField DataField="LOCATION_NAME" HeaderText="Location" />
                                <asp:BoundField DataField="IMAGE" HeaderText="Image" />
                                <asp:BoundField DataField="PACKAGE_NAME" HeaderText="Package Name" />
                                <asp:BoundField DataField="ACTIVITY_NAME" HeaderText="Activity " />
                                <asp:BoundField DataField="HOTEL_NAME" HeaderText="Hotel Name" />
                                <asp:BoundField DataField="APPUSER_NAME" HeaderText="Username" />
                                <asp:BoundField DataField="CONTACT" HeaderText="User Contact" />
                            </Columns>
                         </asp:GridView>
                     </div>
                </div>
            </div>
        </div>
    </div>
  </div>
        </asp:Content>
