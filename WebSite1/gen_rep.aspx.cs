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

public partial class gen_rep : System.Web.UI.Page
{
    int length;
    char[] pass;
    char[] vowel={'A','E','I','O','U'};
    private static string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|Database.mdf;Integrated Security=True;User Instance=True";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void randalpha(int l)
    {
        int temp,t;
        Random r = new Random();
        for (int i = 0; i < l; i++)
        {
            if (i == 1 || i == 4 || i == 7 || i == 11 || i == 13)
            {
                t=r.Next() % 6;
                pass[i] = vowel[t];
            }
            else
            {
                do
                {
                    temp = (r.Next() % 91);
                } while (temp <= 65||temp==69||temp==73||temp==79||temp==85);
                pass[i] = (char)temp;
            }


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


    protected void Button1_Click(object sender, EventArgs e)
    {
        Random r = new Random();
        length = Convert.ToInt32(TextBox2.Text);
        int choice = DropDownList1.SelectedIndex;
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
        TextBox3.Text = s;
    }

    public int binddata()
    {
        int n = 0;
        String name;
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm = new SqlCommand();
        comm.Connection = conn;
        conn.Open();
        comm.CommandText = "select name from Table1";
        SqlDataReader dr = comm.ExecuteReader();
        if (dr.HasRows == true)
        {
            while (dr.Read())
            {
                name = "" + dr["name"];
                if (name == TextBox1.Text.Trim())
                {
                    conn.Close();
                    n = -1;
                    return n;
                }
            
            }
            
        }
        conn.Close();
        return n;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int n = binddata();
        if (n < 0)
            Label2.Text = "Login id exists...select a different one!!!";
        else
            Label2.Text = "Login id available";
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {

    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(constr);
        SqlCommand comm = new SqlCommand();
        comm.Connection = conn;
        int n = binddata();
        if(n>=0)
        {
        conn.Open();
        comm.CommandText = "insert into table1 (name,date,password) values ('" + TextBox1.Text + "','" + DateTime.Now + "','" + TextBox3.Text + "');";
        int r = 0;
        r = comm.ExecuteNonQuery();
        conn.Close();
        Label1.Text = "Updated Successfully !!!";
        Label2.Text = "";
        }
        else
            Label2.Text="Login id exists...select a different one!!!";
    }
}
