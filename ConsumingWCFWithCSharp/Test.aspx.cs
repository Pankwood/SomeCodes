using System;

public partial class Test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       GridView1.DataSource = Client.MyList();

       GridView1.DataBind();
    }
}