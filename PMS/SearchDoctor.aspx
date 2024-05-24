<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchDoctor.aspx.cs" Inherits="PMS.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 col-md-offset-3">
                    <div class="form-group">
                        <asp:TextBox ID="txtSearch" runat="server" placeholder="Search for a doctor" CssClass="form-control" />
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnSearch" runat="server" Text="Submit" OnClick="btnSearch_Click" CssClass="btn btn-primary" />
                    </div>
                    <div class="form-group">
                        <asp:GridView ID="gvDoctors" runat="server" AutoGenerateColumns="False" CssClass="table table-striped">
                            <Columns>
                                <asp:BoundField DataField="Name" HeaderText="Name" />
                                <asp:BoundField DataField="Specialization" HeaderText="Specialization" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btnBookAppointment" runat="server" Text="Book Appointment" CssClass="btn btn-success" OnClick="btnBookAppointment_Click" CommandArgument='<%# Eval("Id") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
