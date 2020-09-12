using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BONUSASPDBEntities db = new BONUSASPDBEntities();
            TBLKATEGORI t = new TBLKATEGORI();
            t.KATEGORIAD = TextBox1.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            Response.Redirect("Kategoriler.Aspx");
        }
    }
}