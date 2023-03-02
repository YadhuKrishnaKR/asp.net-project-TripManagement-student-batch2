<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="tripping.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="LogIn.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">\
   <div class="d-flex justify-content-center">
    <div class="border bg-dark p-3">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Basic Fare" CssClass="text-light"></asp:Label>
            <asp:TextBox ID="TextBoxbasicfare" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Activity Fare" CssClass="text-light"></asp:Label>
            <asp:TextBox ID="TextBoxactivityfare" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="Label3" runat="server" Text="Hotel Fare" CssClass="text-light"></asp:Label>
            <asp:TextBox ID="TextBoxhotelfare" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="Label4" runat="server" Text="Total" CssClass="text-light"></asp:Label>
            <asp:TextBox ID="TextBoxtotal" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
           <asp:Button ID="Buttonproceed" runat="server" OnClick="Buttonproceed_Click" Text="Proceed" CssClass="btn btn-primary"/>
        </div>
        
        <asp:Label ID="Labelbooking" runat="server" Text="Label" Visible="False"  CssClass="text-light"></asp:Label>


        <asp:HiddenField ID="HiddenFieldpid" runat="server" />
        <asp:HiddenField ID="HiddenFieldhotelid" runat="server" />
        <asp:HiddenField ID="HiddenFieldactid" runat="server" Value="-1" />
       
    </div>
    </div>
</asp:Content>
