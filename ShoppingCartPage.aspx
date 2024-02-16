<%@ Page Title="Shopping Cart" Language="C#" MasterPageFile="~/Templates/BaseTemplate.Master" AutoEventWireup="true" CodeBehind="ShoppingCartPage.aspx.cs" Inherits="progettoSettimanaleS3L5.ShoppingCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <h1>Carrello</h1>

    <div id="isEmpty" runat="server">
        <h2>Il Carrello è vuoto</h2>
    </div>
    
    <asp:Repeater ID="CartRepeater" runat="server" OnItemCommand="CartRepeaterCommand">
        <ItemTemplate>
            <div class="row">
                <div class="col d-flex align-items-end justify-content-center">
                    <h2><%# Eval("Name") %></h2>
                </div>

                <div class="col">
                    <p>Price: $<%# Eval("Price") %></p>
                </div>

                <div class="col">
                    <asp:Button runat="server" Text="Remove" CommandName="RemoveFromCart" CommandArgument='<%# Eval("ProductId") %>' class="btn btn-warning"/>
                </div>
            </div>

            </div>
        </ItemTemplate>
    </asp:Repeater>
     



</asp:Content>
