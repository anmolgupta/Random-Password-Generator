using System.Data.SqlClient;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Date1 : System.Web.UI.Page
{

    int yr = Convert.ToInt32(DateTime.Now.Year);
    int mon = Convert.ToInt32(DateTime.Now.Month);
    int dat = Convert.ToInt32(DateTime.Now.Day);

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Page.IsPostBack == false)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Select year");
            for (int i = 2001; i <= yr; i++)

                DropDownList1.Items.Add("" + i);

        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int syr = Convert.ToInt32(DropDownList1.SelectedItem.Text);
        DropDownList4.Items.Clear();
        DropDownList4.Items.Add("Select year");
        for (int i = syr; i <= yr; i++)
        {
            DropDownList4.Items.Add("" + i);
        }

        if (syr == yr)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Select month");
            for (int j = 1; j <= mon; j++)
            {
                DropDownList2.Items.Add("" + j);
            }
        }
        else
        {

            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Select month");
            for (int j = 1; j <= 12; j++)
            {
                DropDownList2.Items.Add("" + j);
            }


        }


    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int syr = Convert.ToInt32(DropDownList1.SelectedItem.Text);
        int smon = Convert.ToInt32(DropDownList2.SelectedItem.Text);
        if (syr == yr && smon == mon)
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("Select Date");
            for (int i = 1; i <= dat; i++)
                DropDownList3.Items.Add("" + i);

        }
        else
        {
            DropDownList3.Items.Clear();
            DropDownList3.Items.Add("Select date");
            if (DropDownList2.SelectedItem.Text == "2")
            {
                if (syr % 4 == 0)
                {
                    for (int i = 1; i <= 29; i++)
                        DropDownList3.Items.Add(i.ToString());
                }
                else
                {
                    for (int i = 1; i <= 28; i++)
                        DropDownList3.Items.Add(i.ToString());
                }
            }
            else if (DropDownList2.SelectedItem.Text == "1" || DropDownList2.SelectedItem.Text == "3" || DropDownList2.SelectedItem.Text == "5" || DropDownList2.SelectedItem.Text == "7" || DropDownList2.SelectedItem.Text == "8" || DropDownList2.SelectedItem.Text == "10" || DropDownList2.SelectedItem.Text == "12")
            {
                for (int i = 1; i <= 31; i++)
                    DropDownList3.Items.Add(i.ToString());
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                    DropDownList3.Items.Add(i.ToString());
            }
        }

    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {

        int syr = Convert.ToInt32(DropDownList4.SelectedItem.Text);
        if (syr == yr)
        {
            DropDownList5.Items.Clear();
            DropDownList5.Items.Add("Select month");
            for (int j = 1; j <= mon; j++)
            {
                DropDownList5.Items.Add("" + j);
            }
        }
        else
        {

            DropDownList5.Items.Clear();
            DropDownList5.Items.Add("Select month");
            for (int j = 1; j <= 12; j++)
            {
                DropDownList5.Items.Add("" + j);
            }


        }

    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        int syr = Convert.ToInt32(DropDownList4.SelectedItem.Text);
        int smon = Convert.ToInt32(DropDownList5.SelectedItem.Text);
        if (syr == yr && smon == mon)
        {
            DropDownList6.Items.Clear();
            DropDownList6.Items.Add("Select date");
            for (int i = 1; i <= dat; i++)
                DropDownList6.Items.Add("" + i);

        }
        else
        {
            DropDownList6.Items.Clear();
            DropDownList6.Items.Add("Select date");
            if (DropDownList5.SelectedItem.Text == "2")
            {
                if (syr % 4 == 0)
                {
                    for (int i = 1; i <= 29; i++)
                        DropDownList6.Items.Add(i.ToString());
                }
                else
                {
                    for (int i = 1; i <= 28; i++)
                        DropDownList6.Items.Add(i.ToString());

                }
            }
            else if (DropDownList5.SelectedItem.Text == "1" || DropDownList5.SelectedItem.Text == "3" || DropDownList5.SelectedItem.Text == "5" || DropDownList5.SelectedItem.Text == "7" || DropDownList5.SelectedItem.Text == "8" || DropDownList5.SelectedItem.Text == "10" || DropDownList5.SelectedItem.Text == "12")
            {
                for (int i = 1; i <= 31; i++)
                    DropDownList6.Items.Add(i.ToString());
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                    DropDownList6.Items.Add(i.ToString());
            }
        }

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    private static string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|Database.mdf;Integrated Security=True;User Instance=True";
    protected void Button1_Click(object sender, EventArgs e)
    {


        GridView2.Visible = true;
        int d = Convert.ToInt32(DropDownList6.SelectedValue) + 1;
        String sdate = "" + DropDownList1.SelectedValue + "-" + DropDownList2.SelectedValue + "-" + DropDownList3.SelectedValue;
        String edate = "" + DropDownList4.SelectedValue + "-" + DropDownList5.SelectedValue + "-" + d;
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm = new SqlCommand();
        comm.Connection = conn;
        comm.CommandText = "select name,date,password from table1 where date >= '" + sdate + "' and date <='" + edate + "';";
        conn.Open();
        SqlDataReader dr = comm.ExecuteReader();

        if (dr.HasRows == true)
        {

            GridView2.DataSource = dr;
            GridView2.DataBind();

        }
        conn.Close();


    }


}
