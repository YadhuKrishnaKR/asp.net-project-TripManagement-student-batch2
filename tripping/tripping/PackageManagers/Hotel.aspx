<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="Hotel.aspx.cs" Inherits="tripping.PackageManagers.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="cordinator.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous"/>
<style>
    .totaldiv {
        background-image: url('/Image/Night-shot-poolside.jpg');
        background-repeat: no-repeat;
        background-size: cover;
        width: 100%;
        height:100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" CssClass="vh-100">
     <div class="totaldiv vh-100">
           <asp:HiddenField ID="hdfield" runat="server" Value="-1" />
            <div class="row w-100">
                 <div class="col-lg-3">
                    <div class="border border-dark bg-dark mt-5 ms-5 rounded">
                     <div class="mx-5" id="add-package-div">
                    <%-- hotel section--%>
                    <br />
                    <br />
                     <asp:Label ID="lblhotel" runat="server" CssClass="px-5 py-2 mt-5 text-light bg-primary rounded">Add Hotel</asp:Label>
                    <br />
                    <br /> 
                    <asp:TextBox ID="txthotelname" runat="server" placeholder="Hotel Name" CssClass="form-control"></asp:TextBox>
                   <br /> 
                    <asp:TextBox ID="txtdiscription" runat="server" placeholder="Discription" CssClass="form-control"></asp:TextBox>
                   <br /> 
                    <asp:DropDownList ID="ddllocationhotel" runat="server" CssClass="form-control" Enabled="false"></asp:DropDownList>
                    <br /> 
                    <asp:TextBox ID="txtpackage" runat="server" placeholder="Package Id" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    <br /> 
                    <asp:FileUpload ID="fuhotelimage" runat="server" placeholder="Image" CssClass="form-control"/>
                          
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                          
                         <asp:ImageMap ID="ImageMap1" runat="server" Height="97px" Width="103px" Visible="False"></asp:ImageMap>
                   <br /> 
                    <asp:TextBox ID="txthotelprice" runat="server" placeholder="Price" CssClass="form-control"></asp:TextBox>
                   <br /> 
                    <%-- <asp:Button ID="btnback" runat="server" Text="Back" CssClass="btn btn-primary"></asp:Button>
                    <asp:Button ID="btnnext" runat="server" Text="Next" CssClass="btn btn-primary"></asp:Button>--%>
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnsubmit_Click"></asp:Button>
                      <br />
                      <br />
                     <asp:Button ID="btnback" runat="server" Text="Back to Add Package" CssClass="btn btn-secondary ms-1" OnClick="btnback_Click"></asp:Button>
                    <br />
                    <br />
                    <asp:Label ID="lblmsg" runat="server" Visible="False" CssClass="text-light"></asp:Label>
                    </div>
                    </div>
                </div>
                <div class="col-lg-9">
                     <%--<br />
                     <br />
                    ;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnaddpackage" runat="server" Text="Add Package" CssClass="btn btn-primary" OnClick="btnaddpackage_Click"></asp:Button>
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />
                     <br />--%>
                 <div class="m-5">
                   <div class="table-responsive">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="HOTEL_ID" CssClass="table table-striped bg-primary">
                            <Columns>
                                <asp:BoundField DataField="HOTEL_ID" HeaderText="ID" Visible="False"/>
                                <asp:BoundField DataField="HOTEL_NAME" HeaderText="Hotel Name" />
                                <asp:BoundField DataField="DESCRIPTION" HeaderText="Description" />
                                <asp:BoundField DataField="LOCATION" HeaderText="Location" />
                                <asp:BoundField DataField="PACKAGE" HeaderText="Package" />
                                <asp:ImageField DataImageUrlField="HOTEL_IMAGE" HeaderText="Image"  ControlStyle-Width="50"  ControlStyle-Height="50" >
<ControlStyle Height="50px" Width="50px"></ControlStyle>
                                </asp:ImageField>
                                <asp:BoundField DataField="PRIZE" HeaderText="Amount" />
                                <asp:TemplateField HeaderText="Edit">
                                    <ItemTemplate>
                                        <asp:Button ID="btnedithotel" runat="server" Text="Edit" CssClass="btn btn-success" OnClick="btnedithotel_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Delete">
                                    <ItemTemplate>
                                        <asp:Button ID="btndeletehotel" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btndeletehotel_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                  </div>

                </div>
               
            </div>
         </div>

<%--        <script>
  //$(document).ready(function() {
  //  // Show the "add package" div and hide the button when clicked
  //    $('#btnaddpackage').click(function() {
  //    $('#add-package-div').removeClass('d-none');
  //    $(this).addClass('d-none');
  //  });

  //  // Show the button and hide the "add package" div when the form is submitted
  //    $('#btnsubmit').click(function() {
  //    $('#add-package-div').addClass('d-none');
  //        $('#btnaddpackage').removeClass('d-none');
  //  });
  //});
<%--        </script>--%>

      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>

</asp:Content>
