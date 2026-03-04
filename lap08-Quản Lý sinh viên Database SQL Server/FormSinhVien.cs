using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap08_Quản_Lý_sinh_viên_Database_SQL_Server
{
	public partial class FormSinhVien : Form
	{
		string connectionString =
		"Server=.;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

		public FormSinhVien()
		{
			InitializeComponent();
		}

		private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void FormSinhVien_Load(object sender, EventArgs e)
		{
			using SqlConnection conn = new SqlConnection(connectionString);
			string sql = "SELECT * FROM SinhVien";

			SqlDataAdapter da = new SqlDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			dgvSinhVien.DataSource = dt;
		}
	}
}
