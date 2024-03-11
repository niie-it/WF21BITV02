namespace QuanLyHangTon
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
			label1 = new Label();
			CboHangHoa = new ComboBox();
			LblDonGia = new Label();
			NudSoluong = new NumericUpDown();
			BtnTang = new Button();
			BtnGiam = new Button();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)NudSoluong).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Tahoma", 12F);
			label1.Location = new Point(36, 35);
			label1.Name = "label1";
			label1.Size = new Size(190, 48);
			label1.TabIndex = 0;
			label1.Text = "Hàng hóa";
			// 
			// CboHangHoa
			// 
			CboHangHoa.DropDownStyle = ComboBoxStyle.DropDownList;
			CboHangHoa.Font = new Font("Tahoma", 12F);
			CboHangHoa.FormattingEnabled = true;
			CboHangHoa.Location = new Point(39, 94);
			CboHangHoa.Name = "CboHangHoa";
			CboHangHoa.Size = new Size(520, 56);
			CboHangHoa.TabIndex = 1;
			CboHangHoa.SelectedIndexChanged += CboHangHoa_SelectedIndexChanged;
			// 
			// LblDonGia
			// 
			LblDonGia.AutoSize = true;
			LblDonGia.Font = new Font("Tahoma", 12F);
			LblDonGia.ForeColor = Color.Red;
			LblDonGia.Location = new Point(41, 173);
			LblDonGia.Name = "LblDonGia";
			LblDonGia.Size = new Size(124, 48);
			LblDonGia.TabIndex = 2;
			LblDonGia.Text = "label2";
			// 
			// NudSoluong
			// 
			NudSoluong.Font = new Font("Tahoma", 12F);
			NudSoluong.Location = new Point(612, 94);
			NudSoluong.Name = "NudSoluong";
			NudSoluong.Size = new Size(300, 56);
			NudSoluong.TabIndex = 3;
			// 
			// BtnTang
			// 
			BtnTang.Font = new Font("Tahoma", 12F);
			BtnTang.Location = new Point(1017, 84);
			BtnTang.Name = "BtnTang";
			BtnTang.Size = new Size(188, 58);
			BtnTang.TabIndex = 4;
			BtnTang.Text = "Tăng";
			BtnTang.UseVisualStyleBackColor = true;
			BtnTang.Click += BtnTang_Click;
			// 
			// BtnGiam
			// 
			BtnGiam.Font = new Font("Tahoma", 12F);
			BtnGiam.Location = new Point(1310, 87);
			BtnGiam.Name = "BtnGiam";
			BtnGiam.Size = new Size(188, 58);
			BtnGiam.TabIndex = 5;
			BtnGiam.Text = "Giảm";
			BtnGiam.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 250);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 102;
			dataGridView1.Size = new Size(1506, 484);
			dataGridView1.TabIndex = 6;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(17F, 41F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1530, 740);
			Controls.Add(dataGridView1);
			Controls.Add(BtnGiam);
			Controls.Add(BtnTang);
			Controls.Add(NudSoluong);
			Controls.Add(LblDonGia);
			Controls.Add(CboHangHoa);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)NudSoluong).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox CboHangHoa;
		private Label LblDonGia;
		private NumericUpDown NudSoluong;
		private Button BtnTang;
		private Button BtnGiam;
		private DataGridView dataGridView1;
	}
}
