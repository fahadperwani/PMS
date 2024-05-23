<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PMS.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                <div class="panel panel-default">
                    <div class="panel-heading">Login</div>
                    <div class="panel-body">
                        <asp:Label ID="lblEmail" runat="server" Text="Email" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblPassword" runat="server" Text="Password" CssClass="control-label"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:Label ID="lblUserType" runat="server" Text="User Type" CssClass="control-label"></asp:Label>
                        <asp:DropDownList ID="ddlUserType" runat="server" CssClass="form-control">
                            <asp:ListItem Value="Patient">Patient</asp:ListItem>
                            <asp:ListItem Value="Doctor">Doctor</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblError" runat="server" Text="" CssClass="text-danger"></asp:Label>
                        <br />
                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
