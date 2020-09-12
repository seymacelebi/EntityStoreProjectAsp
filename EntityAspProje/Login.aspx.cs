using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje;

namespace EntityAspProje
{
    public partial class Login : System.Web.UI.Page
    {
        BONUSASPDBEntities db = new BONUSASPDBEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMİN where x.KULLANICI == TxtKullaniciAd.Text && x.SIFRE == TxtSifre.Text select x;
            if (sorgu.Any())
                //sorgu içinde bir şey varsa
            {
                Response.Redirect("Kategoriler.Aspx");
            }
            else
            {
                Response.Write("Hatalı Bilgi Girişi");
            }
        }
    }
}