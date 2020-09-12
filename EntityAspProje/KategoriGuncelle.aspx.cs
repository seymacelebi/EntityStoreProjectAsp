using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje
{
    public partial class KategoriGuncelle : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false) { 
            //güncelleme yapabilmek için önce verileri getirmemiz lazım
            //bu iki satır ile numaralarını güncelle sayfasına çektik.
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            TxtId.Text = id.ToString();
            var ktgr = db.TBLKATEGORI.Find(id);
            TxtAd.Text = ktgr.KATEGORIAD;
        }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.TBLKATEGORI.Find(id);
            ktgr.KATEGORIAD = TxtAd.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}