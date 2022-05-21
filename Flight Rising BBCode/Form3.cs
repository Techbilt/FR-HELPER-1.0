using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Flight_Rising_BBCode
{
	public partial class Form3 : Form
	{
		List<Level> levels = new List<Level>();
		//make list to act as temp list

		List<Level> grounds = new List<Level>();
		Dragon dragons = new Dragon();
		string coliPath = @"c:\lldc\ColiLongDrop.bin";

		public Form3()
		{
			InitializeComponent();

			//string filePath = Directory.GetCurrentDirectory() + "\\ColiLongDrop.bin";

			if (File.Exists(coliPath))
				levels = ReadBinaryFile(coliPath);
			if (!Directory.Exists(@"c:\lldc\"))
				Directory.CreateDirectory(@"c:\lldc\");
			
		}

		private List<Level> ReadBinaryFile(string fileName)
		{
			//deserialize
			Stream stream = File.Open(fileName, FileMode.Open);
			try
			{
				// Get Current Directory
				string path = Path.GetFullPath(fileName);
				
				var bformatter = new BinaryFormatter();

				List<Level> grounds = (List<Level>)bformatter.Deserialize(stream);
				
				return grounds;
			}
			catch ( SerializationException e)
			{
				MessageBox.Show("Failed to Deserialize LDCC.bin for reason: " + e.Message);
				throw;
			}
			finally
			{
				stream.Close();
			}

		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			Level arena = new Level();
			//get the information and assign it to class info.
			
			arena = GetInfo(arena);

			WriteLevel(arena);
		}

		private void WriteLevel(Level arena)
		{
			//levels.Add(arena);
			int i = 0;

			//boolean to tell if it needs to be added to the list.
			bool exist = false;
            string result = "[center]";

			foreach (Level Venue in levels)
			{
				if (Venue.Arena == arena.Arena)
				{
					DialogResult dialogResult = MessageBox.Show("You have already started in this venue.  Your data will be re-written.  Click Yes to continue.", "Warning", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						levels[i] = GetInfo(arena);

						SaveLevel(coliPath);
					}
					else if (dialogResult == DialogResult.No)
					{
						break;
					}
					exist = true;
					break;
				}
				else
				{
					i++;
					exist = false;
				}
			}

			if (exist == false)
			{
				levels.Add(arena);
				SaveLevel(coliPath);
			}
			if (txtDerg1.Text != "" || txtDerg2.Text != "" || txtDerg3.Text !="")
			{
                if (txtDerg1.Text != "")
                {
                    //MessageBox.Show(arena.HonorableMentions);
                    result += ShowColiTeam(txtDerg1.Text);
                }
                if (txtDerg2.Text != "")
                {
                    result += ShowColiTeam(txtDerg2.Text);
                }
                if (txtDerg3.Text != "")
                {
                    result += ShowColiTeam(txtDerg3.Text);
                }

                result += Environment.NewLine;
			}


			else
			{
				result += "";
			}

			result += "[size=7]" + venueCombo.SelectedItem.ToString() + "[/size]" + Environment.NewLine + " Drop to Collect:" + Environment.NewLine + " [item=" + txtItem.Text + "] " + Environment.NewLine + countItem.Value + "/99" + Environment.NewLine;

			string[] notableItems = GetListOfItems();

			showCode(notableItems, result);
		}

		private string ShowColiTeam(string Derg1)
		{
			string result = "";

			string batchNum1 = dragons.FindBatchNum(Derg1).ToString();
			string img1 = dragons.ImgURL("portraits", batchNum1, Derg1, "p.png");
            if (Derg1 == txtDerg1.Text)
            {
                imgDerg1.ImageLocation = img1;
            }
            else if (Derg1 == txtDerg2.Text)
            {
                imgDerg2.ImageLocation = img1;
            }
            else
            {
                imgDerg3.ImageLocation = img1;
            }
			result += SetBBCode(img1, Derg1);

			return result;
		}

		private string SetBBCode(string img, string id)
		{
			string url = dragons.GetURL(id);

			return dragons.WithURL(img, url);
		}

		private void SaveLevel(string fileName)
		{
			// Get Current Directory
			string path = Path.GetFullPath(coliPath);

			//SERIALIZE

			using (Stream stream = File.Open(path, FileMode.Create))
			{
				var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

				bformatter.Serialize(stream, levels);
			}
		}

		private Level GetInfo(Level arena)
		{
			List<string> drags = new List<string>();

			//assign the controls to class properties.
			arena.Arena = venueCombo.SelectedItem.ToString();
			arena.CollectedItem = txtItem.Text;
			arena.ItemNumber = Convert.ToInt32(countItem.Value);
			arena.HonorableMentions = txtNotableItems.Text;
			if (txtDerg1.Text != null)
				drags.Add(txtDerg1.Text);
			if (txtDerg2.Text != null)
				drags.Add(txtDerg2.Text);
			if (txtDerg3.Text != null)
				drags.Add(txtDerg3.Text);
			if (txtDerg1.Text != null || txtDerg2.Text != null || txtDerg3.Text != null)
				arena.dragonTeam = drags;

			return arena;
		}

		private void showCode(string[] items, string result)
		{
            lblCode.Text = "";
            lblCode.Text += result;
			Array.Sort(items);
			foreach (string thing in items)
				lblCode.Text += "[item=" + thing + "]";

			lblCode.Text += "[/center]";
		}

		private string[] GetListOfItems()
		{
			return txtNotableItems.Text.Split('\n');
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblCode.Text);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();			
		}

		private void ClearForm()
		{
			txtItem.Text = "";
			lblCode.Text = "";
			txtNotableItems.Clear();
			countItem.Value = 0;
			txtDerg1.Text = "";
			txtDerg2.Text = "";
			txtDerg3.Text = "";
			imgDerg1.ImageLocation = "";
			imgDerg2.ImageLocation = "";
			imgDerg3.ImageLocation = "";
		}

		private void countItem_ValueChanged(object sender, EventArgs e)
		{
			int count = Convert.ToInt32(countItem.Value);

			progressBar1.Value = count;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
            levels = ReadBinaryFile(coliPath);

			//get the venue name from the user.
			string venue = venueCombo.SelectedItem.ToString();
			Level coliVenue = new Level();

			foreach (Level arena in levels)
			{
				if (arena.Arena == venue)
				{
					coliVenue = arena;
				}
				
			}

			if (coliVenue != null)
			{
				txtItem.Text = coliVenue.CollectedItem;
				txtNotableItems.Text = coliVenue.HonorableMentions;
				countItem.Value = coliVenue.ItemNumber;
				if (coliVenue.dragonTeam != null)
				{
					txtDerg1.Text = coliVenue.dragonTeam[0];
					txtDerg2.Text = coliVenue.dragonTeam[1];
					txtDerg3.Text = coliVenue.dragonTeam[2];
				}
			}
		}

		private void venueCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			ClearForm();
		}
	}
}
