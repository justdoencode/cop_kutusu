using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cop_kutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_notlar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void adet()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_adet", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_toplamnot.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-323TRBO\\SQLEXPRESS;Initial Catalog=db_notkutusu;Integrated Security=True");
        private void btn_notekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_notlar (not_baslik,not_icerik) values (@baslik,@icerik)", baglanti);
            cmd.Parameters.AddWithValue("@baslik", txt_baslik.Text);
            cmd.Parameters.AddWithValue("@icerik", rch_icerik.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Not Eklendi","Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
            adet();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            adet();
        }

        private void btn_notsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_notlar where not_id=@id", baglanti);
            cmd.Parameters.AddWithValue("@id", txt_id.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Mesaj Silindi","Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            baglanti.Close();
            listele();
            adet();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btn_copkutusu_Click(object sender, EventArgs e)
        {
            frm_copkutusu frmcopkutusu = new frm_copkutusu();
            frmcopkutusu.Show();
        }
    }
}
