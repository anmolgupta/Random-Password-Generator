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
using System.Data.SqlClient;

public partial class update : System.Web.UI.Page
{
    int length;
    char[] pass;
    private static string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|Database.mdf;Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void randalpha(int l)
    {
        int temp;
        Random r = new Random();
        for (int i = 0; i < l; i++)
        {
            do
            {
                temp = (r.Next() % 91);
            } while (temp < 65);
            pass[i] = (char)temp;



        }

    }
    public void randnum(int l)
    {
        int temp;
        Random r = new Random();
        for (int i = l; i < length; i++)
        {
            do
            {
                temp = (r.Next() % 58);
            } while (temp < 48);
            pass[i] = (char)temp;



        }


    }
    public int binddata()
    {
        int n = 0;
        String str,name;
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm = new SqlCommand();
        comm.Connection = conn;
        conn.Open();
        comm.CommandText = "select name, password from Table1";
        SqlDataReader dr = comm.ExecuteReader();
        if (dr.HasRows == true)
        {
            while (dr.Read())
            {
                name = "" + dr["name"];
                str=""+dr["password"];
                if (name == TextBox1.Text.Trim())
                {
                    conn.Close();
                    TextBox2.Text=str;
                    n = -1;
                    return n;
                }
                
            }

        }
        conn.Close();
        return n;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int n = binddata();
        if (n < 0)
        {
            Random r = new Random();
            length = Convert.ToInt32(TextBox3.Text);
            int choice = DropDownList2.SelectedIndex;
            int brk;
            pass = new char[length];


            if (choice == 0)
            {
                brk = length;
                randalpha(brk);
            }

            if (choice == 2)
            {
                do
                {
                    brk = r.Next() % (length - 1);
                } while (brk == 0);
                randalpha(brk);
                randnum(brk);

            }
            if (choice == 1)
            {
                brk = 0;
                randnum(brk);
            }
            String s = "";
            for (int i = 0; i < pass.Length; i++)
            {
                s = s + pass[i];
            }
            TextBox4.Text = s;
            Label1.Text = "";



        }
        else
        {
            Label1.Text = "This name doesn't exist!!! Enter a valid name !!!";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm = new SqlCommand();
        comm.Connection = conn;
        int n = binddata();
        if (n < 0)
        {
            conn.Open();
            comm.CommandText = "update table1 set password='" + TextBox4.Text + "', date='" + DateTime.Now + "' where name= '" + TextBox1.Text + "' ;";
            int r = 0;
            r = comm.ExecuteNonQuery();
            conn.Close();
            Label2.Text = "Updated Successfully !!!";
            Label1.Text = "";
        }
        else
            Label1.Text = "This name doesn't exist!!! Enter a valid name !!!";

    }
}