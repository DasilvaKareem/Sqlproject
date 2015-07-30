using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.SessionState;
using System.Linq;
using System.Web.UI.WebControls;

namespace SqlPRoject
{

    public partial class Contact : Page
    {

        string Vendor = "nothing";
        string VendorID = "0";
        SqlConnection con = new SqlConnection("Server=USHDC4902;Database=Service_Delivery;Trusted_Connection=true");
        SqlDataReader dr;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            //GETS ALL THE DOMAINS FROM EA DOMAINS
            cmd = new SqlCommand("SELECT * from EA_Domains ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListItem dd = new ListItem();
                dd.Text = dr["DomainName"].ToString();
                dd.Value = dr["DomainID"].ToString();
               DropDownList5.Items.Add(dd);
            }
            con.Close();
            con.Open();
            //get all vendors
            SqlCommand command = new SqlCommand("SELECT * from EA_Vendor ", con);
           SqlDataReader drs = command.ExecuteReader();
            while (drs.Read())
            {
                ListItem dd = new ListItem();
                dd.Text = drs["VendorName"].ToString();
                dd.Value = drs["VendorID"].ToString();
                DropDownList1.Items.Add(dd);
            }

            con.Close();
            con.Open();
            //get all vendors
            SqlCommand command2 = new SqlCommand("SELECT * from EA_Service ", con);
            SqlDataReader drs2 = command2.ExecuteReader();
            while (drs2.Read())
            {
                ListItem dd = new ListItem();
                dd.Text = drs2["ServiceName"].ToString();
                dd.Value = drs2["ServiceID"].ToString();
                DropDownList2.Items.Add(dd);
            }
            con.Close();
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            //Values that are being enter into the database
         /*   cmd.Parameters.AddWithValue("@DomainMF", DomainName.Text);
            cmd.Parameters.AddWithValue("@DomainID", "example");
            cmd.Parameters.AddWithValue("@Category", Category.Text);
            cmd.Parameters.AddWithValue("@CapabilityID", Category.Text);
            cmd.Parameters.AddWithValue("@PractitionerFacing", "yes");
            cmd.Parameters.AddWithValue("@Service", DomainName.Text);
            //cmd.Parameters.AddWithValue("@VendorID", 33.0);
            cmd.Parameters.AddWithValue("@Technology", DomainName.Text);
            cmd.Parameters.AddWithValue("@ExternalCloud", DomainName.Text);
            cmd.Parameters.AddWithValue("@Owner", DomainName.Text);
            cmd.Parameters.AddWithValue("@Status", DomainName.Text);
            cmd.Parameters.AddWithValue("@GoLiveDate", DomainName.Text);
            cmd.Parameters.AddWithValue("@RetireDate", DomainName.Text);
            cmd.CommandText = "INSERT INTO EA_TechnologyUpdate ([DomainMF],[DomainID],[Category],[CapabiltyID], [PractitionerFacing],[Service],[VendorID], [Technology],[ExternalCloud], [Owner],[Status],[GoLiveDate], [RetireDate]) VALUES ('@DomainMF','@DomainID','ffffffffffffffff','rfrfrf', '@PractitionerFacing','@Service',3.0, '@Technology','@External cloud', '@Owner','@Status','@GoLiveDate', '@RetireDate')  ";
            cmd.ExecuteNonQuery();

            con.Close();*/

        }

        //When vendor is selected gets capbility info
        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
            System.Diagnostics.Debug.WriteLine("sddsdsds");
            con.Open();
            //get all vendors
            SqlCommand command2 = new SqlCommand("SELECT [Category] FROM EA_DomainCatCap WHERE [DomainID] ='" + DropDownList5.SelectedValue + "'	 GROUP BY [Category]", con);
            SqlDataReader drs2 = command2.ExecuteReader();

            while (drs2.Read())
            {
                ListItem dd = new ListItem();
                dd.Text = drs2["Category"].ToString();
               // dd.Value = drs2["ServiceID"].ToString();
                DropDownList3.Items.Add(dd);
            }

            con.Close();
            con.Open();
            //get all vendors
            SqlCommand command3 = new SqlCommand("SELECT [CapabilityName], [CapabilityID] FROM EA_DomainCatCap WHERE [DomainID] = '"+DropDownList5.SelectedValue+"' GROUP BY [CapabilityName], [CapabilityID]", con);
            SqlDataReader drs3 = command3.ExecuteReader();

            while (drs3.Read())
            {
                ListItem dd = new ListItem();
                dd.Text = drs3["CapabilityName"].ToString();
                 dd.Value = drs3["CapabilityID"].ToString();
                DropDownList4.Items.Add(dd);
            }
            // SqlDataSource2.SelectCommand="SELECT CapabilityName,CapabilityID FROM EA_DomainCatCap WHERE DomainID='"+DropDownList5.SelectedValue+"' GROUP BY CapabilityName,CapabilityID";


        }
    }
}
public class SessionController
{
    public static string Vendor
    {
        get
        {
            if (System.Web.HttpContext.Current.Session["Vendor"] != null)
            {
                return System.Web.HttpContext.Current.Session["Vendor"].ToString();
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.Web.HttpContext.Current.Session["Vendor"] = value;
        }
    }
    public static string Password
    {
        get
        {
            if (System.Web.HttpContext.Current.Session["pass"] != null)
            {
                return System.Web.HttpContext.Current.Session["pass"].ToString();
            }
            else
            {
                return null;
            }
        }
        set
        {
            System.Web.HttpContext.Current.Session["pass"] = value;
        }
    }

    private class HttpContext
    {
        public static object Current { get; internal set; }
    }
}