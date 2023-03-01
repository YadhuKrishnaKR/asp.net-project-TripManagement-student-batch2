<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="tripping.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="LogIn.css" rel="stylesheet" />
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous"/> 
</head>
<body class="vh-100">
    <form id= "form1" runat="server">
      <div class="row w-100 logindiv">
        <div class="col-lg-12 headsection">
            <div class="border border-secondary bg-secondary mt-5 text-light">
               <div class="mt-3">
                    <h1 id="Labelloginhead" class="text-center">Login</h1>
               </div>
                    <br />
                <div class="d-flex">
                     <asp:Label ID="Labelusername" runat="server" Text="USERNAME" CssClass="me-4 ms-3"></asp:Label>
                     <asp:TextBox ID="TextBoxusername" runat="server" placeholder="Enter the User name" CssClass="form-control me-3"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxusername" ErrorMessage="***" ValidationGroup="b"></asp:RequiredFieldValidator>
                </div>
                    <br />
                <div  class="d-flex">
                    <asp:Label ID="Labelpassword" runat="server" Text="PASSWORD" CssClass="me-4 ms-3"></asp:Label>
                    <asp:TextBox ID="TextBoxpassword" runat="server" placeholder="Enter the Password" CssClass="form-control me-3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxpassword" ErrorMessage="***" ValidationGroup="b"></asp:RequiredFieldValidator>
                </div>
                     <br />
                <div class="d-flex justify-content-center">
                     <asp:Button ID="Buttonlogin" runat="server" Text="Login" OnClick="Buttonlogin_Click" ValidationGroup="b" CssClass="btn btn-primary"/>
                </div>
                 <div class="d-flex align-items-center">
                     <asp:Label ID="lblparagraph" runat="server" CssClass="me-1">If you haven't an account please</asp:Label>
                    <asp:Button ID="Buttonsignup" runat="server" OnClick="Buttonsignup_Click" Text="signup" CssClass="btn btn-secondary text-info"/>
                </div>
                <asp:Label ID="Label" runat="server" Text="Label" Visible="false"></asp:Label>
           </div>
        </div>
      </div> 

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
</body>
</html>
