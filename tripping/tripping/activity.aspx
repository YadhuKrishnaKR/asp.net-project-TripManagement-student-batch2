<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="activity.aspx.cs" Inherits="tripping.activity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
body {
      background-image: url('Image/singapore-thailand-malaysia-tour.jpg');
      background-repeat: no-repeat;
      background-size: cover;
    }
.customparagraph {
  margin-top: 150px; /* adjust as needed to make room for the navbar */
  
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="customparagraph ms-5">
       
        <asp:DataList ID="DataListactivity" runat="server" DataKeyField="ACTIVITY_ID" RepeatDirection="Horizontal"
    CssClass="d-flex flex-wrap gap-3">
    <ItemTemplate>
        <div class="card" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title"><%# Eval("ACTIVITY_NAME") %></h5>
                <p class="card-text"><strong>Amount:</strong> <%# Eval("AMOUNT") %></p>
                <asp:CheckBox ID="CheckBoxactivityselect" runat="server" OnCheckedChanged="CheckBoxactivityselect_CheckedChanged" CssClass="form-check-input" />
                <asp:HiddenField ID="HiddenFieldactivityid" runat="server" Value='<%# Eval("AMOUNT") %>' />
                <asp:HiddenField ID="HiddenFieldactid" runat="server" Value='<%# Eval("ACTIVITY_ID") %>' />
            </div>
        </div>
    </ItemTemplate>
</asp:DataList>
        <br />
        <br />
 <asp:DataList ID="DataListhotel" runat="server" DataKeyField="HOTEL_ID" RepeatDirection="Horizontal" CssClass="d-flex flex-wrap gap-3">
    <ItemTemplate>
            <div class="card style="width: 18rem;">
                <img src='<%# Eval("HOTEL_IMAGE") %>' class="card-img-top" alt='<%# Eval("HOTEL_NAME") %>' />
                <div class="card-body">
                    <asp:Label ID="Labelhotelid" runat="server" Text='<%# Eval("HOTEL_ID") %>'></asp:Label>
                    <h5 class="card-title"><%# Eval("HOTEL_NAME") %></h5>
                    <p class="card-text"><%# Eval("DESCRIPTION") %></p>
                    <p class="card-text"><strong>$<%# Eval("PRICE") %></strong> per night</p>
                    <asp:CheckBox ID="CheckBoxhotel" runat="server" OnCheckedChanged="CheckBoxhotel_CheckedChanged" CssClass="form-check-input" />
                    <asp:HiddenField ID="HiddenFieldhtl" runat="server" Value='<%# Eval("PRICE") %>' />
                </div>
            </div>
        </div>
    </ItemTemplate>
</asp:DataList>

        <br />
        <asp:Label ID="Labelid" runat="server" Text="Label" Visible="False"></asp:Label>
        <asp:Button ID="Buttonpayment" runat="server" OnClick="Buttonpayment_Click" Text="PAYMENT" CssClass="btn btn-primary"/>
        <asp:HiddenField ID="HiddenFieldactivityfare" runat="server" />
        <asp:HiddenField ID="HiddenFieldhotelfare" runat="server" />
        <asp:HiddenField ID="HiddenField2" runat="server" />
        <asp:HiddenField ID="HiddenFieldpackagefare" runat="server" />
        <asp:HiddenField ID="HiddenField3" runat="server" />
        <asp:HiddenField ID="HiddenFieldgetactid" runat="server" />
        <asp:HiddenField ID="HiddenField1" runat="server" />

    </div>
</asp:Content>
