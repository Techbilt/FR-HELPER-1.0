namespace Flight_Rising_BBCode
{
	partial class Form7
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.breedFather = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tertColorFather = new System.Windows.Forms.ComboBox();
			this.tertGeneFather = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.secondaryColorFather = new System.Windows.Forms.ComboBox();
			this.secondaryGeneFather = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.primaryColorFather = new System.Windows.Forms.ComboBox();
			this.primaryGeneFather = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.fatherID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtFatherName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.breedMother = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tertColorMother = new System.Windows.Forms.ComboBox();
			this.tertGeneMother = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.secondaryColorMother = new System.Windows.Forms.ComboBox();
			this.secondaryGeneMother = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.primaryColorMother = new System.Windows.Forms.ComboBox();
			this.primaryGeneMother = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtMotherID = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtMotherName = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.lblOffspringPrediction = new System.Windows.Forms.WebBrowser();
			this.picFathersAvatar = new System.Windows.Forms.PictureBox();
			this.lblFathersInfo = new System.Windows.Forms.Label();
			this.picMotherAvatar = new System.Windows.Forms.PictureBox();
			this.lblMotherInfo = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFathersAvatar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.breedFather);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.tertColorFather);
			this.groupBox1.Controls.Add(this.tertGeneFather);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.secondaryColorFather);
			this.groupBox1.Controls.Add(this.secondaryGeneFather);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.primaryColorFather);
			this.groupBox1.Controls.Add(this.primaryGeneFather);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.fatherID);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtFatherName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(91, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 192);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Father";
			// 
			// breedFather
			// 
			this.breedFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.breedFather.FormattingEnabled = true;
			this.breedFather.Location = new System.Drawing.Point(74, 70);
			this.breedFather.Name = "breedFather";
			this.breedFather.Size = new System.Drawing.Size(185, 21);
			this.breedFather.Sorted = true;
			this.breedFather.TabIndex = 3;
			this.breedFather.SelectedIndexChanged += new System.EventHandler(this.breedFather_SelectedIndexChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(30, 73);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(38, 13);
			this.label12.TabIndex = 13;
			this.label12.Text = "Breed:";
			// 
			// tertColorFather
			// 
			this.tertColorFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tertColorFather.FormattingEnabled = true;
			this.tertColorFather.Location = new System.Drawing.Point(168, 155);
			this.tertColorFather.Name = "tertColorFather";
			this.tertColorFather.Size = new System.Drawing.Size(91, 21);
			this.tertColorFather.TabIndex = 9;
			// 
			// tertGeneFather
			// 
			this.tertGeneFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tertGeneFather.FormattingEnabled = true;
			this.tertGeneFather.Location = new System.Drawing.Point(74, 155);
			this.tertGeneFather.Name = "tertGeneFather";
			this.tertGeneFather.Size = new System.Drawing.Size(88, 21);
			this.tertGeneFather.Sorted = true;
			this.tertGeneFather.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 158);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Tertiary:";
			// 
			// secondaryColorFather
			// 
			this.secondaryColorFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.secondaryColorFather.FormattingEnabled = true;
			this.secondaryColorFather.Location = new System.Drawing.Point(168, 126);
			this.secondaryColorFather.Name = "secondaryColorFather";
			this.secondaryColorFather.Size = new System.Drawing.Size(91, 21);
			this.secondaryColorFather.TabIndex = 7;
			// 
			// secondaryGeneFather
			// 
			this.secondaryGeneFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.secondaryGeneFather.FormattingEnabled = true;
			this.secondaryGeneFather.Location = new System.Drawing.Point(74, 126);
			this.secondaryGeneFather.Name = "secondaryGeneFather";
			this.secondaryGeneFather.Size = new System.Drawing.Size(88, 21);
			this.secondaryGeneFather.Sorted = true;
			this.secondaryGeneFather.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Secondary:";
			// 
			// primaryColorFather
			// 
			this.primaryColorFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.primaryColorFather.FormattingEnabled = true;
			this.primaryColorFather.Location = new System.Drawing.Point(168, 99);
			this.primaryColorFather.Name = "primaryColorFather";
			this.primaryColorFather.Size = new System.Drawing.Size(91, 21);
			this.primaryColorFather.TabIndex = 5;
			// 
			// primaryGeneFather
			// 
			this.primaryGeneFather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.primaryGeneFather.FormattingEnabled = true;
			this.primaryGeneFather.Location = new System.Drawing.Point(74, 98);
			this.primaryGeneFather.Name = "primaryGeneFather";
			this.primaryGeneFather.Size = new System.Drawing.Size(88, 21);
			this.primaryGeneFather.Sorted = true;
			this.primaryGeneFather.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Primary:";
			// 
			// fatherID
			// 
			this.fatherID.Location = new System.Drawing.Point(74, 44);
			this.fatherID.Name = "fatherID";
			this.fatherID.Size = new System.Drawing.Size(185, 20);
			this.fatherID.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Dragon ID:";
			// 
			// txtFatherName
			// 
			this.txtFatherName.Location = new System.Drawing.Point(74, 17);
			this.txtFatherName.Name = "txtFatherName";
			this.txtFatherName.Size = new System.Drawing.Size(185, 20);
			this.txtFatherName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.breedMother);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.tertColorMother);
			this.groupBox2.Controls.Add(this.tertGeneMother);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.secondaryColorMother);
			this.groupBox2.Controls.Add(this.secondaryGeneMother);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.primaryColorMother);
			this.groupBox2.Controls.Add(this.primaryGeneMother);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtMotherID);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.txtMotherName);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Location = new System.Drawing.Point(375, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(278, 193);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mother";
			// 
			// breedMother
			// 
			this.breedMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.breedMother.FormattingEnabled = true;
			this.breedMother.Location = new System.Drawing.Point(74, 70);
			this.breedMother.Name = "breedMother";
			this.breedMother.Size = new System.Drawing.Size(185, 21);
			this.breedMother.TabIndex = 12;
			this.breedMother.SelectedIndexChanged += new System.EventHandler(this.breedMother_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(30, 73);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(35, 13);
			this.label13.TabIndex = 13;
			this.label13.Text = "Breed";
			// 
			// tertColorMother
			// 
			this.tertColorMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tertColorMother.FormattingEnabled = true;
			this.tertColorMother.Location = new System.Drawing.Point(165, 155);
			this.tertColorMother.Name = "tertColorMother";
			this.tertColorMother.Size = new System.Drawing.Size(94, 21);
			this.tertColorMother.TabIndex = 18;
			// 
			// tertGeneMother
			// 
			this.tertGeneMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tertGeneMother.FormattingEnabled = true;
			this.tertGeneMother.Location = new System.Drawing.Point(74, 155);
			this.tertGeneMother.Name = "tertGeneMother";
			this.tertGeneMother.Size = new System.Drawing.Size(85, 21);
			this.tertGeneMother.Sorted = true;
			this.tertGeneMother.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 158);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Tertiary:";
			// 
			// secondaryColorMother
			// 
			this.secondaryColorMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.secondaryColorMother.FormattingEnabled = true;
			this.secondaryColorMother.Location = new System.Drawing.Point(165, 124);
			this.secondaryColorMother.Name = "secondaryColorMother";
			this.secondaryColorMother.Size = new System.Drawing.Size(94, 21);
			this.secondaryColorMother.TabIndex = 16;
			// 
			// secondaryGeneMother
			// 
			this.secondaryGeneMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.secondaryGeneMother.FormattingEnabled = true;
			this.secondaryGeneMother.Location = new System.Drawing.Point(74, 124);
			this.secondaryGeneMother.Name = "secondaryGeneMother";
			this.secondaryGeneMother.Size = new System.Drawing.Size(85, 21);
			this.secondaryGeneMother.Sorted = true;
			this.secondaryGeneMother.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 127);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Secondary:";
			// 
			// primaryColorMother
			// 
			this.primaryColorMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.primaryColorMother.FormattingEnabled = true;
			this.primaryColorMother.Location = new System.Drawing.Point(165, 97);
			this.primaryColorMother.Name = "primaryColorMother";
			this.primaryColorMother.Size = new System.Drawing.Size(94, 21);
			this.primaryColorMother.TabIndex = 14;
			// 
			// primaryGeneMother
			// 
			this.primaryGeneMother.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.primaryGeneMother.FormattingEnabled = true;
			this.primaryGeneMother.Location = new System.Drawing.Point(74, 97);
			this.primaryGeneMother.Name = "primaryGeneMother";
			this.primaryGeneMother.Size = new System.Drawing.Size(85, 21);
			this.primaryGeneMother.Sorted = true;
			this.primaryGeneMother.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(24, 100);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Primary:";
			// 
			// txtMotherID
			// 
			this.txtMotherID.Location = new System.Drawing.Point(74, 44);
			this.txtMotherID.Name = "txtMotherID";
			this.txtMotherID.Size = new System.Drawing.Size(185, 20);
			this.txtMotherID.TabIndex = 11;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Dragon ID:";
			// 
			// txtMotherName
			// 
			this.txtMotherName.Location = new System.Drawing.Point(74, 18);
			this.txtMotherName.Name = "txtMotherName";
			this.txtMotherName.Size = new System.Drawing.Size(185, 20);
			this.txtMotherName.TabIndex = 10;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(30, 21);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Name:";
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(335, 211);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 15;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// lblOffspringPrediction
			// 
			this.lblOffspringPrediction.AllowWebBrowserDrop = false;
			this.lblOffspringPrediction.Location = new System.Drawing.Point(15, 243);
			this.lblOffspringPrediction.MinimumSize = new System.Drawing.Size(20, 20);
			this.lblOffspringPrediction.Name = "lblOffspringPrediction";
			this.lblOffspringPrediction.ScrollBarsEnabled = false;
			this.lblOffspringPrediction.Size = new System.Drawing.Size(729, 120);
			this.lblOffspringPrediction.TabIndex = 16;
			this.lblOffspringPrediction.TabStop = false;
			// 
			// picFathersAvatar
			// 
			this.picFathersAvatar.Location = new System.Drawing.Point(12, 276);
			this.picFathersAvatar.Name = "picFathersAvatar";
			this.picFathersAvatar.Size = new System.Drawing.Size(100, 100);
			this.picFathersAvatar.TabIndex = 17;
			this.picFathersAvatar.TabStop = false;
			// 
			// lblFathersInfo
			// 
			this.lblFathersInfo.AutoSize = true;
			this.lblFathersInfo.Location = new System.Drawing.Point(12, 251);
			this.lblFathersInfo.Name = "lblFathersInfo";
			this.lblFathersInfo.Size = new System.Drawing.Size(0, 13);
			this.lblFathersInfo.TabIndex = 18;
			// 
			// picMotherAvatar
			// 
			this.picMotherAvatar.Location = new System.Drawing.Point(664, 276);
			this.picMotherAvatar.Name = "picMotherAvatar";
			this.picMotherAvatar.Size = new System.Drawing.Size(100, 100);
			this.picMotherAvatar.TabIndex = 19;
			this.picMotherAvatar.TabStop = false;
			// 
			// lblMotherInfo
			// 
			this.lblMotherInfo.AutoSize = true;
			this.lblMotherInfo.Location = new System.Drawing.Point(661, 251);
			this.lblMotherInfo.Name = "lblMotherInfo";
			this.lblMotherInfo.Size = new System.Drawing.Size(0, 13);
			this.lblMotherInfo.TabIndex = 20;
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 375);
			this.Controls.Add(this.lblMotherInfo);
			this.Controls.Add(this.picMotherAvatar);
			this.Controls.Add(this.lblFathersInfo);
			this.Controls.Add(this.picFathersAvatar);
			this.Controls.Add(this.lblOffspringPrediction);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form7";
			this.Text = "Small Breeding Card";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFathersAvatar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMotherAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox breedFather;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox tertColorFather;
		private System.Windows.Forms.ComboBox tertGeneFather;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox secondaryColorFather;
		private System.Windows.Forms.ComboBox secondaryGeneFather;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox primaryColorFather;
		private System.Windows.Forms.ComboBox primaryGeneFather;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox fatherID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFatherName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox breedMother;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox tertColorMother;
		private System.Windows.Forms.ComboBox tertGeneMother;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox secondaryColorMother;
		private System.Windows.Forms.ComboBox secondaryGeneMother;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox primaryColorMother;
		private System.Windows.Forms.ComboBox primaryGeneMother;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtMotherID;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtMotherName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.WebBrowser lblOffspringPrediction;
		private System.Windows.Forms.PictureBox picFathersAvatar;
		private System.Windows.Forms.Label lblFathersInfo;
		private System.Windows.Forms.PictureBox picMotherAvatar;
		private System.Windows.Forms.Label lblMotherInfo;
	}
}