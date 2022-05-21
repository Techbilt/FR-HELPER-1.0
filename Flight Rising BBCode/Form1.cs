using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Rising_BBCode
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGenItems_Click(object sender, EventArgs e)
		{
			string[] items = getListofItems();

			string type = "item=";

			showCode(items, type);

			ClearTextBox();

		}

		private void ClearTextBox()
		{
			rtxtItems.Clear();
		}

		private void showCode(string[] items, string type)
		{
			Array.Sort(items);
			foreach (string thing in items)
				lblOutput.Text += "[" + type + thing + "]";
		}

		private string[] getListofItems()
		{
			return rtxtItems.Text.Split('\n');
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblOutput.Text);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearTextBox();
			lblOutput.Text = "";
		}

		private void btnSkins_Click(object sender, EventArgs e)
		{
			string[] skins = getListofItems();

			string type = "skin=";

			showCode(skins, type);

			ClearTextBox();
		}

		private void btnUser_Click(object sender, EventArgs e)
		{
			string[] users = getListofItems();

			string type = "user=";

			showCode(users, type);

			ClearTextBox();
		}

		private void btnPingList_Click(object sender, EventArgs e)
		{
			string[] users = getListofItems();

			Array.Sort(users);
			foreach (string user in users)
				lblOutput.Text += "@" + user;

			ClearTextBox();
		}

		private void dragonBBCodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 DragonImage = new Form2();

			DragonImage.Show();
		}

		private void coliDropChallengeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 LongDrop = new Form3();

			LongDrop.Show();
		}

		private void pinkerlockeHelperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form4 Pinkerlocke = new Form4();

			Pinkerlocke.Show();
		}

		private void breedingStatCardsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form5 BreedCard = new Form5();

			BreedCard.Show();
		}

		private void saleStatCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form6 SaleCard = new Form6();

			SaleCard.Show();
		}

		private void tumblrToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://techs-dragons.tumblr.com/faq");
		}

		private void flightRisingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www1.flightrising.com/msgs/new?to=techbilt");
		}

		private void creditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This program is completely fan made, and is in no way affiliated with Flight Rising or Stormlight Workshop, LLC.");
		}

		private void smallBreedingStatCardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form7 CompactBreedingCard = new Form7();

			CompactBreedingCard.Show();
		}
	}
}
