<%@ Page Title="" Language="C#" MasterPageFile="~/ana.Master" AutoEventWireup="true" CodeBehind="musteri.aspx.cs" Inherits="adoproject.musteri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Müsteri Sayfası</h1>
    
    <form id="form1" runat="server">

    <div class="row">
        <div class="col-md-6">
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </div>
         

    </form>
</asp:Content>
