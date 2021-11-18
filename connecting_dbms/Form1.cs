using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace connecting_dbms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_table()
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source = D:\C#Apps\Databases\dbtest.db");
            con.Open();

            //command object -> what query we want to execute
            string query = "SELECT * from inventory"; //we written a command and stored it into a string variable and passed it in the next line.
            SQLiteCommand cmd = new SQLiteCommand(query, con);//the first one is the query we want ot execute and second one is to where to excecute.            

            //adapter -> read the data from database and write it into the data grid.
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            //datatable object
            DataTable dt = new DataTable();
            adapter.Fill(dt);//reading the data from the db and copying into this dt object whic is basciacalyua data object.

            dataGridView1.DataSource = dt; // assigning the source.
            con.Close();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            show_table();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string cs = @"data source = D:\C#Apps\Databases\dbtest.db";

            using var con = new SQLiteConnection(cs);
            con.Open();

            string pname = name_Box.Text;
            string ppprice = price_Box.Text;
            string sname = supplierName_Box.Text;
            string pplace = place_Box.Text;

            //Checking if user ia giving some input or not
            if (pname == String.Empty)
            {
                MessageBox.Show("Enter product name !");
            }
            else if (ppprice == String.Empty) 
            {
                MessageBox.Show("Enter price !");
            }
            else if (sname == String.Empty || pplace == String.Empty)
            {
                MessageBox.Show("Enter data !");
            }
            //Checking if the inputs are fisible and ready to write on db. 
            else
            {
                int pprice = int.Parse(price_Box.Text);
                using var cmd = new SQLiteCommand(con);
                cmd.CommandText = "INSERT INTO inventory(product_name,product_price,supplier_name,product_place) VALUES(@p_name, @p_price,@s_name,@p_place)";
                cmd.Parameters.AddWithValue("@p_name", pname);
                cmd.Parameters.AddWithValue("@p_price", pprice);
                cmd.Parameters.AddWithValue("@s_name", sname);
                cmd.Parameters.AddWithValue("@p_place", pplace);
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted succesfully !");
            }

            

            show_table();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string index = id_Box1.Text;
            SQLiteConnection con = new SQLiteConnection(@"data source = D:\C#Apps\Databases\dbtest.db");
            con.Open();
            //string sqlStatement = "DELETE FROM inventory WHERE product_id='"+index+"'";
            string sqlStatement = "DELETE FROM inventory WHERE product_id='" + id_Box1.Text + "'";

            //string sqlStatement = "delete from Student where ID=" + textBox1.Text + "";

            SQLiteCommand cmd = new SQLiteCommand(sqlStatement, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
         
            MessageBox.Show("Succesfuuly Deleted");
            show_table();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source = D:\C#Apps\Databases\dbtest.db");
            con.Open();
            string query = "UPDATE inventory SET product_name = '" + name_Box.Text+ "',product_price='"+price_Box.Text+ "',supplier_name='"+supplierName_Box.Text+ "',product_place='"+place_Box.Text+"'   WHERE product_id = '" + id_Box1.Text+"'";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.CommandType = CommandType.Text; //converting into text
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Succesfully");
            show_table();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_table();
        }

        private void place_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
 