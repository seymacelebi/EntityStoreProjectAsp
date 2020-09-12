using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje.Personel
{
    public partial class Personel : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            var degerler = db.TBLPERSONEL.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.PERSONELID =byte.Parse (TextBox1.Text);
            t.PERSONELADSOYAD = TextBox2.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
        }
    }
}