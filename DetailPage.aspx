<%@ Page Title="Detail Page" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="DetailPage.aspx.cs" Inherits="progettoSettimanaleS3L5.DetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container">
    <h1 runat="server" id="TitleProduct" class="my-3"></h1>
        <div class="row my-5">
            <div class="col">
                <img id="ImageProduct" runat="server" src="#" style="width: 70%;" class="ms-auto me-auto"/>
            </div>
            <div class="col d-flex flex-column align-items-start justify-content-center">
                <div>
                <p id="DescriptionProduct" runat="server"></p>
                <h3 id="PriceProduct" runat="server"></h3>
                </div>
                <div>
                <asp:Button ID="AddToCartBtn" runat="server" Text="Aggiungi al Carrello" OnClick="AddToCartBtn_Click" CssClass="btn btn-warning"/>
                </div>
            </div>

        </div>

    </div>

</asp:Content>
