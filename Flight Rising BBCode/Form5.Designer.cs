namespace Flight_Rising_BBCode
{
	partial class Form5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.chkRarity = new System.Windows.Forms.CheckBox();
			this.paletteHeightNum = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.paletteWidthNum = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.listFonts = new System.Windows.Forms.ListBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCopyHyperText = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.lblFathersName = new System.Windows.Forms.Label();
			this.lblMotherName = new System.Windows.Forms.Label();
			this.imgMother = new System.Windows.Forms.PictureBox();
			this.imgFather = new System.Windows.Forms.PictureBox();
			this.lblMotherID = new System.Windows.Forms.Label();
			this.lblFatherID = new System.Windows.Forms.Label();
			this.lblOffspringPrediction = new System.Windows.Forms.WebBrowser();
			this.lblFatherRare = new System.Windows.Forms.Label();
			this.lblMotherRare = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paletteHeightNum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteWidthNum)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgMother)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgFather)).BeginInit();
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
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(278, 192);
			this.groupBox1.TabIndex = 0;
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
			this.groupBox2.Location = new System.Drawing.Point(614, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(278, 193);
			this.groupBox2.TabIndex = 13;
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
			this.btnGenerate.Location = new System.Drawing.Point(364, 167);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 42);
			this.btnGenerate.TabIndex = 19;
			this.btnGenerate.Text = "Generate Card";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.chkRarity);
			this.groupBox3.Controls.Add(this.paletteHeightNum);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.paletteWidthNum);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.listFonts);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Location = new System.Drawing.Point(297, 13);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(311, 146);
			this.groupBox3.TabIndex = 19;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Text Properties";
			// 
			// chkRarity
			// 
			this.chkRarity.AutoSize = true;
			this.chkRarity.Location = new System.Drawing.Point(169, 20);
			this.chkRarity.Name = "chkRarity";
			this.chkRarity.Size = new System.Drawing.Size(110, 17);
			this.chkRarity.TabIndex = 6;
			this.chkRarity.Text = "Show Rarity Type";
			this.chkRarity.UseVisualStyleBackColor = true;
			// 
			// paletteHeightNum
			// 
			this.paletteHeightNum.Location = new System.Drawing.Point(254, 90);
			this.paletteHeightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.paletteHeightNum.Name = "paletteHeightNum";
			this.paletteHeightNum.Size = new System.Drawing.Size(36, 20);
			this.paletteHeightNum.TabIndex = 5;
			this.paletteHeightNum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(163, 92);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(77, 13);
			this.label15.TabIndex = 4;
			this.label15.Text = "Palette Height:";
			// 
			// paletteWidthNum
			// 
			this.paletteWidthNum.Location = new System.Drawing.Point(254, 66);
			this.paletteWidthNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.paletteWidthNum.Name = "paletteWidthNum";
			this.paletteWidthNum.Size = new System.Drawing.Size(36, 20);
			this.paletteWidthNum.TabIndex = 3;
			this.paletteWidthNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(166, 69);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 13);
			this.label14.TabIndex = 2;
			this.label14.Text = "Palette Width:";
			// 
			// listFonts
			// 
			this.listFonts.FormattingEnabled = true;
			this.listFonts.Location = new System.Drawing.Point(10, 36);
			this.listFonts.Name = "listFonts";
			this.listFonts.Size = new System.Drawing.Size(142, 95);
			this.listFonts.TabIndex = 1;
			this.listFonts.SelectedIndexChanged += new System.EventHandler(this.listFonts_SelectedIndexChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(33, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Fonts";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(448, 167);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 42);
			this.btnClear.TabIndex = 24;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			// 
			// btnCopyHyperText
			// 
			this.btnCopyHyperText.Location = new System.Drawing.Point(533, 168);
			this.btnCopyHyperText.Name = "btnCopyHyperText";
			this.btnCopyHyperText.Size = new System.Drawing.Size(75, 41);
			this.btnCopyHyperText.TabIndex = 28;
			this.btnCopyHyperText.Text = "Copy HTML Code";
			this.btnCopyHyperText.UseVisualStyleBackColor = true;
			this.btnCopyHyperText.Click += new System.EventHandler(this.btnCopyHyperText_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.lblFathersName);
			this.groupBox4.Controls.Add(this.lblMotherName);
			this.groupBox4.Controls.Add(this.imgMother);
			this.groupBox4.Controls.Add(this.imgFather);
			this.groupBox4.Controls.Add(this.lblMotherID);
			this.groupBox4.Controls.Add(this.lblFatherID);
			this.groupBox4.Controls.Add(this.lblOffspringPrediction);
			this.groupBox4.Controls.Add(this.lblFatherRare);
			this.groupBox4.Controls.Add(this.lblMotherRare);
			this.groupBox4.Location = new System.Drawing.Point(12, 211);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(880, 584);
			this.groupBox4.TabIndex = 29;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Prediction";
			// 
			// lblFathersName
			// 
			this.lblFathersName.BackColor = System.Drawing.Color.Transparent;
			this.lblFathersName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblFathersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFathersName.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblFathersName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFathersName.Location = new System.Drawing.Point(36, 367);
			this.lblFathersName.Name = "lblFathersName";
			this.lblFathersName.Size = new System.Drawing.Size(394, 27);
			this.lblFathersName.TabIndex = 30;
			this.lblFathersName.Text = "Father";
			this.lblFathersName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblMotherName
			// 
			this.lblMotherName.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblMotherName.BackColor = System.Drawing.Color.Transparent;
			this.lblMotherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMotherName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblMotherName.Location = new System.Drawing.Point(430, 367);
			this.lblMotherName.Name = "lblMotherName";
			this.lblMotherName.Size = new System.Drawing.Size(401, 27);
			this.lblMotherName.TabIndex = 31;
			this.lblMotherName.Text = "Mother";
			this.lblMotherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// imgMother
			// 
			this.imgMother.Location = new System.Drawing.Point(439, 19);
			this.imgMother.Name = "imgMother";
			this.imgMother.Size = new System.Drawing.Size(350, 345);
			this.imgMother.TabIndex = 29;
			this.imgMother.TabStop = false;
			// 
			// imgFather
			// 
			this.imgFather.Location = new System.Drawing.Point(77, 19);
			this.imgFather.Name = "imgFather";
			this.imgFather.Size = new System.Drawing.Size(350, 345);
			this.imgFather.TabIndex = 28;
			this.imgFather.TabStop = false;
			// 
			// lblMotherID
			// 
			this.lblMotherID.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.lblMotherID.BackColor = System.Drawing.Color.Transparent;
			this.lblMotherID.ForeColor = System.Drawing.Color.Black;
			this.lblMotherID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblMotherID.Location = new System.Drawing.Point(734, 394);
			this.lblMotherID.Name = "lblMotherID";
			this.lblMotherID.Size = new System.Drawing.Size(100, 17);
			this.lblMotherID.TabIndex = 33;
			this.lblMotherID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFatherID
			// 
			this.lblFatherID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFatherID.BackColor = System.Drawing.Color.Transparent;
			this.lblFatherID.ForeColor = System.Drawing.Color.Black;
			this.lblFatherID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFatherID.Location = new System.Drawing.Point(39, 394);
			this.lblFatherID.Name = "lblFatherID";
			this.lblFatherID.Size = new System.Drawing.Size(95, 17);
			this.lblFatherID.TabIndex = 32;
			this.lblFatherID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblOffspringPrediction
			// 
			this.lblOffspringPrediction.Location = new System.Drawing.Point(103, 394);
			this.lblOffspringPrediction.MinimumSize = new System.Drawing.Size(20, 20);
			this.lblOffspringPrediction.Name = "lblOffspringPrediction";
			this.lblOffspringPrediction.ScrollBarsEnabled = false;
			this.lblOffspringPrediction.Size = new System.Drawing.Size(661, 184);
			this.lblOffspringPrediction.TabIndex = 34;
			// 
			// lblFatherRare
			// 
			this.lblFatherRare.Location = new System.Drawing.Point(39, 411);
			this.lblFatherRare.Name = "lblFatherRare";
			this.lblFatherRare.Size = new System.Drawing.Size(71, 104);
			this.lblFatherRare.TabIndex = 35;
			this.lblFatherRare.Visible = false;
			// 
			// lblMotherRare
			// 
			this.lblMotherRare.Location = new System.Drawing.Point(743, 411);
			this.lblMotherRare.Name = "lblMotherRare";
			this.lblMotherRare.Size = new System.Drawing.Size(88, 104);
			this.lblMotherRare.TabIndex = 36;
			this.lblMotherRare.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lblMotherRare.Visible = false;
			// 
			// Form5
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(904, 809);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.btnCopyHyperText);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form5";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Breeding card image Maker";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.paletteHeightNum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteWidthNum)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgMother)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgFather)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
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
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ListBox listFonts;
		private System.Windows.Forms.ComboBox breedFather;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox breedMother;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.NumericUpDown paletteHeightNum;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown paletteWidthNum;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox chkRarity;
		private System.Windows.Forms.Button btnCopyHyperText;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label lblFathersName;
		private System.Windows.Forms.Label lblMotherName;
		private System.Windows.Forms.PictureBox imgMother;
		private System.Windows.Forms.PictureBox imgFather;
		private System.Windows.Forms.Label lblMotherID;
		private System.Windows.Forms.Label lblFatherID;
		private System.Windows.Forms.WebBrowser lblOffspringPrediction;
		private System.Windows.Forms.Label lblFatherRare;
		private System.Windows.Forms.Label lblMotherRare;
	}
}