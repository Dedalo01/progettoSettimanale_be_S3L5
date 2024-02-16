<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="ShoppingCartPage.aspx.cs" Inherits="progettoSettimanaleS3L5.ShoppingCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
    <h1 class="ms-5">Carrello</h1>

    <div id="isEmpty" class="px-5" runat="server">
        <h2>Il Carrello è vuoto</h2>
    </div>
    
    <asp:Repeater ID="CartRepeater" runat="server" OnItemCommand="CartRepeaterCommand">
        <ItemTemplate>
            <div class="row px-5">
                <div class="col-8 d-flex align-items-center justify-content-start">
                    <h2><%# Eval("Name") %></h2>
                </div>

                <div class="col-2 d-flex align-items-center justify-content-center">
                    <p>Prezzo: <%# Eval("Price") %>€</p>
                </div>

                <div class="col-2 d-flex align-items-center justify-content-center">
                    <asp:Button runat="server" Text="Remove" CommandName="RemoveFromCart" CommandArgument='<%# Eval("ProductId") %>' class="btn btn-warning"/>
                </div>
            </div>

            </div>
        </ItemTemplate>
    </asp:Repeater>

    <asp:Button ID="EmptyCartBtn" runat="server" Text="Svuota il Carrello" OnClick="EmptyCartBtn_Click" CssClass="btn btn-danger m-5"/>
     
     


</asp:Content>
