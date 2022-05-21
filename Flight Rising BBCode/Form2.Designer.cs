namespace Flight_Rising_BBCode
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAvatar = new System.Windows.Forms.Button();
			this.btnSmall = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.btnLarge = new System.Windows.Forms.Button();
			this.chkURL = new System.Windows.Forms.CheckBox();
			this.lblCode = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtDragonID = new System.Windows.Forms.TextBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Code:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Dragon Number";
			// 
			// btnAvatar
			// 
			this.btnAvatar.Location = new System.Drawing.Point(246, 62);
			this.btnAvatar.Name = "btnAvatar";
			this.btnAvatar.Size = new System.Drawing.Size(75, 23);
			this.btnAvatar.TabIndex = 4;
			this.btnAvatar.Text = "Avatar";
			this.toolTip1.SetToolTip(this.btnAvatar, "Generate Code for an avatar image of a dragon");
			this.btnAvatar.UseVisualStyleBackColor = true;
			this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
			// 
			// btnSmall
			// 
			this.btnSmall.Location = new System.Drawing.Point(246, 88);
			this.btnSmall.Name = "btnSmall";
			this.btnSmall.Size = new System.Drawing.Size(75, 23);
			this.btnSmall.TabIndex = 5;
			this.btnSmall.Text = "Small";
			this.toolTip1.SetToolTip(this.btnSmall, "Generate a small image of a Dragon");
			this.btnSmall.UseVisualStyleBackColor = true;
			this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(246, 145);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 6;
			this.btnCopy.Text = "Copy";
			this.toolTip1.SetToolTip(this.btnCopy, "Copy Code");
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnLarge
			// 
			this.btnLarge.Location = new System.Drawing.Point(246, 116);
			this.btnLarge.Name = "btnLarge";
			this.btnLarge.Size = new System.Drawing.Size(75, 23);
			this.btnLarge.TabIndex = 7;
			this.btnLarge.Text = "Large";
			this.toolTip1.SetToolTip(this.btnLarge, "Generate a large image of a Dragon");
			this.btnLarge.UseVisualStyleBackColor = true;
			this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
			// 
			// chkURL
			// 
			this.chkURL.AutoSize = true;
			this.chkURL.Location = new System.Drawing.Point(234, 5);
			this.chkURL.Name = "chkURL";
			this.chkURL.Size = new System.Drawing.Size(86, 17);
			this.chkURL.TabIndex = 8;
			this.chkURL.Text = "Include URL";
			this.toolTip1.SetToolTip(this.chkURL, "check to include the URL in with the dragons image");
			this.chkURL.UseVisualStyleBackColor = true;
			// 
			// lblCode
			// 
			this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCode.Location = new System.Drawing.Point(12, 62);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(228, 135);
			this.lblCode.TabIndex = 9;
			// 
			// txtDragonID
			// 
			this.txtDragonID.Location = new System.Drawing.Point(13, 26);
			this.txtDragonID.Name = "txtDragonID";
			this.txtDragonID.Size = new System.Drawing.Size(308, 20);
			this.txtDragonID.TabIndex = 10;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(246, 174);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(332, 213);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.txtDragonID);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.chkURL);
			this.Controls.Add(this.btnLarge);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnSmall);
			this.Controls.Add(this.btnAvatar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Dragon image Code";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAvatar;
		private System.Windows.Forms.Button btnSmall;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnLarge;
		private System.Windows.Forms.CheckBox chkURL;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.TextBox txtDragonID;
		private System.Windows.Forms.Button btnClear;
	}
}