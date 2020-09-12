<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="EntityAspProje.Urunler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered">
        <tr>
            <th>ÜRÜN ID</th>
            <th>ÜRÜN ADI</th>
            <th>MARKA</th>
            <th>KATEGORİ</th>
            <th>FİYAT</th>
            <th>STOK</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("URUNID") %></td>
                    <td><%#Eval("URUNAD") %></td>
                    <td><%#Eval("URUNMARKA") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td><%#Eval("URUNFIYAT") %></td>
                    <td><%#Eval("URUNSTOK") %></td>
                 <%--   <td><%#Eval("SIL") %></td>
                    <td><%#Eval("GUNCELLE") %></td>--%>
                <td>
                        <asp:HyperLink NavigateUrl='<%#"~/Urun/UrunSil.Aspx?URUNID="+ Eval("URUNID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td>
                        <asp:HyperLink NavigateUrl='<%#"~/Urun/UrunGuncelle.Aspx?URUNID="+ Eval("URUNID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-success">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    <a href="YeniUrun.aspx" class="btn btn-info">Yeni Ürün Ekle</a>

</asp:Content>
