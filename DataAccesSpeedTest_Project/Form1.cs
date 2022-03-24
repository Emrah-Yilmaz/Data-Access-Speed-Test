using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccesSpeedTest_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEntity_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            NorthwindEntities db = new NorthwindEntities();


            try
            {
                listBoxEntityFramework.DataSource = db.Products.Select(

                                        x => x.ProductName
                                        ).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu");

            }
            finally
            {

                watch.Stop();
            }
            TxtEF.Text = watch.Elapsed.ToString();
        }

        private void BtnConnected_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection("Data Source=emrah57\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            cmd = new SqlCommand();

            con.Open();

            cmd.Connection = con;
            cmd.CommandText = "SELECT ProductName FROM Products";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBoxConnected.Items.Add(dr[0]);
            }
            con.Close();

            watch.Stop();
            TxtConnected.Text = watch.Elapsed.ToString();
        }

        private void BtnDisconnected_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            SqlConnection baglanti = new SqlConnection("Data Source=emrah57\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adp = new SqlDataAdapter("Select ProductName from Products", baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //dataGridView1.DataSource = dt;
            listBoxDisconnected.DataSource = dt;
            listBoxDisconnected.DisplayMember = "ProductName";
            watch.Stop();
            TxtDisc.Text = watch.Elapsed.ToString();
        }
    }
}
