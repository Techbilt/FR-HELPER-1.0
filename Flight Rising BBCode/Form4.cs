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
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();

			numEggs.Maximum = 5;
		}

		private void PinkertonItemCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			Random Num = new Random();
			battleCount.Value = 0;

			if (PinkertonItemCombo.SelectedItem == "Plant")
				BattleProtocol(10, 20, Num);
			else if (PinkertonItemCombo.SelectedItem == "Insect")
				BattleProtocol(20, 30, Num);
			else if (PinkertonItemCombo.SelectedItem == "Seafood")
				BattleProtocol(30, 40, Num);
			else if (PinkertonItemCombo.SelectedItem == "Meat")
				BattleProtocol(40, 50, Num);
			else if (PinkertonItemCombo.SelectedItem == "Material" || PinkertonItemCombo.SelectedItem == "Dragonmade" || PinkertonItemCombo.SelectedItem == "Minerals & Ore" || PinkertonItemCombo.SelectedItem == "Organic") {
				if (rdoOGRules.Checked)
					Artsy("writing");
				else if (rdoTechbiltsRules.Checked)
				{
					battleCount.Visible = true;
					if (PinkertonItemCombo.SelectedItem == "Dragonmade")
						MaterialProtocol(20);
					else if (PinkertonItemCombo.SelectedItem == "Minerals & Ore")
						MaterialProtocol(40);
					else if (PinkertonItemCombo.SelectedItem == "Organic")
						MaterialProtocol(60);
					else
						MessageBox.Show("There was an Error");
				}
			
			else
				MessageBox.Show("There was an issue");
			}
			else if (PinkertonItemCombo.SelectedItem == "Trinkets") {
				if (rdoOGRules.Checked)
					Artsy("art");
				else if (rdoTechbiltsRules.Checked)
					Artsy("art or wirting");
			}
		
			else if (PinkertonItemCombo.SelectedItem == "Familiar")
					Familiar(Num);
			else if (PinkertonItemCombo.SelectedItem == "Apparel")
					showPrompt("Breed two of your Dragons, you must flip a coin for each hatchling once they hatch.");
			else if (PinkertonItemCombo.SelectedItem == "Battle Item")
					DeathStrike(Num);
			else
					lblProtocol.Text = "there has been an error";
		}

		private void MaterialProtocol(int v)
		{
			progressBar1.Maximum = v;

			showPrompt("Battle " + v.ToString() + " monsters in the Coliseum");
		}

		private void DeathStrike(Random num)
		{
			string[] coin = { "heads", "tails" };
			string prompt = "";

			if (coin[num.Next(coin.Count())] == "heads")
			{
				battleCount.Visible = true;
				battleCount.Maximum = 10;
				progressBar1.Maximum = 10;

				prompt = String.Format("Randomly Select 3 Dragons and fight in the Coliseum for 10 rounds consecutively, quitting mid way if a dragon dies.");
			}
			else
			{
				battleCount.Visible = false;
				prompt = String.Format("Nothing Happens, you lucked out.");

				
			}
			showPrompt(prompt);
		}

		private void Familiar(Random num)
		{
			Dragon drag = new Dragon();
			battleCount.Visible = false;
			List<string> breeds = new List<string>();
			string[,] breeds2D = drag.CreateBreedList();
			string[] Flight = drag.CreateFlightList();


			for (int i = 0; i < breeds2D.Length / 2; i++)
			{
				breeds.Add(breeds2D[i, 0]);
			}

			

			

			string Prompt = String.Format("Buy the Cheapest {0} {1} dragon in the auction house.", Flight[num.Next(Flight.Count())], breeds[num.Next(breeds.Count())]);

			showPrompt(Prompt);

		}

		private void showPrompt(string prompt)
		{
			lblProtocol.Text = prompt;
		}

		private void Artsy(string thing)
		{
			battleCount.Visible = false;

			lblProtocol.Text = "So some " +  thing + " for your Pinkerlocke";
		}

		private void BattleProtocol(int num1, int num2, Random Num)
		{
			battleCount.Visible = true;
			int battle = Num.Next(num1, num2 + 1);

			battleCount.Maximum = battle;
			progressBar1.Maximum = battle;

			lblProtocol.Text = "Coliseum!  Your Dragons need to battle " + battle.ToString() + " matches.";
		}

		private void battleCount_ValueChanged(object sender, EventArgs e)
		{
			int count = Convert.ToInt32(battleCount.Value);

			progressBar1.Value = count;
		}

		private void btnHatch_Click(object sender, EventArgs e)
		{
			Random Num = new Random();

			string[] coin = { "heads", "tails" };

			string prompt = "";

			//get the number of eggs.
			int eggNum = Convert.ToInt32(numEggs.Value);

			for (int i = 1; i < eggNum + 1 ; i++)
			{
				if (coin[Num.Next(coin.Count())] == "heads")
				{
					prompt += String.Format("Hatchling {0} was a good egg!" + '\n', i);
				}
				else
				{
					battleCount.Visible = false;
					prompt += String.Format("Egg {0} was a spoiled egg.  Exalt." + '\n', i);
				}
				showPrompt(prompt);
			}
		}

		private void txtItem_Leave(object sender, EventArgs e)
		{
			if (txtItem.Text != "")
			{
				lblProtocol.Text = "[item=" + txtItem.Text + "]";


				btnCopy.Visible = true;
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblProtocol.Text);
		}
	}
}
