using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;
namespace EntityAspProje
{
    public partial class Urunler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunler = db.TBLURUN.Where(x=>x.DURUM==true).ToList();
            var urunler = (from x in db.TBLURUN
                          where x.DURUM == true
                           select new
                           {
                               x.URUNID,
                               x.URUNAD,
                               x.URUNMARKA,
                               x.TBLKATEGORI.KATEGORIAD,
                               x.URUNFIYAT,
                               x.URUNSTOK
                           }).ToList();
            Repeater1.DataSource = urunler;
            Repeater1.DataBind();

        }
    }
}