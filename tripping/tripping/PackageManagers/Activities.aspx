<%@ Page Title="" Language="C#" MasterPageFile="~/Tripping Master.Master" AutoEventWireup="true" CodeBehind="Activities.aspx.cs" Inherits="tripping.PackageManagers.Activities" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="cordinator.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous"/>   
    <style>
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="back_image">
           <asp:HiddenField ID="hdfield" runat="server" Value="-1" />
            <div class="row w-100">
                <div class="col-lg-9">
                     <br />
                     <br />
                 <div class=" m-5">
                   <div class="table-responsive">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ACTIVITY_ID" CssClass="table table-striped bg-primary">
                            <Columns>
                                <asp:BoundField DataField="ACTIVITY_ID" HeaderText="ID" Visible="False"/>
                                <asp:BoundField DataField="ACTIVITY_NAME" HeaderText="Activity Name" />
                                <asp:BoundField DataField="AMOUNT" HeaderText="Price" />
                                <asp:BoundField DataField="PACKAGEID" HeaderText="Package Name"/>
                                <asp:TemplateField HeaderText="Edit">
                                    <ItemTemplate>
                                        <asp:Button ID="btnedit" runat="server" Text="Edit" CssClass="btn btn-success" OnClick="btnedit_Click"/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Delete">
                                    <ItemTemplate>
                                        <asp:Button ID="btndelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btndelete_Click"/>
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
                    <asp:Label ID="lblactivityhead" runat="server" CssClass="px-5 py-2 mt-5 mb-5 text-light bg-primary rounded">Add Activity</asp:Label>
                    <br />
                    <br />
                    <br />
                   <asp:TextBox ID="txtactivityname" runat="server" placeholder="Activity Name" CssClass="form-control"></asp:TextBox> 
                    <br />
                    <asp:TextBox ID="txtamount" runat="server" placeholder="Price" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="txtpackageid" runat="server" placeholder="Package Id" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                    <br /> 
                    <asp:Button ID="btnsubmit" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="btnsubmit_Click"></asp:Button><asp:Button ID="btnback" runat="server" Text="Back to Add Package" CssClass="btn btn-secondary ms-1" OnClick="btnback_Click"></asp:Button>
                    <br />
                    <br />
                    <asp:Label ID="lblmsg" runat="server" Visible="False" CssClass="bg-danger text-light px-5 py-2 rounded"></asp:Label>
                    </div>
                    </div>
                </div>
            </div>
         </div>


     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
</asp:Content>
