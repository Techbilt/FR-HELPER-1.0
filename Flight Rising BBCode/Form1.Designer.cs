namespace Flight_Rising_BBCode
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.rtxtItems = new System.Windows.Forms.RichTextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnGenItems = new System.Windows.Forms.Button();
			this.btnSkins = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnPingList = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dragonBBCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coliDropChallengeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pinkerlockeHelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.breedingStatCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saleStatCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tumblrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flightRisingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblOutput = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.smallBreedingStatCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input:";
			// 
			// rtxtItems
			// 
			this.rtxtItems.Location = new System.Drawing.Point(13, 54);
			this.rtxtItems.Name = "rtxtItems";
			this.rtxtItems.Size = new System.Drawing.Size(159, 171);
			this.rtxtItems.TabIndex = 1;
			this.rtxtItems.Text = "";
			this.toolTip1.SetToolTip(this.rtxtItems, "Enter each item one line at a time");
			// 
			// btnGenItems
			// 
			this.btnGenItems.Location = new System.Drawing.Point(178, 54);
			this.btnGenItems.Name = "btnGenItems";
			this.btnGenItems.Size = new System.Drawing.Size(75, 23);
			this.btnGenItems.TabIndex = 2;
			this.btnGenItems.Text = "Items";
			this.toolTip1.SetToolTip(this.btnGenItems, "Click to generate bbCode for Items.");
			this.btnGenItems.UseVisualStyleBackColor = true;
			this.btnGenItems.Click += new System.EventHandler(this.btnGenItems_Click);
			// 
			// btnSkins
			// 
			this.btnSkins.Location = new System.Drawing.Point(179, 84);
			this.btnSkins.Name = "btnSkins";
			this.btnSkins.Size = new System.Drawing.Size(75, 23);
			this.btnSkins.TabIndex = 3;
			this.btnSkins.Text = "Skins";
			this.toolTip1.SetToolTip(this.btnSkins, "Click to generate bbCode for skins and Accents");
			this.btnSkins.UseVisualStyleBackColor = true;
			this.btnSkins.Click += new System.EventHandler(this.btnSkins_Click);
			// 
			// btnUser
			// 
			this.btnUser.Location = new System.Drawing.Point(178, 113);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(75, 23);
			this.btnUser.TabIndex = 4;
			this.btnUser.Text = "User";
			this.toolTip1.SetToolTip(this.btnUser, "Generates code to display the user via BBCode");
			this.btnUser.UseVisualStyleBackColor = true;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnPingList
			// 
			this.btnPingList.Location = new System.Drawing.Point(178, 143);
			this.btnPingList.Name = "btnPingList";
			this.btnPingList.Size = new System.Drawing.Size(75, 23);
			this.btnPingList.TabIndex = 5;
			this.btnPingList.Text = "Ping List";
			this.toolTip1.SetToolTip(this.btnPingList, "Click this to generate a ping list");
			this.btnPingList.UseVisualStyleBackColor = true;
			this.btnPingList.Click += new System.EventHandler(this.btnPingList_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(179, 202);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.toolTip1.SetToolTip(this.btnClear, "Click this to clear the form.");
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Location = new System.Drawing.Point(179, 173);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(75, 23);
			this.btnCopy.TabIndex = 9;
			this.btnCopy.Text = "Copy Code";
			this.toolTip1.SetToolTip(this.btnCopy, "Click this to copy the code in the output section");
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.infoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(553, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dragonBBCodeToolStripMenuItem,
            this.coliDropChallengeToolStripMenuItem,
            this.pinkerlockeHelperToolStripMenuItem,
            this.statCardsToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// dragonBBCodeToolStripMenuItem
			// 
			this.dragonBBCodeToolStripMenuItem.Name = "dragonBBCodeToolStripMenuItem";
			this.dragonBBCodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.dragonBBCodeToolStripMenuItem.Text = "Dragon BBCode";
			this.dragonBBCodeToolStripMenuItem.Click += new System.EventHandler(this.dragonBBCodeToolStripMenuItem_Click);
			// 
			// coliDropChallengeToolStripMenuItem
			// 
			this.coliDropChallengeToolStripMenuItem.Name = "coliDropChallengeToolStripMenuItem";
			this.coliDropChallengeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.coliDropChallengeToolStripMenuItem.Text = "Coli Drop Challenge";
			this.coliDropChallengeToolStripMenuItem.Click += new System.EventHandler(this.coliDropChallengeToolStripMenuItem_Click);
			// 
			// pinkerlockeHelperToolStripMenuItem
			// 
			this.pinkerlockeHelperToolStripMenuItem.Name = "pinkerlockeHelperToolStripMenuItem";
			this.pinkerlockeHelperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pinkerlockeHelperToolStripMenuItem.Text = "Pinkerlocke Helper";
			this.pinkerlockeHelperToolStripMenuItem.Click += new System.EventHandler(this.pinkerlockeHelperToolStripMenuItem_Click);
			// 
			// statCardsToolStripMenuItem
			// 
			this.statCardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breedingStatCardsToolStripMenuItem,
            this.smallBreedingStatCardToolStripMenuItem,
            this.saleStatCardToolStripMenuItem});
			this.statCardsToolStripMenuItem.Name = "statCardsToolStripMenuItem";
			this.statCardsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.statCardsToolStripMenuItem.Text = "Stat Cards";
			// 
			// breedingStatCardsToolStripMenuItem
			// 
			this.breedingStatCardsToolStripMenuItem.Name = "breedingStatCardsToolStripMenuItem";
			this.breedingStatCardsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.breedingStatCardsToolStripMenuItem.Text = "Breeding Stat Card";
			this.breedingStatCardsToolStripMenuItem.Click += new System.EventHandler(this.breedingStatCardsToolStripMenuItem_Click);
			// 
			// saleStatCardToolStripMenuItem
			// 
			this.saleStatCardToolStripMenuItem.Name = "saleStatCardToolStripMenuItem";
			this.saleStatCardToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.saleStatCardToolStripMenuItem.Text = "Sale Stat Card";
			this.saleStatCardToolStripMenuItem.Click += new System.EventHandler(this.saleStatCardToolStripMenuItem_Click);
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.creditToolStripMenuItem});
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.infoToolStripMenuItem.Text = "Info";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tumblrToolStripMenuItem,
            this.flightRisingToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.helpToolStripMenuItem.Text = "Report a Bug";
			// 
			// tumblrToolStripMenuItem
			// 
			this.tumblrToolStripMenuItem.Name = "tumblrToolStripMenuItem";
			this.tumblrToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.tumblrToolStripMenuItem.Text = "Tumblr";
			this.tumblrToolStripMenuItem.Click += new System.EventHandler(this.tumblrToolStripMenuItem_Click);
			// 
			// flightRisingToolStripMenuItem
			// 
			this.flightRisingToolStripMenuItem.Name = "flightRisingToolStripMenuItem";
			this.flightRisingToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.flightRisingToolStripMenuItem.Text = "Flight Rising";
			this.flightRisingToolStripMenuItem.Click += new System.EventHandler(this.flightRisingToolStripMenuItem_Click);
			// 
			// creditToolStripMenuItem
			// 
			this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
			this.creditToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
			this.creditToolStripMenuItem.Text = "Credit";
			this.creditToolStripMenuItem.Click += new System.EventHandler(this.creditToolStripMenuItem_Click);
			// 
			// lblOutput
			// 
			this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblOutput.Location = new System.Drawing.Point(260, 54);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(281, 171);
			this.lblOutput.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(257, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "BBCode:";
			// 
			// smallBreedingStatCardToolStripMenuItem
			// 
			this.smallBreedingStatCardToolStripMenuItem.Name = "smallBreedingStatCardToolStripMenuItem";
			this.smallBreedingStatCardToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
			this.smallBreedingStatCardToolStripMenuItem.Text = "Small Breeding Stat Card";
			this.smallBreedingStatCardToolStripMenuItem.Click += new System.EventHandler(this.smallBreedingStatCardToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(553, 244);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnPingList);
			this.Controls.Add(this.btnUser);
			this.Controls.Add(this.btnSkins);
			this.Controls.Add(this.btnGenItems);
			this.Controls.Add(this.rtxtItems);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "BBCode helper ";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtxtItems;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button btnGenItems;
		private System.Windows.Forms.Button btnSkins;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnPingList;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dragonBBCodeToolStripMenuItem;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem coliDropChallengeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pinkerlockeHelperToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statCardsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem breedingStatCardsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saleStatCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tumblrToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flightRisingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem smallBreedingStatCardToolStripMenuItem;
	}
}

