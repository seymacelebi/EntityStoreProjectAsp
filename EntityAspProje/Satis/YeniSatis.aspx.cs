using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace EntityAspProje.Satıs
{
    public partial class YeniSatıs : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.TBLURUN select new { x.URUNID, x.URUNAD }).ToList();
                DropDownList2.DataTextField = "URUNAD";
                DropDownList2.DataValueField = "URUNID";
                DropDownList2.DataSource = urun;
                DropDownList2.DataBind();


                var mus = (from x in db.TBLMUSTERI
                           select new
                           {
                               x.MUSTERIID,
                               ADSOYAD = x.MUSTERIAD + " " + x.MUSTERISOYAD
                           }).ToList();
                DropDownList1.DataTextField = "ADSOYAD";
                DropDownList1.DataValueField = "MUSTERIID";
                DropDownList1.DataSource = mus;
                DropDownList1.DataBind();

                var per = (from x in db.TBLPERSONEL
                           select new
                           {
                               x.PERSONELID,
                               x.PERSONELADSOYAD
                           }).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = per;
                DropDownList3.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLSATIS t = new TBLSATIS();
            t.MUSTERI = int.Parse(DropDownList1.SelectedValue);
            t.URUN = byte.Parse(DropDownList2.SelectedValue);
            t.PERSONEL = byte.Parse(DropDownList3.SelectedValue);
            t.FIYAT = Decimal.Parse(TxtFiyat.Text);
            db.TBLSATIS.Add(t);
            db.SaveChanges();
            Response.Redirect("Satislar.Aspx");
        }
    }
}