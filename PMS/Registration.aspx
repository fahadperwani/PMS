<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PMS.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-default">
                    <div class="panel-heading">Register</div>
                    <div class="panel-body">
                        <asp:Label ID="lblName" runat="server" Text="Name" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblEmail" runat="server" Text="Email" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblUserType" runat="server" Text="User Type" CssClass="control-label"></asp:Label>
                        <asp:DropDownList ID="UserType" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Patient">Patient</asp:ListItem>
                            <asp:ListItem Value="Doctor">Doctor</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="lblSpecialization" runat="server" Text="Specialization (If Doctor)" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtSpecialization" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="BtnRegister_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>

