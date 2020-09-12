using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje
{
    public partial class YeniUrun : System.Web.UI.Page
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TxtUrunAd.Text;
            t.URUNSTOK = short.Parse(TxtStok.Text);
            t.URUNMARKA = TxtMarka.Text;
            t.URUNFIYAT = decimal.Parse(TxtUrunFiyat.Text);
            t.URUNKATEGORI = byte.Parse(DropDownList2.SelectedValue.ToString());
            TxtUrunFiyat.Text = DropDownList2.SelectedValue;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.Aspx");

        }
    }
}