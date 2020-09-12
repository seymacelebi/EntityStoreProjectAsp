using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                var kate = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList2.DataTextField = "KATEGORIAD";
                DropDownList2.DataValueField = "KATEGORIID";
                DropDownList2.DataSource = kate;
                DropDownList2.DataBind();

                //güncelleme yapabilmek için önce verileri getirmemiz lazım
                //bu iki satır ile numaralarını güncelle sayfasına çektik.
                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var P= db.TBLURUN.Find(id);
                TxtUrunAd.Text = P.URUNAD;
                TxtStok.Text = P.URUNSTOK.ToString();
                TxtMarka.Text = P.URUNMARKA.ToString();
                TxtUrunFiyat.Text = P.URUNFIYAT.ToString();
                DropDownList2.SelectedValue = P.URUNKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var P = db.TBLURUN.Find(id);
            P.URUNAD = TxtUrunAd.Text;
            P.URUNSTOK =short.Parse( TxtStok.Text);
            P.URUNMARKA = TxtMarka.Text;
            P.URUNFIYAT = decimal.Parse(TxtUrunFiyat.Text);
            P.URUNKATEGORI = byte.Parse(DropDownList2.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");
        }
    }
}