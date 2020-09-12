using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje.Satıs
{
    public partial class Satıslar : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var satıslar = db.TBLSATIS.ToList();
            var satıslar = (from x in db.TBLSATIS
                           select new
                           {
                               x.SATISID,
                               x.TBLURUN.URUNAD,
                               x.TBLPERSONEL.PERSONELADSOYAD,
                             MUSTERI =  x.TBLMUSTERI.MUSTERIAD + " " + x.TBLMUSTERI.MUSTERISOYAD,
                               x.FIYAT

                           }).ToList();
            Repeater1.DataSource = satıslar;
            Repeater1.DataBind();

        }
    }
}