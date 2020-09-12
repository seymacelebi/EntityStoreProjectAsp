<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="EntityAspProje.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün Adını Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:TextBox ID="TxtMarka" runat="server" placeholder="Ürün Markayı Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" ></asp:DropDownList> 
        </div>
        <br />

        
        <div>
            <asp:TextBox ID="TxtUrunFiyat" runat="server" placeholder="Ürün Fiyatını Girin..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        
        <div>
            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok Sayısı ..." CssClass="form-control"></asp:TextBox>
        </div>
        <br />

        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click"/>
        </div>
    </form>


</asp:Content>
