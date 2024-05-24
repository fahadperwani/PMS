<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Appointments.aspx.cs" Inherits="PMS.Appointments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Appointments</h1>
    <asp:GridView ID="AppointmentsGridView" runat="server">
        <Columns>
            <asp:BoundField DataField="DoctorName" HeaderText="Doctor Name"  />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:TemplateField HeaderText="Cancel">
                <ItemTemplate>
                    <asp:Button ID="CancelAppointmentButton" runat="server" Text="Cancel" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
