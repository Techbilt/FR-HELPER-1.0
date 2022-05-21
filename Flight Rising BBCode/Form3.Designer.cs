namespace Flight_Rising_BBCode
{
	partial class Form3
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
			this.label1 = new System.Windows.Forms.Label();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.countItem = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNotableItems = new System.Windows.Forms.RichTextBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCode = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.venueCombo = new System.Windows.Forms.ComboBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.btnLoad = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtDerg3 = new System.Windows.Forms.TextBox();
			this.txtDerg2 = new System.Windows.Forms.TextBox();
			this.txtDerg1 = new System.Windows.Forms.TextBox();
			this.imgDerg1 = new System.Windows.Forms.PictureBox();
			this.imgDerg2 = new System.Windows.Forms.PictureBox();
			this.imgDerg3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.countItem)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgDerg1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgDerg2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgDerg3)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Drop to Collect:";
			// 
			// txtItem
			// 
			this.txtItem.Location = new System.Drawing.Point(19, 26);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(124, 20);
			this.txtItem.TabIndex = 1;
			// 
			// countItem
			// 
			this.countItem.Location = new System.Drawing.Point(149, 26);
			this.countItem.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.countItem.Name = "countItem";
			this.countItem.Size = new System.Drawing.Size(43, 20);
			this.countItem.TabIndex = 2;
			this.countItem.ValueChanged += new System.EventHandler(this.countItem_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Other Notable Drops:";
			// 
			// txtNotableItems
			// 
			this.txtNotableItems.Location = new System.Drawing.Point(19, 167);
			this.txtNotableItems.Name = "txtNotableItems";
			this.txtNotableItems.Size = new System.Drawing.Size(170, 185);
			this.txtNotableItems.TabIndex = 4;
			this.txtNotableItems.Text = "";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(99, 355);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 24);
			this.btnGenerate.TabIndex = 5;
			this.btnGenerate.Text = "Generate ";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(199, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Code:";
			// 
			// lblCode
			// 
			this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCode.Location = new System.Drawing.Point(202, 167);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(228, 185);
			this.lblCode.TabIndex = 7;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(180, 355);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 24);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(262, 355);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 24);
			this.btnCopy.TabIndex = 9;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(199, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Venue:";
			// 
			// venueCombo
			// 
			this.venueCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.venueCombo.FormattingEnabled = true;
			this.venueCombo.Items.AddRange(new object[] {
            "Training Fields",
            "Woodland Path",
            "Scortched Forest",
            "Sandswept Delta",
            "Blooming Grove",
            "Forgotten Cave",
            "Bamboo Falls",
            "Thunderhead Savana",
            "Redrock Cove",
            "Waterway",
            "Arena",
            "Volcanic Vents",
            "Rainsong Jungle",
            "Boreal Wood",
            "Crystal Pools",
            "Harpy\'s Roost",
            "Ghostlight Ruins",
            "Mire",
            "Golem Workshop",
            "Kelp Beds",
            "Forbidden Portal"});
			this.venueCombo.Location = new System.Drawing.Point(202, 26);
			this.venueCombo.Name = "venueCombo";
			this.venueCombo.Size = new System.Drawing.Size(169, 21);
			this.venueCombo.TabIndex = 11;
			this.venueCombo.SelectedIndexChanged += new System.EventHandler(this.venueCombo_SelectedIndexChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(19, 385);
			this.progressBar1.Maximum = 99;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(414, 23);
			this.progressBar1.TabIndex = 12;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(378, 23);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(55, 23);
			this.btnLoad.TabIndex = 13;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtDerg3);
			this.groupBox1.Controls.Add(this.txtDerg2);
			this.groupBox1.Controls.Add(this.txtDerg1);
			this.groupBox1.Controls.Add(this.imgDerg1);
			this.groupBox1.Controls.Add(this.imgDerg2);
			this.groupBox1.Controls.Add(this.imgDerg3);
			this.groupBox1.Location = new System.Drawing.Point(19, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(411, 92);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Coli Team:";
			// 
			// txtDerg3
			// 
			this.txtDerg3.Location = new System.Drawing.Point(21, 66);
			this.txtDerg3.Name = "txtDerg3";
			this.txtDerg3.Size = new System.Drawing.Size(117, 20);
			this.txtDerg3.TabIndex = 5;
			// 
			// txtDerg2
			// 
			this.txtDerg2.Location = new System.Drawing.Point(21, 42);
			this.txtDerg2.Name = "txtDerg2";
			this.txtDerg2.Size = new System.Drawing.Size(117, 20);
			this.txtDerg2.TabIndex = 4;
			// 
			// txtDerg1
			// 
			this.txtDerg1.Location = new System.Drawing.Point(21, 19);
			this.txtDerg1.Name = "txtDerg1";
			this.txtDerg1.Size = new System.Drawing.Size(117, 20);
			this.txtDerg1.TabIndex = 3;
			// 
			// imgDerg1
			// 
			this.imgDerg1.Location = new System.Drawing.Point(155, 11);
			this.imgDerg1.Name = "imgDerg1";
			this.imgDerg1.Size = new System.Drawing.Size(75, 75);
			this.imgDerg1.TabIndex = 2;
			this.imgDerg1.TabStop = false;
			// 
			// imgDerg2
			// 
			this.imgDerg2.Location = new System.Drawing.Point(236, 11);
			this.imgDerg2.Name = "imgDerg2";
			this.imgDerg2.Size = new System.Drawing.Size(75, 75);
			this.imgDerg2.TabIndex = 1;
			this.imgDerg2.TabStop = false;
			// 
			// imgDerg3
			// 
			this.imgDerg3.Location = new System.Drawing.Point(317, 11);
			this.imgDerg3.Name = "imgDerg3";
			this.imgDerg3.Size = new System.Drawing.Size(75, 75);
			this.imgDerg3.TabIndex = 0;
			this.imgDerg3.TabStop = false;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(444, 417);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.venueCombo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.txtNotableItems);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.countItem);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Long Drop Coli Challenge";
			((System.ComponentModel.ISupportInitialize)(this.countItem)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgDerg1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgDerg2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgDerg3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.NumericUpDown countItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtNotableItems;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox venueCombo;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtDerg3;
		private System.Windows.Forms.TextBox txtDerg2;
		private System.Windows.Forms.TextBox txtDerg1;
		private System.Windows.Forms.PictureBox imgDerg1;
		private System.Windows.Forms.PictureBox imgDerg2;
		private System.Windows.Forms.PictureBox imgDerg3;
	}
}