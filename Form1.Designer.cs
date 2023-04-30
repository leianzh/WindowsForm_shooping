namespace WindowsForm_shooping
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.tbresult = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbQuantity1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pbmilktea = new System.Windows.Forms.PictureBox();
			this.pbblacktea = new System.Windows.Forms.PictureBox();
			this.pbcat = new System.Windows.Forms.PictureBox();
			this.pbgreentea = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbQuantity2 = new System.Windows.Forms.NumericUpDown();
			this.tbQuantity3 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.tbQuantity1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbmilktea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbblacktea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbcat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbgreentea)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbQuantity2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbQuantity3)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(531, 360);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 34);
			this.button1.TabIndex = 6;
			this.button1.Text = "結帳";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbresult
			// 
			this.tbresult.Location = new System.Drawing.Point(116, 436);
			this.tbresult.Margin = new System.Windows.Forms.Padding(4);
			this.tbresult.Multiline = true;
			this.tbresult.Name = "tbresult";
			this.tbresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbresult.Size = new System.Drawing.Size(973, 205);
			this.tbresult.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(261, 90);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "商品數量";
			// 
			// tbQuantity1
			// 
			this.tbQuantity1.Location = new System.Drawing.Point(264, 136);
			this.tbQuantity1.Name = "tbQuantity1";
			this.tbQuantity1.ReadOnly = true;
			this.tbQuantity1.Size = new System.Drawing.Size(98, 29);
			this.tbQuantity1.TabIndex = 0;
			this.tbQuantity1.ValueChanged += new System.EventHandler(this.tbQuantity1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(112, 394);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "銷售明細";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(93, 14);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 18);
			this.label4.TabIndex = 3;
			this.label4.Text = "熟成紅茶";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(543, 90);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 18);
			this.label6.TabIndex = 4;
			this.label6.Text = "商品數量";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pbmilktea
			// 
			this.pbmilktea.Image = ((System.Drawing.Image)(resources.GetObject("pbmilktea.Image")));
			this.pbmilktea.Location = new System.Drawing.Point(364, 50);
			this.pbmilktea.Margin = new System.Windows.Forms.Padding(4);
			this.pbmilktea.Name = "pbmilktea";
			this.pbmilktea.Size = new System.Drawing.Size(150, 280);
			this.pbmilktea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbmilktea.TabIndex = 13;
			this.pbmilktea.TabStop = false;
			// 
			// pbblacktea
			// 
			this.pbblacktea.Image = ((System.Drawing.Image)(resources.GetObject("pbblacktea.Image")));
			this.pbblacktea.Location = new System.Drawing.Point(96, 50);
			this.pbblacktea.Margin = new System.Windows.Forms.Padding(4);
			this.pbblacktea.Name = "pbblacktea";
			this.pbblacktea.Size = new System.Drawing.Size(150, 266);
			this.pbblacktea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbblacktea.TabIndex = 14;
			this.pbblacktea.TabStop = false;
			// 
			// pbcat
			// 
			this.pbcat.Image = ((System.Drawing.Image)(resources.GetObject("pbcat.Image")));
			this.pbcat.Location = new System.Drawing.Point(939, 64);
			this.pbcat.Margin = new System.Windows.Forms.Padding(4);
			this.pbcat.Name = "pbcat";
			this.pbcat.Size = new System.Drawing.Size(183, 266);
			this.pbcat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbcat.TabIndex = 15;
			this.pbcat.TabStop = false;
			// 
			// pbgreentea
			// 
			this.pbgreentea.Image = ((System.Drawing.Image)(resources.GetObject("pbgreentea.Image")));
			this.pbgreentea.Location = new System.Drawing.Point(663, 54);
			this.pbgreentea.Margin = new System.Windows.Forms.Padding(4);
			this.pbgreentea.Name = "pbgreentea";
			this.pbgreentea.Size = new System.Drawing.Size(150, 280);
			this.pbgreentea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbgreentea.TabIndex = 16;
			this.pbgreentea.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(362, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 18);
			this.label1.TabIndex = 3;
			this.label1.Text = "熟成歐蕾";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(957, 14);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 18);
			this.label7.TabIndex = 18;
			this.label7.Text = "蚵仔";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(660, 14);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 18);
			this.label8.TabIndex = 6;
			this.label8.Text = "春芽冷露";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(831, 90);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 18);
			this.label9.TabIndex = 7;
			this.label9.Text = "商品數量";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(1143, 77);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(44, 18);
			this.label10.TabIndex = 9;
			this.label10.Text = "無價";
			// 
			// tbQuantity2
			// 
			this.tbQuantity2.Location = new System.Drawing.Point(533, 136);
			this.tbQuantity2.Name = "tbQuantity2";
			this.tbQuantity2.ReadOnly = true;
			this.tbQuantity2.Size = new System.Drawing.Size(98, 29);
			this.tbQuantity2.TabIndex = 1;
			this.tbQuantity2.ValueChanged += new System.EventHandler(this.tbQuantity2_ValueChanged);
			// 
			// tbQuantity3
			// 
			this.tbQuantity3.Location = new System.Drawing.Point(825, 136);
			this.tbQuantity3.Name = "tbQuantity3";
			this.tbQuantity3.ReadOnly = true;
			this.tbQuantity3.Size = new System.Drawing.Size(98, 29);
			this.tbQuantity3.TabIndex = 2;
			this.tbQuantity3.ValueChanged += new System.EventHandler(this.tbQuantity3_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 675);
			this.Controls.Add(this.tbQuantity3);
			this.Controls.Add(this.tbQuantity2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbgreentea);
			this.Controls.Add(this.pbcat);
			this.Controls.Add(this.pbblacktea);
			this.Controls.Add(this.pbmilktea);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbQuantity1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbresult);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.tbQuantity1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbmilktea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbblacktea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbcat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbgreentea)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbQuantity2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbQuantity3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbresult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown tbQuantity1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pbmilktea;
		private System.Windows.Forms.PictureBox pbblacktea;
		private System.Windows.Forms.PictureBox pbcat;
		private System.Windows.Forms.PictureBox pbgreentea;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown tbQuantity2;
		private System.Windows.Forms.NumericUpDown tbQuantity3;
	}
}

