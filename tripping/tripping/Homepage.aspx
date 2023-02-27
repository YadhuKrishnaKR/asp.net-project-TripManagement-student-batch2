<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="tripping.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div style="background-color: #999966" >

       <br />
       <br />
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Label ID="Label1" runat="server" Text="YOUR DREAM VACATION AWAITS" Font-Bold="True" Font-Size="25px" ForeColor="#99FF33" Height="34px" style="margin-left: 0px" Width="462px"></asp:Label>
       <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
       <asp:Label ID="Label2" runat="server" Text="PACKAGES" Font-Bold="True" Font-Size="25px" ForeColor="#99FF33"></asp:Label>
       <br />
<asp:HiddenField ID="HiddenFieldpacklist" runat="server" />
       <asp:HiddenField ID="HiddenFieldpackageid" runat="server" />
       <br />
       &nbsp;<br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
       <asp:DropDownList ID="DropDownListlocations" runat="server" Height="38px" Width="136px" BackColor="#666633" Font-Bold="True" ForeColor="White"  >
       </asp:DropDownList>
       &nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="Buttonpackage" runat="server" OnClick="Buttonpackage_Click" Text="Button" BackColor="#666633" Font-Bold="True" ForeColor="White" />
       <asp:DataList ID="DataListlistpack" runat="server" RepeatDirection="Horizontal" Width="483px" DataKeyField="PACKAGE_ID" Height="337px">
           <ItemTemplate>
            
               <br />
               <br />
               <br />
           
               <div id="buttonviemore" style="border-style: inset; width: 165px; height: 460px; background-image: none; background-repeat: no-repeat; background-color: #999966;">
                   <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl='<%# Eval("Image") %>' Width="133px" />
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                   <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Yellow" Text='<%# Eval("PACKAGE_ID") %>'></asp:Label>
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Yellow" Text='<%# Eval("PACKAGE_NAME") %>'></asp:Label>
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Yellow" Text='<%# Eval("LOCATIONID") %>'></asp:Label>
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Yellow" Text='<%# Eval("CORDINATORID") %>'></asp:Label>
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Yellow" Text='<%# Eval("CORDINATORID") %>'></asp:Label>
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="Buttonviewmore" runat="server" BackColor="#999999" Font-Bold="True" ForeColor="Yellow" OnClick="Buttonviewmore_Click" Text="VIEWMORE" Width="86px" />
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:HiddenField ID="HiddenField1" runat="server" Value='<%# Eval("PACKAGE_ID") %>' />
               </div>
               <br />
               <br />
               <br />
               <br />
               <br />
               <br />
            
           </ItemTemplate>
       </asp:DataList>
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

   </div>
   
</asp:Content>
