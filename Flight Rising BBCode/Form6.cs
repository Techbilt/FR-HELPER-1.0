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
	public partial class Form6 : Form
	{
		Dragon dreg = new Dragon();
		public Form6()
		{
			InitializeComponent();

			PopulateGender();

			PopulateFlight();

			populateEyeType();

			populateColor();

			populateBreeds();
		}

		private void populateBreeds()
		{
			string[,] breeds = dreg.CreateBreedList();

			//Array.Sort(breeds);

			for (int i = 0; i < breeds.Length / 2; i++)
			{
				comboBreed.Items.Add(breeds[i, 0]);				
			}
		}

		private void populateColor()
		{
			string[,] Color = dreg.CreateColorArray();

			for (int i = 0; i < Color.Length/2; i++)
			{
				comboPrimaryColor.Items.Add(Color[i, 0]);
				comboSecondaryColor.Items.Add(Color[i, 0]);
				comboTertColor.Items.Add(Color[i, 0]);
			}


		}

		private void populateEyeType()
		{
			string[] eyeTypes = dreg.CreateEyeTypeList();

			for (int i = 0; i < eyeTypes.Length; i++)
			{
				comboEyeType.Items.Add(eyeTypes[i]);
			}
		}

		private void PopulateFlight()
		{
			string[] flight = dreg.CreateFlightList();

			for (int i = 0; i < flight.Length; i++)
			{
				comboFlight.Items.Add(flight[i]);
			}
		}

		private void PopulateGender()
		{
			string[] gender = dreg.CreateGenderList();

			for (int i = 0; i < gender.Length; i++)
			{
				comboGender.Items.Add(gender[i]);
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			// Assign infor to Dragon 
			Dragon liveStock = AssignInfoToDragon();

			

			generateCode(liveStock);
		}

		private void generateCode(Dragon liveStock)
		{
			string code = "";

			code = GetMainCode(liveStock);

			lblCode.Text = code;
		}

		private string GetMainCode(Dragon liveStock)
		{
			// Get full list of Breeds, Primary, Secondary, and Tertiary Genes.
			string[,] breeds = dreg.CreateBreedList();
			string[,] pGenes = dreg.CreatePrimaryGeneList(liveStock.breed);
			string[,] sGenes = dreg.CreateSecondaryGeneList(liveStock.breed);
			string[,] tGenes = dreg.CreateTertGeneList(liveStock.breed);

			string code = "";


			if (chkReverseInfo.Checked)
			{
				code = "[columns][center][size=4]" +'\n' + '\n' + '\n' + '\n' + '\n' + "[b]" + liveStock.name + "[/b][/size]" + '\n' +
					DetermineIfShowNumber(liveStock.id) + 
					 "[img]https://flightrising.com/images/icons/small_" + liveStock.Gender.ToLower() + ".png[/img]" + '\n' + '\n' +
					"[b]" + liveStock.breed + "[/b] " + DetermineIfShowRarity(liveStock.breed, breeds) + '\n' +
					"[size=3][b]Primary [/b]" + liveStock.PrimeColor + " " + liveStock.primeGene + " " + DetermineIfShowRarity(liveStock.primeGene, pGenes) + '\n' +
					"[b]Secondary [/b] " + liveStock.SecondColor + " " + liveStock.SecondGene + " " + DetermineIfShowRarity(liveStock.SecondGene, sGenes) + '\n' +
					"[b]Tertiary [/b]" + liveStock.tertColor + " " + liveStock.tertGene + " " + DetermineIfShowRarity(liveStock.tertGene, tGenes) + '\n' +
					"[b]Eye Type [/b] [emoji=" + liveStock.flight + " rune size=1] " + liveStock.eyeType + '\n' + 
					DetermineIfShowLevel() +
					DetermineIfShowTreasure() +
					DetermineIfShowGems() +
					"[/center][nextcol][url=https://flightrising.com/main.php?dragon=" + liveStock.id + "][img]" + liveStock.ImgURL("350", liveStock.batchnum, liveStock.id, "_350.png") + "[/img][/url][/columns]";
			}
			else
			{
				code = "[columns][url=https://flightrising.com/main.php?dragon=" + liveStock.id + "][img]" + liveStock.ImgURL("350", liveStock.batchnum, liveStock.id, "_350.png") + "[/img][/url]" +
					"[nextcol][center][size=4]" + '\n' + '\n' + '\n' + '\n' + '\n' + "[b]" + liveStock.name + "[/b][/size]" + '\n' +
					DetermineIfShowNumber(liveStock.id) + 
					 "[img]https://flightrising.com/images/icons/small_" + liveStock.Gender.ToLower() + ".png[/img]" + '\n' + '\n' +
					"[b]" + liveStock.breed + "[/b] " + DetermineIfShowRarity(liveStock.breed, breeds) + '\n' +
					"[size=3][b]Primary [/b]" + liveStock.PrimeColor + " " + liveStock.primeGene + " " + DetermineIfShowRarity(liveStock.primeGene, pGenes) + '\n' +
					"[b]Secondary [/b] " + liveStock.SecondColor + " " + liveStock.SecondGene + " " + DetermineIfShowRarity(liveStock.SecondGene, sGenes) + '\n' +
					"[b]Tertiary [/b]" + liveStock.tertColor + " " + liveStock.tertGene + " " + DetermineIfShowRarity(liveStock.tertGene, tGenes) + '\n' +
					"[b]Eye Type [/b] [emoji=" + liveStock.flight + " rune size=1] " + liveStock.eyeType + '\n' +
					DetermineIfShowLevel() +
					DetermineIfShowTreasure() +
					DetermineIfShowGems() +
					"[/center][/columns]";
			}

			return code;
		}

		private string DetermineIfShowNumber(string id)
		{
			if (chkNum.Checked)
				return "[size=2]#" + id + "[/size]" + '\n';
			else
				return "";
		}

		private string DetermineIfShowLevel()
		{
			if (chkColiLevel.Checked && numColiLevel.Value > 0)
			{
				return "[emoji=coliseum team size=1] " + numColiLevel.Value.ToString() + '\n' + '\n';
			}
			else
				return Environment.NewLine;
		}

		private string DetermineIfShowGems()
		{
			if (numDimondSale.Value > 0)
			{
				return "[img]https://www1.flightrising.com/static/layout/icon_gems.png[/img]" + numDimondSale.Value.ToString();
			}
			else
				return "";
		}

		private string DetermineIfShowTreasure()
		{
			if (numTreasureSale.Value > 0)
			{
				return "[img]https://www1.flightrising.com/static/layout/icon_treasure.png[/img]" + numTreasureSale.Value.ToString() + '\n';
			}
			else
				return "";
		}

		private string DetermineIfShowRarity(string primeGene, string[,] pGenes)
		{
			if (chkShowRare.Checked)
			{
				return "[i]" + FindRarity(primeGene, pGenes) + "[/i]";
			}
			else
				return "";
		}

		private string FindRarity(string breed1, string[,] BreedArray)
		{
			string rarity = "Something is missin'";

			for (int i = 0; i < BreedArray.Length / 2; i++)
			{
				if (breed1 == BreedArray[i, 0])
				{
					rarity = BreedArray[i, 1];

					break;
				}
			}

			return rarity;
		}

		private Dragon AssignInfoToDragon()
		{
			Dragon dragon = new Dragon();

			dragon.name = txtName.Text;
			dragon.id = txtDragonId.Text;
			dragon.batchnum = dreg.FindBatchNum(txtDragonId.Text).ToString();
			dragon.breed = comboBreed.SelectedItem.ToString();
			dragon.Gender = comboGender.SelectedItem.ToString();
			dragon.coliLevel = numColiLevel.Value.ToString();
			dragon.flight = comboFlight.SelectedItem.ToString();
			dragon.eyeType = comboEyeType.SelectedItem.ToString();
			dragon.PrimeColor = comboPrimaryColor.SelectedItem.ToString();
			dragon.primeGene = comboPrimaryGene.SelectedItem.ToString();
			dragon.SecondColor = comboSecondaryColor.SelectedItem.ToString();
			dragon.SecondGene = comboSecondaryGene.SelectedItem.ToString();
			dragon.tertColor = comboTertColor.SelectedItem.ToString();
			dragon.tertGene = comboTertGene.SelectedItem.ToString();

			return dragon;
		}

		private void comboBreed_SelectedIndexChanged(object sender, EventArgs e)
		{
			populateGenes();
		}

		private void populateGenes()
		{
			comboPrimaryGene.Items.Clear();
			comboSecondaryGene.Items.Clear();
			comboTertGene.Items.Clear();

			string breed = comboBreed.SelectedItem.ToString();

			string[,] pGenes = dreg.CreatePrimaryGeneList(breed);
			string[,] sGenes = dreg.CreateSecondaryGeneList(breed);
			string[,] tGenes = dreg.CreateTertGeneList(breed);

			for (int i = 0; i < pGenes.Length/2; i++)
			{
				comboPrimaryGene.Items.Add(pGenes[i, 0]);
			}
			for (int i = 0; i < sGenes.Length / 2; i++)
			{
				comboSecondaryGene.Items.Add(sGenes[i, 0]);
			}
			for (int i = 0; i < tGenes.Length / 2; i++)
			{
				comboTertGene.Items.Add(tGenes[i, 0]);
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(lblCode.Text);
		}
	}
}
