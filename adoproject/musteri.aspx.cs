using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace adoproject
{
    public partial class musteri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            db.openConnection();
            doldur();
        }
        public void doldur()
        {
            string cumle = "Select * from musteri";
            db.cmd.CommandText = cumle;
            db.da=new SqlDataAdapter(db.cmd);
            db.dt = new DataTable();
            db.da.Fill(db.dt);
            GridView1.DataSource = db.dt;
            GridView1.DataBind();
        }
    }
}