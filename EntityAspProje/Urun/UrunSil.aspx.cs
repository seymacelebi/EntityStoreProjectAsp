using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var urun  = db.TBLURUN.Find(id);
            urun.DURUM = false;
            db.SaveChanges();
            Response.Redirect("YeniUrun.Aspx");
        }
    }
}