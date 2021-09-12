using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_1911185
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Reset();
		}

		private void Reset()
		{
			this.cboMaHV.Text = "";
			this.txtHoTen.Text = "";
			this.dtpNgayDangKy.Value = DateTime.Now;
			this.rdbNam.Checked = true;
			this.chbTinHocA.Checked = false;
			this.chbTinHocB.Checked = false;
			this.chbTiengAnhA.Checked = false;
			this.chbTiengAnhB.Checked = false;
			this.txtTongTien.Text = "";
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int s = 0;
			if (chbTinHocA.Checked)
				s += int.Parse(lblTienTHA.Text.Split('.')[0]);
			if (chbTinHocB.Checked)
				s += int.Parse(lblTienTHB.Text.Split('.')[0]);
			if (chbTiengAnhA.Checked)
				s += int.Parse(lblTienTAA.Text.Split('.')[0]);
			if (chbTiengAnhB.Checked)
				s += int.Parse(lblTienTAB.Text.Split('.')[0]);
			this.txtTongTien.Text = s + ".000 đồng";
		}
	}
}
