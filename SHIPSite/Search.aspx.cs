using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SHIPSite
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public List<Row> GetRows(){
            string query = Request.QueryString["q"];
            if (query==null||query.Equals("")){
                notFound.Text = "No results found";
                return new List<Row>();
            }
            List<string> split = new List<string>(query.Split(' '));
            split.AddRange(Enumerable.Repeat("", 15 - split.Count));
            List<Row> ret = new List<Row>();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;uid=user;pwd=Userp4ss;database=testdata;";
            MySqlCommand cmd = new MySqlCommand("search_expert_15", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("a", split.ElementAt(0)); cmd.Parameters.AddWithValue("b", split.ElementAt(1)); cmd.Parameters.AddWithValue("c", split.ElementAt(2));
            cmd.Parameters.AddWithValue("d", split.ElementAt(3)); cmd.Parameters.AddWithValue("e", split.ElementAt(4)); cmd.Parameters.AddWithValue("f", split.ElementAt(5));
            cmd.Parameters.AddWithValue("g", split.ElementAt(6)); cmd.Parameters.AddWithValue("h", split.ElementAt(7)); cmd.Parameters.AddWithValue("i", split.ElementAt(8));
            cmd.Parameters.AddWithValue("j", split.ElementAt(9)); cmd.Parameters.AddWithValue("k", split.ElementAt(10)); cmd.Parameters.AddWithValue("l", split.ElementAt(11));
            cmd.Parameters.AddWithValue("m", split.ElementAt(12)); cmd.Parameters.AddWithValue("n", split.ElementAt(13)); cmd.Parameters.AddWithValue("o", split.ElementAt(14));

            try{
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    ret.Add(new SHIPSite.Row(reader.GetString("id"), reader.GetString("title"), reader.GetString("snippet"), reader.GetString("abstract")));
                }
            }
            catch (MySqlException ex){}
            conn.Close();
            if (ret.Count == 0)
            {
                notFound.Text = "No results found";
            }
            return ret;
        }
        protected void Page_Load(object sender, EventArgs e){
            string q = Request.QueryString["q"];
            if (q != null)
            {
                Page.Title = q;
            }else
            {
                Page.Title = "No Results Found";
            }
        }
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e){
            if (e.Row.RowType == DataControlRowType.DataRow){
                foreach(string s in Request.QueryString["q"].Split(' ')){
                    var regex = new Regex(s, RegexOptions.IgnoreCase);
                    e.Row.Cells[2].Text = regex.Replace(e.Row.Cells[2].Text, "<strong>$&</strong>");
                    e.Row.Cells[3].Text= regex.Replace(e.Row.Cells[3].Text, "<strong>$&</strong>");
                }
                
            }
        }
    }
}