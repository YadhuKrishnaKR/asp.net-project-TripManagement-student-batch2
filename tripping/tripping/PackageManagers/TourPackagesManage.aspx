<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="TourPackagesManage.aspx.cs" Inherits="tripping.PackageManagers.TourPackagesManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="cordinator.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous"/>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div>
           <asp:HiddenField ID="hdfield" runat="server" Value="-1" />
            <div class="row w-100">
                <div class="col-lg-9">
                     <br />
                     <br />
                 <div class=" m-5">
                   <div class="table-responsive">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PACKAGE_ID" CssClass="table table-striped bg-primary">
                            <Columns>
                                <asp:BoundField DataField="PACKAGE_ID" HeaderText="ID" Visible="False"/>
                                <asp:BoundField DataField="PACKAGE_NAME" HeaderText="Package Name" />
                                <asp:BoundField DataField="CORDINATORID" HeaderText="Coordinator" />
                                <asp:BoundField DataField="LOCATIONID" HeaderText="Location" />
                                <asp:ImageField DataImageUrlField="IMAGE" HeaderText="Image"  ControlStyle-Width="50"  ControlStyle-Height="50" >
<ControlStyle Height="50px" Width="50px"></ControlStyle>
                                </asp:ImageField>
                                <asp:BoundField DataField="BASICFARE" HeaderText="Basic Amount" />
                                 <asp:TemplateField HeaderText="Hotel">
                                    <ItemTemplate>
                                        <asp:Button ID="btnhotel" runat="server" Text="Hotel" CssClass="btn btn-warning text-light" OnClick="btnhotel_Click" ValidationGroup="a"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Activity">
                                    <ItemTemplate>
                                        <asp:Button ID="btnactivity" runat="server" Text="Activity" CssClass="btn btn-dark" OnClick="btnactivity_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Edit">
                                    <ItemTemplate>
                                        <asp:Button ID="btnedit" runat="server" Text="Edit" CssClass="btn btn-success" OnClick="btnedit_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Delete">
                                    <ItemTemplate>
                                        <asp:Button ID="btndelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btndelete_Click" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                  </div>

                </div>
                <div class="col-lg-3">
                    <div class="border border-dark bg-dark mt-5 rounded">
                     <div class="mx-5 mb-3" id="add-package-div">
                    <br />
                    <br />
                    <asp:Label ID="lblpackagehead" runat="server" CssClass="px-5 py-2 mb-2 text-light bg-primary rounded">Add Package</asp:Label>
                    <br />
                    <br />
                   <asp:TextBox ID="txttourname" runat="server" placeholder="Package Name" CssClass="form-control"></asp:TextBox> 
                    <br />
                    <asp:TextBox ID="txtmanager" runat="server" placeholder="Tour Manager" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:DropDownList ID="ddllocation" runat="server" CssClass="form-control"></asp:DropDownList>
                    <br />
                    <asp:FileUpload ID="fupackagephoto" runat="server" placeholder="Image" CssClass="form-control"/>
                    <asp:ImageMap ID="ImageMap1" runat="server" Height="97px" Width="103px" Visible="False"></asp:ImageMap>
                    <br />
                    <asp:TextBox ID="txtamount" runat="server" placeholder="Price" CssClass="form-control"></asp:TextBox>
                    <br /> 
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnsubmit_Click"></asp:Button>
                    <br />
                    <br />
                    <asp:Label ID="lblmsg" runat="server" Visible="False" CssClass="bg-danger text-light px-5 py-2 rounded"></asp:Label>
                    </div>
                    </div>
                </div>
            </div>
         </div>

        <script>
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
        </script>

      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
</asp:Content>
