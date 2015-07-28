using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;


namespace SqlPRoject
{
    public partial class Contact : Page
    {
       SqlConnection con =  new SqlConnection("Server=USHDC4902;Database=Service_Delivery;Trusted_Connection=true");

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into EA_TechnologyUpdate ('DomainMF','DomainID,'Category','CapabilityID', 'PractitionerFacing','Service','VendorID', 'Technology','External cloud', 'Owner','Status','GoLiveDate', 'RetireDate') Values ('@DomainMF','@DomainID,'@Category','@CapabilityID', '@PractitionerFacing','@Service','@VendorID', '@Technology','@External cloud', '@Owner','@Status','@GoLiveDate', '@RetireDate')  ";
            //Values that are being enter into the database
            cmd.Parameters.AddWithValue("@DomainMF", DomainName.Text);
            cmd.Parameters.AddWithValue("@DomainID", DomainName.Text);
            cmd.Parameters.AddWithValue("@Category", DomainName.Text);
            cmd.Parameters.AddWithValue("@CapabilityID", DomainName.Text);
            cmd.Parameters.AddWithValue("@PractitionerFacing", DomainName.Text);
            cmd.Parameters.AddWithValue("@Service", DomainName.Text);
            cmd.Parameters.AddWithValue("@VendorID", DomainName.Text);
            cmd.Parameters.AddWithValue("@Technology", DomainName.Text);
            cmd.Parameters.AddWithValue("@ExternalCloud", DomainName.Text);
            cmd.Parameters.AddWithValue("@Owner", DomainName.Text);
            cmd.Parameters.AddWithValue("@Status", DomainName.Text);
            cmd.Parameters.AddWithValue("@GoLiveDate", DomainName.Text);
            cmd.Parameters.AddWithValue("@RetireDate", DomainName.Text);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}