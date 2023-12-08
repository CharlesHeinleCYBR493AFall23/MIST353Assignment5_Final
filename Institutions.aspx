<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Institutions.aspx.cs" Inherits="CharlesHeinle_Assignment4.Institutions" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Repeater ID="Institution" runat="server">
            <ItemTemplate>
                <a href="ResearchAreas.aspx?InstituitonID=<%# Eval("InstitutionID") %>">
                    <%# Eval("InstitutionName") %>
                </a>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </main>

</asp:Content>
