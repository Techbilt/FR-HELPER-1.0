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
	public partial class Form7 : Form
	{
		Dragon dreg = new Dragon();
		public Form7()
		{
			InitializeComponent();

			ShowColors(); //Show the colors available for the dragons

			ShowBreeds(); //show All the breeds currently Available

			lblOffspringPrediction.DocumentText = "<body style=\"background-color:#f0f0f0;\"></body>";

			showPrimeGene("None", "None");

			showSecondaryGene("None", "None");

			showTertGenes("None", "None");
		}
		private void showTertGenes(string typeDad, string typeMom)
		{
			tertGeneFather.Items.Clear();
			tertGeneMother.Items.Clear();

			string[,] tertGeneListFather = dreg.CreateTertGeneList(typeDad);
			string[,] tertGeneListMother = dreg.CreateTertGeneList(typeMom);

			for (int i = 0; i < tertGeneListFather.Length / 2; i++)
			{
				tertGeneFather.Items.Add(tertGeneListFather[i, 0]);
				tertGeneMother.Items.Add(tertGeneListMother[i, 0]);
			}
		}

		private void showSecondaryGene(string typeDad, string typeMom)
		{
			secondaryGeneFather.Items.Clear();
			secondaryGeneMother.Items.Clear();

			string[,] secondaryGeneDad = dreg.CreateSecondaryGeneList(typeDad);
			string[,] secondaryGeneMom = dreg.CreateSecondaryGeneList(typeMom);

			for (int i = 0; i < secondaryGeneDad.Length / 2; i++)
			{
				secondaryGeneFather.Items.Add(secondaryGeneDad[i, 0]);
				secondaryGeneMother.Items.Add(secondaryGeneMom[i, 0]);
			}
		}

		private void showPrimeGene(string typeDad, string typeMom)
		{
			primaryGeneFather.Items.Clear();
			primaryGeneMother.Items.Clear();

			string[,] PrimeGene = dreg.CreatePrimaryGeneList(typeDad);
			string[,] PrimeGene2 = dreg.CreatePrimaryGeneList(typeMom);

			for (int i = 0; i < PrimeGene.Length / 2; i++)
			{
				primaryGeneFather.Items.Add(PrimeGene[i, 0]);
				primaryGeneMother.Items.Add(PrimeGene2[i, 0]);
			}
		}

		private void ShowBreeds()
		{
			string[,] breeds = dreg.CreateBreedList();


			for (int i = 0; i < breeds.Length / 2; i++)
			{
				breedFather.Items.Add(breeds[i, 0]);
				breedMother.Items.Add(breeds[i, 0]);
			}
		}

		private void ShowColors()
		{
			string[,] colors = dreg.CreateColorArray();

			for (int i = 0; i < colors.Length / 2; i++)
			{
				primaryColorFather.Items.Add(colors[i, 0]);
				secondaryColorFather.Items.Add(colors[i, 0]);
				tertColorFather.Items.Add(colors[i, 0]);
				primaryColorMother.Items.Add(colors[i, 0]);
				secondaryColorMother.Items.Add(colors[i, 0]);
				tertColorMother.Items.Add(colors[i, 0]);
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			if (fatherID.Text != "")
			{
				string FatherImg = GenerateImages(fatherID.Text);
				picFathersAvatar.ImageLocation = FatherImg;
			}
			if (txtMotherID.Text != "")
			{
				string MotherImg =  GenerateImages(txtMotherID.Text);
				picMotherAvatar.ImageLocation = MotherImg;
			}

			/*if (txtFatherName.Text != "")
				lblFathersName.Text = txtFatherName.Text;
			if (txtMotherName.Text != "")
				string mothersName = txtMotherName.Text;*/

			Dragon Carrier = new Dragon();
			Dragon Sire = new Dragon();

			Carrier = SetDragonMom(Carrier);
			Sire = SetDragonDad(Sire);

			lblFathersInfo.Text = Sire.name + Environment.NewLine + "#" + Sire.id;
			lblMotherInfo.Text = Carrier.name + Environment.NewLine + "#" + Carrier.id;

			/*lblMotherID.Text = GenerateResult(Carrier);
			lblFatherID.Text = GenerateResult(Sire);*/

			lblOffspringPrediction.DocumentText = GetHatchlingInfo(Carrier, Sire);
		}

		private string GetHatchlingInfo(Dragon carrier, Dragon sire)
		{
			string hatchlings = "<head><style>.wrapper {position: relative; margin:0px; text-align:center; width: 700px;}" + Environment.NewLine +
					".center-div {position: relative; width: 602px; margin:0px; border-radius: 3px; position: relative; text-align:center; display:inline; width:6px; height:8px; background-color:#888;} </style>" + Environment.NewLine +
					"</head><body style=\"background-color:#f0f0f0;font-size:10px;\"><center><div class=\"wrapper\">" + breedPercentage(sire.breed, carrier.breed) + "<br>" +
					primePercentageSet(sire.primeGene, carrier.primeGene, sire.breed) + "<br>" +
					GetColors(sire.PrimeColor, carrier.PrimeColor) + "<br>" +
					secondPercentageSet(sire.SecondGene, carrier.SecondGene, sire.breed) + "<br>" +
					GetColors(sire.SecondColor, carrier.SecondColor) + "<br>" +
					TertPercentageSet(sire.tertGene, carrier.tertGene, sire.breed) + "<br>" +
					GetColors(sire.tertColor, carrier.tertColor) + "</div></center></tr></table></body>";

			return hatchlings;
		}

		private string GetColors(string Color1, string Color2)
		{
			string[,] colors = dreg.CreateColorArray();
			List<Colors> colorsClockwise = new List<Colors>();
			List<Colors> colorsCounterClockwise = new List<Colors>();
			string result = "";
			int colorIndex1 = 6000;
			int colorIndex2 = 6000;

			if (Color1 == Color2)
			{
				for (int i = 0; i < colors.Length / 2; i++)
				{
					if (colors[i, 0] == Color1)
					{
						Colors Temp = new Colors();
						Temp.Name = colors[i, 0];
						Temp.HexCode = colors[i, 1];

						result = "<div title=\"" + Temp.Name + "\" class=\"center-div\" style=\"background-color:#" + Temp.HexCode + "\";></div> ";
						break;
					}
				}

			}
			else
			{

				for (int i = 0; i < colors.Length / 2; i++)
				{
					if (colors[i, 0] == Color1)
						colorIndex1 = i;
					else if (colors[i, 0] == Color2)
						colorIndex2 = i;

					if (colorIndex1 != 6000 && colorIndex2 != 6000)
						break;

				}


				//find out which index is smaller
				if (colorIndex1 < colorIndex2)
				{
					colorsClockwise = GetClockwiseColors(colorIndex1, colorIndex2, colors);
					colorsCounterClockwise = getColorsCounterClockwise(colorIndex1, colorIndex2, colors);
				}
				else if (colorIndex1 > colorIndex2)
				{
					colorsClockwise = GetClockwiseColors(colorIndex2, colorIndex1, colors);
					colorsCounterClockwise = getColorsCounterClockwise(colorIndex2, colorIndex1, colors);
				}
			}

			if (colorsClockwise.Count < colorsCounterClockwise.Count)
			{
				if (Color1 != colorsClockwise[0].Name)
				{
					colorsClockwise.Reverse();
				}
				result = MakeColorList(colorsClockwise);
			}
			else if (colorsClockwise.Count > colorsCounterClockwise.Count)
			{
				if (Color1 != colorsCounterClockwise[0].Name)
				{
					colorsCounterClockwise.Reverse();
				}
				result = MakeColorList(colorsCounterClockwise);
			}



			return result;

		}

		private string MakeColorList(List<Colors> colors)
		{
			string result = "";
			foreach (Colors color in colors)
			{
				//<div style="background-color: #ff6622; height:10px; width: 5px;"></div> 
				result = result + "<div title=\"" + color.Name + "\" class=\"center-div\" style=\"background-color:#" + color.HexCode + "\";></div> ";
				//result += color.Name + " ";
			}

			return result;
		}

		private List<Colors> getColorsCounterClockwise(int indexSMall, int indexLarge, string[,] colors)
		{
			List<Colors> tempColorList = new List<Colors>();

			for (int i = indexLarge; i < colors.Length / 2; i++)
			{
				Colors tempColor = new Colors();
				tempColor.Name = colors[i, 0];
				tempColor.HexCode = colors[i, 1];

				tempColorList.Add(tempColor);
			}

			for (int i = 0; i < indexSMall +1; i++)
			{
				Colors tempColor = new Colors();
				tempColor.Name = colors[i, 0];
				tempColor.HexCode = colors[i, 1];

				tempColorList.Add(tempColor);
			}



			return tempColorList;
		}

		private List<Colors> GetClockwiseColors(int IndexSmall, int IndexLarge, string[,] colors)
		{
			List<Colors> colorsList = new List<Colors>();


			for (int i = IndexSmall; i <= IndexLarge; i++)
			{
				Colors tempColor = new Colors();
				tempColor.Name = colors[i, 0];
				tempColor.HexCode = colors[i, 1];

				colorsList.Add(tempColor);
			}

			return colorsList;
		}

		private string TertPercentageSet(string breed1, string breed2, string sireBreed)
		{
			// compare breed1 to breed2.
			string[,] CompleteBreedsArray = dreg.CreateTertGeneList(sireBreed);

			string breedTypeDad = FindRarity(breed1, CompleteBreedsArray).ToString().ToLower();
			string breedTypeMom = FindRarity(breed2, CompleteBreedsArray).ToString().ToLower();

			string breedProbability = "";

			//find out if breeds are the same:
			if (breed1 == breed2)
				breedProbability += breed1 + " 100%";
			else
			{
				breedProbability += findPercentage(breed1, breed2, breedTypeDad, breedTypeMom);
			}


			return breedProbability;
		}
		private string secondPercentageSet(string breed1, string breed2, string sireBreed)
		{
			// compare breed1 to breed2.
			string[,] CompleteBreedsArray = dreg.CreateSecondaryGeneList(sireBreed);

			string breedTypeDad = FindRarity(breed1, CompleteBreedsArray).ToString().ToLower();
			string breedTypeMom = FindRarity(breed2, CompleteBreedsArray).ToString().ToLower();

			string breedProbability = "";

			//find out if breeds are the same:
			if (breed1 == breed2)
				breedProbability += breed1 + " 100%";
			else
			{
				breedProbability += findPercentage(breed1, breed2, breedTypeDad, breedTypeMom);
			}


			return breedProbability;
		}

		private string primePercentageSet(string breed1, string breed2, string sireBreed)
		{
			// compare breed1 to breed2.
			string[,] CompleteBreedsArray = dreg.CreatePrimaryGeneList(sireBreed);

			string breedTypeDad = FindRarity(breed1, CompleteBreedsArray).ToString().ToLower();
			string breedTypeMom = FindRarity(breed2, CompleteBreedsArray).ToString().ToLower();

			string breedProbability = "";

			//find out if breeds are the same:
			if (breed1 == breed2)
				breedProbability += breed1 + " 100%";
			else
			{
				breedProbability += findPercentage(breed1, breed2, breedTypeDad, breedTypeMom);
			}


			return breedProbability;
		}

		private string breedPercentage(string breed1, string breed2)
		{
			// compare breed1 to breed2.
			string[,] CompleteBreedsArray = dreg.CreateBreedList();

			string breedTypeDad = FindRarity(breed1, CompleteBreedsArray).ToString().ToLower();
			string breedTypeMom = FindRarity(breed2, CompleteBreedsArray).ToString().ToLower();

			if ((breedTypeDad == "ancient" && breedTypeMom != "ancient" && breed1 != breed2) || (breedTypeMom == "ancient" && breedTypeDad != "ancient" && breed1 != breed2))
				MessageBox.Show("Ancient Dragons can only breed with their own kind, you will not be able to breed  " + breed1 + " and  " + breed2 + " dragons together, sorry.  You will only be able to compare color palettes.");

			string breedProbability = "";

			//find out if breeds are the same:
			if (breed1 == breed2)
				breedProbability += breed1 + " 100%";
			else
			{
				breedProbability += findPercentage(breed1, breed2, breedTypeDad, breedTypeMom);
			}


			return breedProbability;
		}

		private string findPercentage(string breed1, string breed2, string type1, string type2)
		{
			if (type1 == type2)
				return SetPercentages("50%", "50%", breed1, breed2);
			else if (type1 == "plentiful")
			{
				if (type2 == "common")
					return SetPercentages("70%", "30%", breed1, breed2);
				else if (type2 == "uncommon")
					return SetPercentages("85%", "15%", breed1, breed2);
				else if (type2 == "limited")
					return SetPercentages("97%", "3%", breed1, breed2);
				else if (type2 == "rare")
					return SetPercentages("99%", "1%", breed1, breed2);
				else
					return "there has been a problem with Plentifuls";
			}
			else if (type1 == "common")
			{
				if (type2 == "plentiful")
					return SetPercentages("30%", "70%", breed1, breed2);
				else if (type2 == "uncommon")
					return SetPercentages("75%", "25%", breed1, breed2);
				else if (type2 == "limited")
					return SetPercentages("90%", "10%", breed1, breed2);
				else if (type2 == "rare")
					return SetPercentages("99%", "1%", breed1, breed2);
				else
					return "there has been a problem with Commons";
			}
			else if (type1 == "uncommon")
			{
				if (type2 == "plentiful")
					return SetPercentages("15%", "85%", breed1, breed2);
				else if (type2 == "common")
					return SetPercentages("25%", "75%", breed1, breed2);
				else if (type2 == "limited")
					return SetPercentages("85%", "15%", breed1, breed2);
				else if (type2 == "rare")
					return SetPercentages("98%", "2%", breed1, breed2);
				else
					return "there has been a problem with uncommons";
			}
			else if (type1 == "limited")
			{
				if (type2 == "plentiful")
					return SetPercentages("3%", "97%", breed1, breed2);
				else if (type2 == "common")
					return SetPercentages("10%", "90%", breed1, breed2);
				else if (type2 == "uncommon")
					return SetPercentages("15%", "85%", breed1, breed2);
				else if (type2 == "rare")
					return SetPercentages("97%", "3%", breed1, breed2);
				else
					return "there has been a problem with limiteds";
			}
			else if (type1 == "rare")
			{
				if (type2 == "plentiful" || type2 == "common")
					return SetPercentages("1%", "99%", breed1, breed2);
				else if (type2 == "uncommon")
					return SetPercentages("2%", "98%", breed1, breed2);
				else if (type2 == "limited")
					return SetPercentages("3%", "97%", breed1, breed2);
				else
					return "there has been a problwm with rares";
			}
			else
				return "there hsas been a problem with Ancients";
		}

		private string SetPercentages(string v1, string v2, string breed1, string breed2)
		{
			return breed1 + " " + v1 + " | " + v2 + " " + breed2;
		}

		private object FindRarity(string breed1, string[,] BreedArray)
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

		private Dragon SetDragonDad(Dragon sire)
		{
			sire.name = txtFatherName.Text;
			sire.id = fatherID.Text;
			sire.breed = breedFather.SelectedItem.ToString();
			sire.primeGene = primaryGeneFather.SelectedItem.ToString();
			sire.PrimeColor = primaryColorFather.SelectedItem.ToString();
			sire.SecondGene = secondaryGeneFather.SelectedItem.ToString();
			sire.SecondColor = secondaryColorFather.SelectedItem.ToString();
			sire.tertGene = tertGeneFather.SelectedItem.ToString();
			sire.tertColor = tertColorFather.SelectedItem.ToString();

			return sire;
		}

		private Dragon SetDragonMom(Dragon Carrier)
		{
			Carrier.name = txtMotherName.Text;
			Carrier.id = txtMotherID.Text;
			Carrier.breed = breedMother.SelectedItem.ToString();
			Carrier.primeGene = primaryGeneMother.SelectedItem.ToString();
			Carrier.PrimeColor = primaryColorMother.SelectedItem.ToString();
			Carrier.SecondGene = secondaryGeneMother.SelectedItem.ToString();
			Carrier.SecondColor = secondaryColorMother.SelectedItem.ToString();
			Carrier.tertGene = tertGeneMother.SelectedItem.ToString();
			Carrier.tertColor = tertColorMother.SelectedItem.ToString();

			return Carrier;
		}

		private string GenerateImages(string ID)
		{
			string id = ID.Trim(' ');

			string batchNum = dreg.FindBatchNum(id).ToString();

			return dreg.ImgURL("portraits", batchNum, id, "p.png");
		}

		private void breedFather_SelectedIndexChanged(object sender, EventArgs e)
		{
			populateFatherGenes();
		}

		private void populateFatherGenes()
		{
			primaryGeneFather.Items.Clear();
			secondaryGeneFather.Items.Clear();
			tertGeneFather.Items.Clear();

			string breed = breedFather.SelectedItem.ToString();

			string[,] pGenes = dreg.CreatePrimaryGeneList(breed);
			string[,] sGenes = dreg.CreateSecondaryGeneList(breed);
			string[,] tGenes = dreg.CreateTertGeneList(breed);

			for (int i = 0; i < pGenes.Length / 2; i++)
			{
				primaryGeneFather.Items.Add(pGenes[i, 0]);
			}
			for (int i = 0; i < sGenes.Length / 2; i++)
			{
				secondaryGeneFather.Items.Add(sGenes[i, 0]);
			}
			for (int i = 0; i < tGenes.Length / 2; i++)
			{
				tertGeneFather.Items.Add(tGenes[i, 0]);
			}
		}

		private void breedMother_SelectedIndexChanged(object sender, EventArgs e)
		{
			primaryGeneMother.Items.Clear();
			secondaryGeneMother.Items.Clear();
			tertGeneMother.Items.Clear();

			string breed = breedFather.SelectedItem.ToString();

			string[,] pGenes = dreg.CreatePrimaryGeneList(breed);
			string[,] sGenes = dreg.CreateSecondaryGeneList(breed);
			string[,] tGenes = dreg.CreateTertGeneList(breed);

			for (int i = 0; i < pGenes.Length / 2; i++)
			{
				primaryGeneMother.Items.Add(pGenes[i, 0]);
			}
			for (int i = 0; i < sGenes.Length / 2; i++)
			{
				secondaryGeneMother.Items.Add(sGenes[i, 0]);
			}
			for (int i = 0; i < tGenes.Length / 2; i++)
			{
				tertGeneMother.Items.Add(tGenes[i, 0]);
			}
		}
	}
}
