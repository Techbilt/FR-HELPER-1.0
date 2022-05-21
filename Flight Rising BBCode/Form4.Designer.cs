namespace Flight_Rising_BBCode
{
	partial class Form4
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
			this.label1 = new System.Windows.Forms.Label();
			this.PinkertonItemCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.battleCount = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.lblProtocol = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.numEggs = new System.Windows.Forms.NumericUpDown();
			this.btnHatch = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.btnCopy = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.rdoOGRules = new System.Windows.Forms.RadioButton();
			this.rdoTechbiltsRules = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.battleCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numEggs)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(111, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pinkerton gave you a:";
			// 
			// PinkertonItemCombo
			// 
			this.PinkertonItemCombo.FormattingEnabled = true;
			this.PinkertonItemCombo.Items.AddRange(new object[] {
            "Apparel",
            "Battle Item",
            "Dragonmade",
            "Familiar",
            "Insect",
            "Meat",
            "Minerals & Ore",
            "Organic",
            "Plant",
            "Seafood",
            "Trinkets"});
			this.PinkertonItemCombo.Location = new System.Drawing.Point(130, 10);
			this.PinkertonItemCombo.Name = "PinkertonItemCombo";
			this.PinkertonItemCombo.Size = new System.Drawing.Size(132, 21);
			this.PinkertonItemCombo.Sorted = true;
			this.PinkertonItemCombo.TabIndex = 1;
			this.PinkertonItemCombo.SelectedIndexChanged += new System.EventHandler(this.PinkertonItemCombo_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Battle Count:";
			// 
			// battleCount
			// 
			this.battleCount.Location = new System.Drawing.Point(132, 41);
			this.battleCount.Name = "battleCount";
			this.battleCount.Size = new System.Drawing.Size(33, 20);
			this.battleCount.TabIndex = 3;
			this.battleCount.ValueChanged += new System.EventHandler(this.battleCount_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Instructions:";
			// 
			// lblProtocol
			// 
			this.lblProtocol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProtocol.Location = new System.Drawing.Point(16, 166);
			this.lblProtocol.Name = "lblProtocol";
			this.lblProtocol.Size = new System.Drawing.Size(246, 184);
			this.lblProtocol.TabIndex = 5;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(17, 127);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(249, 23);
			this.progressBar1.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 361);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Total Number of Eggs:";
			// 
			// numEggs
			// 
			this.numEggs.Location = new System.Drawing.Point(138, 359);
			this.numEggs.Name = "numEggs";
			this.numEggs.Size = new System.Drawing.Size(35, 20);
			this.numEggs.TabIndex = 8;
			// 
			// btnHatch
			// 
			this.btnHatch.Location = new System.Drawing.Point(180, 359);
			this.btnHatch.Name = "btnHatch";
			this.btnHatch.Size = new System.Drawing.Size(75, 23);
			this.btnHatch.TabIndex = 9;
			this.btnHatch.Text = "Hatched";
			this.btnHatch.UseVisualStyleBackColor = true;
			this.btnHatch.Click += new System.EventHandler(this.btnHatch_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(63, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Item Given:";
			// 
			// txtItem
			// 
			this.txtItem.Location = new System.Drawing.Point(130, 72);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(132, 20);
			this.txtItem.TabIndex = 11;
			this.txtItem.Leave += new System.EventHandler(this.txtItem_Leave);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(94, 385);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 12;
			this.btnCopy.Text = "Copy";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Visible = false;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Rules:";
			// 
			// rdoOGRules
			// 
			this.rdoOGRules.AutoSize = true;
			this.rdoOGRules.Checked = true;
			this.rdoOGRules.Location = new System.Drawing.Point(56, 98);
			this.rdoOGRules.Name = "rdoOGRules";
			this.rdoOGRules.Size = new System.Drawing.Size(60, 17);
			this.rdoOGRules.TabIndex = 14;
			this.rdoOGRules.TabStop = true;
			this.rdoOGRules.Text = "Original";
			this.rdoOGRules.UseVisualStyleBackColor = true;
			// 
			// rdoTechbiltsRules
			// 
			this.rdoTechbiltsRules.AutoSize = true;
			this.rdoTechbiltsRules.Location = new System.Drawing.Point(194, 98);
			this.rdoTechbiltsRules.Name = "rdoTechbiltsRules";
			this.rdoTechbiltsRules.Size = new System.Drawing.Size(68, 17);
			this.rdoTechbiltsRules.TabIndex = 15;
			this.rdoTechbiltsRules.Text = "Techbilts";
			this.rdoTechbiltsRules.UseVisualStyleBackColor = true;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 420);
			this.Controls.Add(this.rdoTechbiltsRules);
			this.Controls.Add(this.rdoOGRules);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.txtItem);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnHatch);
			this.Controls.Add(this.numEggs);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lblProtocol);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.battleCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PinkertonItemCombo);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form4";
			this.Text = "Pinkerlocke Helper";
			((System.ComponentModel.ISupportInitialize)(this.battleCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numEggs)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox PinkertonItemCombo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown battleCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblProtocol;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numEggs;
		private System.Windows.Forms.Button btnHatch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rdoOGRules;
		private System.Windows.Forms.RadioButton rdoTechbiltsRules;
	}
}