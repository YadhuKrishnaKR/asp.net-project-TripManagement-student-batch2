<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="tripadmin.aspx.cs" Inherits="tripping.tripadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="LogIn.css" rel="stylesheet" />
        <style>
    body {
      background-image: url('Image/milky-way-2695569__480.jpg');
      background-repeat: no-repeat;
      background-size: cover;
    }
  </style> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:HiddenField ID="HiddenField1" runat="server" Value="-1"/>
   
    <div class="row w-100">
      <div class="col-lg-3">
        <div class="border border-white-50 bg-light admindiv text-muted ms-5 mt-5">
           <div class="mt-1">
                 <asp:Label ID="Label3" runat="server" Text="Manager Name" Visible="true"></asp:Label>
                 <asp:TextBox ID="TextBox2" runat="server" Visible="true" CssClass="form-control"></asp:TextBox>
           </div>
           <div class="mt-1">
                <asp:Label ID="Label4" runat="server" Text="EMAIL" Visible="true"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server" Visible="true" CssClass="form-control"></asp:TextBox>
           </div>
            <div class="mt-1">
                <asp:Label ID="Label5" runat="server" Text="CONTACT" Visible="true"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" Visible="true" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mt-1">
                <asp:Label ID="Label7" runat="server" Text="PASSWORD" Visible="true"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" Visible="true" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mt-1">
                <asp:Label ID="Label12" runat="server" Text="STATUS" Visible="true"></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server" Visible="true" CssClass="form-control"></asp:TextBox>
            </div>
           
            <br />
           <div class="d-flex justify-content-center">
                <asp:Button ID="save" runat="server" OnClick="save_Click" Text="save" Visible="true" CssClass="btn btn-success"/>
           </div>
                <asp:Button ID="clear" runat="server" OnClick="clear_Click" Text="clear" Visible="true" CssClass="btn btn-muted"/>
           
            <asp:Label runat="server" Text="Label" Visible="False" ID="Label6"></asp:Label>
             <asp:Label runat="server" Text="Label" Visible="False" ID="Label1"></asp:Label>
            <br />
    </div>
    </div>
            <div class="col-lg-9 mt-5">
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped table-bordered bg-light" AutoGenerateColumns="False" DataKeyNames="APPUSER_ID" Visible="true">
                    <HeaderStyle CssClass="table-dark" />
                    <Columns>
                        <asp:BoundField DataField="APPUSER_ID" HeaderText="APPUSER_ID" Visible="false" />
                        <asp:BoundField DataField="APPUSER_NAME" HeaderText="APPUSER_NAME" />
                        <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" />
                        <asp:BoundField DataField="CONTACT" HeaderText="CONTACT" />
                        <asp:BoundField DataField="PASSWORD" HeaderText="PASSWORD" />
                        <asp:BoundField DataField="STATUS" HeaderText="STATUS" />
                        <asp:BoundField DataField="CREATEDDATE" HeaderText="CREATEDDATE" />
                        <asp:BoundField DataField="MODIFIEDDATE" HeaderText="MODIFIEDDATE" />
                        <asp:TemplateField HeaderText="DELETE">
                            <ItemTemplate>
                                <asp:Button ID="btndlt" runat="server" CssClass="btn btn-danger" Text="Delete" OnClick="btndlt_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

    </div>
</asp:Content>
