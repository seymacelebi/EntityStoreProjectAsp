using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje.LinqKartlar
{ 
    
    public partial class Istatistikler : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLURUN.Count().ToString();
            Label2.Text = db.TBLMUSTERI.Count().ToString();
            Label3.Text = db.TBLSATIS.Sum(x => x.FIYAT).ToString();
            Label4.Text = db.TBLKATEGORI.Count().ToString();
            Label5.Text = db.TBLURUN.Count(x => x.DURUM == true).ToString();
            Label6.Text = db.TBLURUN.Count(x => x.DURUM == false).ToString();
            Label7.Text = (from x in db.TBLURUN orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();

            Label8.Text = (from x in db.TBLURUN
                           join y in db.TBLKATEGORI 
                           on x.TBLKATEGORI.KATEGORIID equals y.KATEGORIID
                           group x by y into g orderby g.Count() descending select g.Key.KATEGORIAD).FirstOrDefault(); 
        }
    }
}