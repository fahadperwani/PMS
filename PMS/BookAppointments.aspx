<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookAppointments.aspx.cs" Inherits="PMS.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                    <div class="form-group">
                        <asp:Label ID="lblDoctorName" runat="server" Text="" CssClass="control-label"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblAvailableTimes" runat="server" Text="Available Times:" CssClass="control-label"></asp:Label>
                        <asp:DropDownList ID="ddlAvailableTimes" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Select a time" Value=""></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnBookAppointment" runat="server" Text="Book Appointment" CssClass="btn btn-primary" OnClick="btnBookAppointment_Click" />
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
