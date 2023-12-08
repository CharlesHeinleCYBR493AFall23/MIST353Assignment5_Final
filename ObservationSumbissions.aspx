<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ObservationSumbissions.aspx.cs" Inherits="CharlesHeinle_Assignment4.ObservationSumbissions" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Observation Submission</h1>
    <asp:Panel ID="Observations" runat="server" Visible="false">
        <label for="Date">Observed date:</label>
        <asp:TextBox ID="Date" runat="Server" CssClass="Form-Control" TextMode="Date"></asp:TextBox>
        <br />
        <label for="Notes">Notes:</label>
        <asp:TextBox ID="Notes" runat="server" Text="Create Observation" OnClick="Create_Click" CssClass="btn btn-primary" />
    </asp:Panel>
</asp:Content>
