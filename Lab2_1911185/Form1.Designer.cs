
namespace Lab2_1911185
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTienTHA = new System.Windows.Forms.Label();
			this.lblTienTHB = new System.Windows.Forms.Label();
			this.lblTienTAA = new System.Windows.Forms.Label();
			this.lblTienTAB = new System.Windows.Forms.Label();
			this.cboMaHV = new System.Windows.Forms.ComboBox();
			this.rdbNam = new System.Windows.Forms.RadioButton();
			this.rdbNu = new System.Windows.Forms.RadioButton();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
			this.chbTinHocA = new System.Windows.Forms.CheckBox();
			this.chbTinHocB = new System.Windows.Forms.CheckBox();
			this.chbTiengAnhA = new System.Windows.Forms.CheckBox();
			this.chbTiengAnhB = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(303, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "TÍNH TIỀN HỌC TRUNG TÂM";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã học viện";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(381, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Giới tính";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Họ tên";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(61, 150);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Ngày Đăng Ký";
			// 
			// lblTienTHA
			// 
			this.lblTienTHA.AutoSize = true;
			this.lblTienTHA.Location = new System.Drawing.Point(346, 206);
			this.lblTienTHA.Name = "lblTienTHA";
			this.lblTienTHA.Size = new System.Drawing.Size(77, 15);
			this.lblTienTHA.TabIndex = 5;
			this.lblTienTHA.Text = "300.000 đồng";
			// 
			// lblTienTHB
			// 
			this.lblTienTHB.AutoSize = true;
			this.lblTienTHB.Location = new System.Drawing.Point(346, 250);
			this.lblTienTHB.Name = "lblTienTHB";
			this.lblTienTHB.Size = new System.Drawing.Size(77, 15);
			this.lblTienTHB.TabIndex = 6;
			this.lblTienTHB.Text = "500.000 đồng";
			// 
			// lblTienTAA
			// 
			this.lblTienTAA.AutoSize = true;
			this.lblTienTAA.Location = new System.Drawing.Point(346, 292);
			this.lblTienTAA.Name = "lblTienTAA";
			this.lblTienTAA.Size = new System.Drawing.Size(77, 15);
			this.lblTienTAA.TabIndex = 7;
			this.lblTienTAA.Text = "400.000 đồng";
			// 
			// lblTienTAB
			// 
			this.lblTienTAB.AutoSize = true;
			this.lblTienTAB.Location = new System.Drawing.Point(346, 333);
			this.lblTienTAB.Name = "lblTienTAB";
			this.lblTienTAB.Size = new System.Drawing.Size(77, 15);
			this.lblTienTAB.TabIndex = 8;
			this.lblTienTAB.Text = "600.000 đồng";
			// 
			// cboMaHV
			// 
			this.cboMaHV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMaHV.FormattingEnabled = true;
			this.cboMaHV.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
			this.cboMaHV.Location = new System.Drawing.Point(150, 55);
			this.cboMaHV.Name = "cboMaHV";
			this.cboMaHV.Size = new System.Drawing.Size(198, 23);
			this.cboMaHV.TabIndex = 9;
			// 
			// rdbNam
			// 
			this.rdbNam.AutoSize = true;
			this.rdbNam.Location = new System.Drawing.Point(439, 51);
			this.rdbNam.Name = "rdbNam";
			this.rdbNam.Size = new System.Drawing.Size(51, 19);
			this.rdbNam.TabIndex = 10;
			this.rdbNam.TabStop = true;
			this.rdbNam.Text = "Nam";
			this.rdbNam.UseVisualStyleBackColor = true;
			// 
			// rdbNu
			// 
			this.rdbNu.AutoSize = true;
			this.rdbNu.Location = new System.Drawing.Point(509, 51);
			this.rdbNu.Name = "rdbNu";
			this.rdbNu.Size = new System.Drawing.Size(41, 19);
			this.rdbNu.TabIndex = 11;
			this.rdbNu.TabStop = true;
			this.rdbNu.Text = "Nữ";
			this.rdbNu.UseVisualStyleBackColor = true;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(148, 97);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(200, 23);
			this.txtHoTen.TabIndex = 12;
			// 
			// dtpNgayDangKy
			// 
			this.dtpNgayDangKy.Location = new System.Drawing.Point(148, 144);
			this.dtpNgayDangKy.Name = "dtpNgayDangKy";
			this.dtpNgayDangKy.Size = new System.Drawing.Size(200, 23);
			this.dtpNgayDangKy.TabIndex = 13;
			// 
			// chbTinHocA
			// 
			this.chbTinHocA.AutoSize = true;
			this.chbTinHocA.Location = new System.Drawing.Point(61, 205);
			this.chbTinHocA.Name = "chbTinHocA";
			this.chbTinHocA.Size = new System.Drawing.Size(76, 19);
			this.chbTinHocA.TabIndex = 14;
			this.chbTinHocA.Text = "Tin học A";
			this.chbTinHocA.UseVisualStyleBackColor = true;
			// 
			// chbTinHocB
			// 
			this.chbTinHocB.AutoSize = true;
			this.chbTinHocB.Location = new System.Drawing.Point(61, 249);
			this.chbTinHocB.Name = "chbTinHocB";
			this.chbTinHocB.Size = new System.Drawing.Size(75, 19);
			this.chbTinHocB.TabIndex = 15;
			this.chbTinHocB.Text = "Tin học B";
			this.chbTinHocB.UseVisualStyleBackColor = true;
			// 
			// chbTiengAnhA
			// 
			this.chbTiengAnhA.AutoSize = true;
			this.chbTiengAnhA.Location = new System.Drawing.Point(61, 288);
			this.chbTiengAnhA.Name = "chbTiengAnhA";
			this.chbTiengAnhA.Size = new System.Drawing.Size(91, 19);
			this.chbTiengAnhA.TabIndex = 16;
			this.chbTiengAnhA.Text = "Tiếng Anh A";
			this.chbTiengAnhA.UseVisualStyleBackColor = true;
			// 
			// chbTiengAnhB
			// 
			this.chbTiengAnhB.AutoSize = true;
			this.chbTiengAnhB.Location = new System.Drawing.Point(61, 332);
			this.chbTiengAnhB.Name = "chbTiengAnhB";
			this.chbTiengAnhB.Size = new System.Drawing.Size(90, 19);
			this.chbTiengAnhB.TabIndex = 17;
			this.chbTiengAnhB.Text = "Tiếng Anh B";
			this.chbTiengAnhB.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(163, 387);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 15);
			this.label10.TabIndex = 18;
			this.label10.Text = "Tổng tiền";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(226, 384);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(197, 23);
			this.txtTongTien.TabIndex = 19;
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Location = new System.Drawing.Point(61, 432);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(75, 23);
			this.btnTinhTien.TabIndex = 20;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(206, 432);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(348, 432);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 22;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 572);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnTinhTien);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.chbTiengAnhB);
			this.Controls.Add(this.chbTiengAnhA);
			this.Controls.Add(this.chbTinHocB);
			this.Controls.Add(this.chbTinHocA);
			this.Controls.Add(this.dtpNgayDangKy);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.rdbNu);
			this.Controls.Add(this.rdbNam);
			this.Controls.Add(this.cboMaHV);
			this.Controls.Add(this.lblTienTAB);
			this.Controls.Add(this.lblTienTAA);
			this.Controls.Add(this.lblTienTHB);
			this.Controls.Add(this.lblTienTHA);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblTienTHA;
		private System.Windows.Forms.Label lblTienTHB;
		private System.Windows.Forms.Label lblTienTAA;
		private System.Windows.Forms.Label lblTienTAB;
		private System.Windows.Forms.ComboBox cboMaHV;
		private System.Windows.Forms.RadioButton rdbNam;
		private System.Windows.Forms.RadioButton rdbNu;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
		private System.Windows.Forms.CheckBox chbTinHocA;
		private System.Windows.Forms.CheckBox chbTinHocB;
		private System.Windows.Forms.CheckBox chbTiengAnhA;
		private System.Windows.Forms.CheckBox chbTiengAnhB;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Button btnTinhTien;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnExit;
	}
}

