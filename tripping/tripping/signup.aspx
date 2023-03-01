<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="tripping.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="LogIn.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous"/> 
    <title></title>
     <style>
    body {
      background-image: url('Image/sign%20up%20image.jpg');
      background-repeat: no-repeat;
      background-size: cover;
    }
  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="border border-white-50 bg-light signupdiv mt-5 text-muted me-5">
            <div>
                             <div>
                                    <h1 id="Labelsignup" class="">SIGNUP</h1>
                             </div>
                               <div>
                                    <asp:Label ID="Labelname" runat="server" Text="NAME"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="TextBoxname" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxname" ErrorMessage="***"></asp:RequiredFieldValidator>
                               </div>
                               <div>
                                    <asp:Label ID="Label2" runat="server" Text="EMAIL"></asp:Label>
                                    <br />
                                    <asp:TextBox ID="TextBoxemail" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxemail" ErrorMessage="***"></asp:RequiredFieldValidator>
                               </div>
                                <div>
                                    <asp:Label ID="Labelcontactno" runat="server" Text="CONTACT"></asp:Label>
                                     <br />
                                    <asp:TextBox ID="TextBoxcontactno" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBoxcontactno" ErrorMessage="***"></asp:RequiredFieldValidator>
                                </div>
                                <div>
                                    <asp:Label ID="Labelpassword" runat="server" Text="PASSWORD"></asp:Label>
                                     <br />
                                    <asp:TextBox ID="TextBoxpassword" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxpassword" ErrorMessage="***"></asp:RequiredFieldValidator>
                                </div>
                                <div>
                                    <asp:Label ID="Labelconfirmpassword" runat="server" Text="CONFIRM PASSWORD"></asp:Label>
                                     <br />
                                    <asp:TextBox ID="TextBoxconfirmpassword" runat="server" CssClass="form-control"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxpassword" ErrorMessage="****"></asp:RequiredFieldValidator>
                                </div>
                                <div class="d-flex justify-content-center">
                                    <asp:Button ID="Buttonsignup" runat="server" OnClick="Buttonsignup_Click" Text="signup" CssClass="btn btn-success"/>
                                </div>
                        <br />
                                     <asp:Label ID="Labelrole" runat="server" Text="role" Visible="false"></asp:Label>
                                     <asp:Label ID="Labelmsg" runat="server" Text="Labelmsg" Visible="false"></asp:Label>
            </div>
        </div>
    </form>
     <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
</body>
</html>
