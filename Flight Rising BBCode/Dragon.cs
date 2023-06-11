using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Rising_BBCode
{
	class Dragon
	{
		public string name { get; set; }
		public string id { get; set; }
		public string batchnum { get; set; }
		public string flight { get; set; }
		public string eyeType { get; set; }
		public string breed { get; set; }
		public string breedRare { get; set; }
		public string primeGene { get; set; }
		public string PrimeColor { get; set; }
		public string PrimeRare { get; set; }
		public string SecondGene { get; set; }
		public string SecondColor { get; set; }
		public string SecondRare { get; set; }
		public string tertGene { get; set; }
		public string tertColor { get; set; }
		public string tertRare { get; set; }
		public string coliLevel { get; set; }
		public string Gender { get; set; }


		public int FindBatchNum(string DragonNum)
		{
			//all but the last two digits of the dragon ID rounded up:

			int count = 0;
			string mystery = "";

			
			if ( Convert.ToInt32(DragonNum) > 100)
			{
				while (count <= (DragonNum.Length - 3))
				{
					mystery = mystery + DragonNum[count];
					count++;
				}
			}
			else
			{
				mystery = "0";
			}

			//convert the mystery number into a int
			int number = Convert.ToInt32(mystery);

			// add plus one to the number to make it the batch number
			int batchNum = number + 1;

			return batchNum;
		}


		internal string[,] CreateTertGeneList(string type)  //NEW
		{
			if (type == "Gaoler")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Angler", "Rare"},
					{ "Blossom", "Limited"},
					{ "Braids", "Uncommon"},
					{ "Capsule", "Limited"},
					{ "Contour", "Common"},
					{ "Fans", "Rare"},
					{ "Ghost", "Uncommon"},
					{ "Glimmer", "Rare"},
					{ "Gnarlhorns", "Uncommon"},
					{ "Opal", "Rare"},
					{ "Pinions", "Rare"},
					{ "Ringlets", "Uncommon"},
					{ "Runes", "Limited"},
					{ "Scorpion", "Limited"},
					{ "Shardflank", "Common"},
					{ "Smoke", "Uncommon"},
					{ "Sparkle", "Uncommon"},
					{ "Stained", "Rare"},
					{ "Thylacine", "Common"},
					{ "Underbelly", "Common"},
					{ "Veined", "Limited"},
					{ "Weathered", "Limited"},
					{ "Wintercoat", "Uncommon"}

                };

				return genes;
			}
			else if (type == "Banescale")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Capsule", "Limited"},
					{ "Contour", "Common"},
					{ "Crackle", "Uncommon"},
					{ "Fans", "Rare"},
					{ "Filigree", "Rare"},
					{ "Ghost", "Uncommon"},
					{ "Gliders", "Limited"},
					{ "Glimmer", "Rare"},
					{ "Lace", "Uncommon"},
					{ "Plumage", "Rare"},
					{ "Porcupine", "Limited"},
					{ "Ringlets", "Uncommon"},
					{ "Skeletal", "Limited"},
					{ "Sparkle", "Uncommon"},
					{ "Squiggle", "Limited"},
					{ "Stained", "Rare"},
					{ "Trimmings", "Common"},
					{ "Underbelly", "Common"},
					{ "Wraith", "Rare"},
					{ "Monarch", "Rare"},
					{ "Soap", "Rare"},
					{ "Spines", "Limited"}


                };
				return genes;
			}
			else if (type == "Veilspun")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Angler", "Limited"},
					{ "Beetle", "Limited"},
					{ "Branches", "Limited"},
					{ "Capsule", "Limited"},
					{ "Crackle", "Uncommon"},
					{ "Diaphanous", "Rare"},
					{ "Firefly", "Limited"},
					{ "Flecks", "Uncommon"},
					{ "Glimmer", "Rare"},
					{ "Mop", "Rare"},
					{ "Okapi", "Uncommon"},
					{ "Opal", "Rare"},
					{ "Peacock", "Common"},
					{ "Runes", "Limited"},
					{ "Sparkle", "Uncommon"},
					{ "Stained", "Rare"},
					{ "Thorns", "Uncommon"},
					{ "Thylacine", "Common"},
					{ "Underbelly", "Common"},
					{ "Ghost", "Uncommon"},
					{ "Filigree", "Rare"},
					{ "Veined", "Limited"}

                };

				return genes;
			}
			else if (type == "Aberration")
            {
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Capsule", "Limited"},
					{ "Fangs", "Uncommon"},
					{ "Firefly", "Limited"},
					{ "Flecks", "Uncommon"},
					{ "Frills", "Rare"},
					{ "Ghost", "Uncommon"},
					{ "Glimmer", "Rare"},
					{ "Glowtail", "Rare"},
					{ "Jewels", "Rare"},
					{ "Kumo", "Common"},
					{ "Mucous", "Limited"},
					{ "Peacock", "Common"},
					{ "Polkadot", "Limited"},
					{ "Polypore", "Limited"},
					{ "Scales", "Limited"},
					{ "Sparkle", "Uncommon"},
					{ "Thylacine", "Common"},
					{ "Veined", "Limited"},

                };

				return genes;
			}
            else if (type == "Undertide")
            {
                string[,] genes = new string[,]
                {
                    { "Basic", "Plentiful"},
                    { "Capsule", "Limited"},
                    { "Circuit", "Rare"},
                    { "Crackle", "Uncommon"},
                    { "Featherbeard", "Limited"},
                    { "Filigree", "Rare"},
                    { "Flecks", "Uncommon"},
                    { "Gembond", "Limited"},
                    { "Ghost", "Uncommon"},
                    { "Nudibranch", "Limited"},
                    { "Okapi", "Uncommon"},
                    { "Plating", "Uncommon"},
                    { "Pufferfish", "Uncommon"},
                    { "Remora", "Rare"},
                    { "Ringlets", "Uncommon"},
                    { "Runes", "Limited"},
                    { "Sailfin", "Rare"},
                    { "Soap", "Rare"},
                    { "Sparkle", "Uncommon"},
                    { "Stained", "Rare"},
                    { "Tentacles", "Rare"},
                    { "Underbelly", "Common"},
                    { "Veined", "Limited"}

                };

                return genes;
            }
            else if (type == "Aether")
            {
                string[,] genes = new string[,]
                {
                    { "Basic", "Plentiful"},
					{ "Monarch", "Rare"},
					{ "Space", "Rare"},
					{ "Stinger", "Uncommon"},
					{ "Whiskers", "Uncommon"},
					{ "Wish", "Rare"},
					{ "Mandibles", "Limited"},
					{ "Flutter", "Limited"},
					{ "Circuit", "Rare"},
					{ "Contour", "Common"},
					{ "Gembond", "Limited"},
					{ "Glowtail", "Rare"},
					{ "Keel", "Limited"},
					{ "Lace", "Uncommon"},
					{ "points", "Uncommon"},
					{ "Scales", "Limited"},
					{ "Smirch", "Limited"},
					{ "Smoke", "Uncommon"},
					{ "Sparkle", "Uncommon"},
					{ "Spines", "Limited"},
					{ "Stained", "Rare"},
					{ "Underbelly", "Common"}


                };

                return genes;
            }
            else
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Capsule", "Limited"},
					{ "Circuit", "Rare"},
					{ "Contour", "Common"},
					{ "Crackle", "Uncommon"},
					{ "Firefly", "Limited"},
					{ "Filigree", "Rare"},
					{ "Flecks", "Uncommon"},
					{ "Gembond", "Limited"},
					{ "Ghost", "Uncommon"},
					{ "Glimmer", "Rare"},
					{ "Glowtail", "Rare"},
					{ "Keel", "Limited"},
					{ "Koi", "Rare"},
					{ "Lace", "Uncommon"},
					{ "Okapi", "Uncommon"},
					{ "Opal", "Rare"},
					{ "Peacock", "Common"},
					{ "Points", "Uncommon"},
					{ "Ringlets", "Uncommon"},
					{ "Runes", "Limited"},
					{ "Scales", "Limited"},
					{ "Smirch", "Limited"},
					{ "Smoke", "Uncommon"},
					{ "Soap", "Rare"},
					{ "Sparkle", "Uncommon"},
					{ "Spines", "Limited"},
					{ "Stained", "Rare"},
					{ "Thylacine", "Common"},
					{ "Underbelly", "Common"},
					{ "Veined", "Limited"},

                };

				return genes;
			}
		}


		internal string[,] CreateSecondaryGeneList(object type) //NEW
		{
			
			if (type.ToString() == "Gaoler")
			{
				string[,] genes = new string[,]	{
                    { "Basic", "Plentiful"},
					{ "Bee", "Rare"},
					{ "Blend", "Common"},
					{ "Breakup", "Uncommon"},
					{ "Clouded", "Common"},
					{ "Current", "Uncommon"},
					{ "Daub", "Common"},
					{ "Edged", "Common"},
					{ "Eel", "Uncommon"},
					{ "Eye Spots", "Common"},
					{ "Facet", "Rare"},
					{ "Flair", "Uncommon"},
					{ "Foam", "Limited"},
					{ "Hex", "Uncommon"},
					{ "Marbeled", "Common"},
					{ "Paint", "Common"},
					{ "Patchwork", "Limited"},
					{ "Peregrine", "Common"},
					{ "Rosette", "Uncommon"},
					{ "Saddle", "Uncommon"},
					{ "Safari", "Common"},
					{ "Sludge", "Limited"},
					{ "Spinner", "Limited"},
					{ "Spirit", "Limited"},
					{ "Streak", "Common"},
					{ "Striation", "Common"},
					{ "Stripes", "Common"},
					{ "Toxin", "Limited"},
					{ "Trail", "Limited"}

                };

				return genes;
			}
			else if (type.ToString() == "Banescale")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Alloy", "Rare"},
					{ "Arrow", "Uncommon"},
					{ "Blend", "Common"},
					{ "Butterfly", "Rare"},
					{ "Clouded", "Common"},
					{ "Current", "Uncommon"},
					{ "Edged", "Common"},
					{ "Eye Spots", "Common"},
					{ "Hex", "Uncommon"},
					{ "Mottle", "Common"},
					{ "Peregrine", "Common"},
					{ "Rosette", "Uncommon"},
					{ "Safari", "Common"},
					{ "Spinner", "Limited"},
					{ "Striation", "Common"},
					{ "Stripes", "Common"},
					{ "Sugarplum", "Limited"},
					{ "Tear", "Limited"},
					{ "Toxin", "Limited"},
					{ "Trail", "Limited"},
					{ "Daub", "Common"},
					{ "Facet", "Rare"},
					{ "Eel", "Uncommon"},
					{ "Foam", "Limited"},
					{ "Sarcophagus", "Rare"}

                };

				return genes;
			}
			else if (type.ToString() == "Veilspun")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Bee", "Rare"},
					{ "Blend", "Common"},
					{ "Constellation", "Rare"},
					{ "Edged", "Common"},
					{ "Eye Spots", "Common"},
					{ "Hawkmoth", "Uncommon"},
					{ "Hex", "Common"},
					{ "Hypnotic", "Uncommon"},
					{ "Loop", "Uncommon"},
					{ "Patchwork", "Limited"},
					{ "Saturn", "Uncommon"},
					{ "Spinner", "Limited"},
					{ "Striation", "Common"},
					{ "Vivid", "Uncommon"},
					{ "Web", "Uncommon"},
					{ "Peregrine", "Common"},
					{ "Toxin", "Limited"},
					{ "Sludge", "Limited"},
					{ "Clouded", "Common"},
					{ "Butterfly", "Rare"},
					{ "Freckle", "Common"},
					{ "Daub", "Common"}

                };

				return genes;
			}
			else if (type.ToString() == "Aberration")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Bee", "Rare"},
					{ "Blend", "Common"},
					{ "Daub", "Common"},
					{ "Eel", "Uncommon"},
					{ "Facet", "Rare"},
					{ "Fissure", "Limited"},
					{ "Flair", "Uncommon"},
					{ "Freckle", "Common"},
					{ "Hex", "Uncommon"},
					{ "Hypnotic", "Uncommon"},
					{ "Marbled", "Common"},
					{ "Noxtide", "Uncommon"},
					{ "Patchwork", "Limited"},
					{ "Peregrine", "Common"},
					{ "Rosette", "Uncommon"},
					{ "Safari", "Common"},
					{ "Sarcophagus", "Rare"},
					{ "Sludge", "Limited"},
					{ "Spade", "Limited"},
					{ "Striation", "Common"},
					{ "Weaver", "Limited"}

                };

				return genes;
			}
            else if (type.ToString() == "Undertide")
            {
                string[,] genes = new string[,]
                {
                    { "Basic", "Plentiful"},
                    { "Bee", "Rare"},
                    { "Blend", "Common"},
                    { "Chess", "Common"},
                    { "Daub", "Common"},
                    { "Eel", "Uncommon"},
                    { "Facet", "Rare"},
                    { "Foam", "Limited"},
                    { "Freckle", "Common"},
                    { "Hex", "Uncommon"},
                    { "Marbled", "Common"},
                    { "Myrid", "Limited"},
                    { "Noxtide", "Uncommon"},
                    { "Pack", "Uncommon"},
                    { "Peregrine", "Common"},
                    { "Rings", "Limited"},
                    { "Saddle", "Uncommon"},
                    { "Safari", "Common"},
                    { "Sarcophagus", "Rare"},
                    { "Seraph", "Uncommon"},
                    { "Toxin", "Limited"},
                    { "Trail", "Limited"}

                };

                return genes;
            }
            else if (type == "Aether")
            {
                string[,] genes = new string[,]
                {
                    { "Basic", "Plentiful"},
					{ "Blaze", "Uncommon"},
					{ "Thread", "Common"},
					{ "Flicker", "Rare"},
					{ "Icing", "Limited"},
					{ "Alloy", "Rare"},
					{ "Blend", "Common"},
					{ "Butterfly", "Rare"},
					{ "Breakup", "Uncommon"},
					{ "Constellation", "Rare"},
					{ "Daub", "Common"},
					{ "Edged", "Common"},
					{ "Eyespots", "Common"},
					{ "Flair", "Uncommon"},
					{ "Foam", "Limited"},
					{ "Morph", "Uncommon"},
					{ "Myrid", "Limited"},
					{ "Noxtide", "uncommon"},
					{ "Paint", "Common"},
					{ "Patch work", "Limited"},
					{ "Rosette", "Uncommon"},
					{ "Saturn", "Uncommon"},
					{ "Spinner", "Limited"}


                };

                return genes;
            }
            else
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Alloy", "Rare"},
					{ "Bee", "Rare"},
					{ "Blend", "Common"},
					{ "Breakup", "Uncommon"},
					{ "Butterfly", "Rare"},
					{ "Clouded", "Common"},
					{ "Constellation", "Rare"},
					{ "Current", "Uncommon"},
					{ "Daub", "Common"},
					{ "Edged", "Common"},
					{ "Eel", "Uncommon"},
					{ "Eye Spots", "Common"},
					{ "Facet", "Rare"},
					{ "Fissure", "Limited"},
					{ "Flair", "Uncommon"},
					{ "Foam", "Limited"},
					{ "Freckle", "Common"},
					{ "Hex", "Uncommon"},
					{ "Jester", "Rare"},
					{ "Marbled", "Common"},
					{ "Morph", "Uncommon"},
					{ "Myrid", "Limited"},
					{ "Noxtide", "Uncommon"},
					{ "Paint", "Common"},
					{ "Paisley", "Limited"},
					{ "Patchwork", "Limited"},
					{ "Peregrine", "Common"},
					{ "Rosette", "Uncommon"},
					{ "Safari", "Common"},
					{ "Sarcophagus", "Rare"},
					{ "Saturn", "Uncommon"},
					{ "Seraph", "Uncommon"},
					{ "Shimmer", "Rare"},
					{ "Sludge", "Limited"},
					{ "Spinner", "Limited"},
					{ "Striation", "Common"},
					{ "Stripes", "Common"},
					{ "Toxin", "Limited"},
					{ "Trail", "Limited"}

                };

				return genes;
			}

			
		}

		internal string[,] CreatePrimaryGeneList(string type)
		{
			
			if (type == "Gaoler")
			{
				//change the genes to Gaelor only types.
				string[,] genes = new string[,] {
                { "Bar", "Uncommon"},
				{ "Basic", "Plentiful"},
				{ "Boa", "Uncommon"},
				{ "Clown", "Common"},
				{ "Crystal", "Rare"},
				{ "Fade", "Common"},
				{ "Falcon", "Common"},
				{ "Flaunt", "Uncommon"},
				{ "Giraffe", "Uncommon"},
				{ "Jaguar", "Uncommon"},
				{ "Laced", "Common"},
				{ "Leopard", "Commonh"},
				{ "Mosaic", "Uncommon"},
				{ "Phantom", "Limited"},
				{ "Piebald", "Common"},
				{ "Pinstripe", "Limited"},
				{ "Poison", "Limited"},
				{ "Ribbon", "Uncommon"},
				{ "Ripple", "Uncommon"},
				{ "Savannah", "Common"},
				{ "Shaggy", "Common"},
				{ "Skink", "Limited"},
				{ "Slime", "Limited"},
				{ "Stitched", "Limited"},
				{ "Swirl", "Common"},
				{ "Tapir", "Common"},
				{ "Tide", "Limited"},
				{ "Tiger", "Common"},
				{ "Wasp", "Rare"}

                };
				return genes;
			}
			else if (type == "Banescale")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Candycane", "Limited"},
					{ "Cherub", "Uncommon"},
					{ "Chevron", "Uncommon"},
					{ "Clown", "Common"},
					{ "Fade", "Common"},
					{ "Falcon", "Common"},
					{ "Giraffe", "Uncommon"},
					{ "Jaguar", "Uncommon"},
					{ "Laced", "Common"},
					{ "Leopard", "Common"},
					{ "Marble", "Common"},
					{ "Metallic", "Rare"},
					{ "Petals", "Rare"},
					{ "Pinstripe", "Limited"},
					{ "Poison", "Limited"},
					{ "Ragged", "Uncommon"},
					{ "Ripple", "Uncommon"},
					{ "Savannah", "Common"},
					{ "Skink", "Limited"},
					{ "Tapir", "Common"},
					{ "Tiger", "Common"},
					{ "Vipera", "Uncommon"},
					{ "Wasp", "Rare"},
					{ "Bar", "Uncommon"},
					{ "Crystal", "Rare"},
					{ "Ribbon", "Uncommon"},
					{ "Tide", "Limited"},
					{ "Pharoh", "Rare"}

                };
				return genes;
			}
			else if (type == "Veilspun")
			{
				string[,] genes = new string[,]
				{
                    { "Arc", "Uncommon"},
					{ "Basic", "Plentiful"},
					{ "Bright", "Uncommon"},
					{ "Clown", "Common"},
					{ "Fade", "Common"},
					{ "Giraffe", "Uncommon"},
					{ "Jupiter", "Uncommon"},
					{ "Laced", "Common"},
					{ "Shell", "Uncommon"},
					{ "Skink", "Limited"},
					{ "Sphinxmoth", "Uncommon"},
					{ "Starmap", "Rare"},
					{ "Stitched", "Rare"},
					{ "Tapir", "Common"},
					{ "Vipera", "Uncommon"},
					{ "Wasp", "Rare"},
					{ "Falcon", "Common"},
					{ "Poison", "Limited"},
					{ "Slime", "Limited"},
					{ "Leopard", "Common"},
					{ "Petals", "Rare"},
					{ "Speckle", "Common"},
					{ "Bar", "Uncommon"}

                };
				return genes;
			}
			else if (type == "Aberration")
			{
				string[,] genes = new string[,]
				{
                    { "Basic", "Plentiful"},
					{ "Bar", "Uncommon"},
					{ "Diamond", "Limited"},
					{ "Crystal", "Rare"},
					{ "Fade", "Common"},
					{ "Falcon", "Common"},
					{ "Flaunt", "Uncommon"},
					{ "Giraffe", "Uncommon"},
					{ "Ground", "Limited"},
					{ "Jaguar", "Uncommon"},
					{ "Lionfish", "Uncommon"},
					{ "Orb", "Limited"},
					{ "Pharaoh", "Rare"},
					{ "Slime", "Limited"},
					{ "Speckle", "Common"},
					{ "Stitched", "Limited"},
					{ "Swirl", "Common"},
					{ "Tapir", "Common"},
					{ "Vipera", "Uncommon"},
					{ "Wasp", "Rare"},

                };

				return genes;
			}
            else if (type == "Undertide")
            {
                string[,] genes = new string[,]
                {
                    { "Basic", "Plentiful"},
                    { "Bar", "Uncommon"},
                    { "Boa", "Uncommon"},
                    { "Boulder", "Limited"},
                    { "Checkers", "Common"},
                    { "Cherub", "Uncommon"},
                    { "Crystal", "Rare"},
                    { "Fade", "Common"},
                    { "Falcon", "Common"},
                    { "Giraffe", "Uncommon"},
                    { "Lionfish", "Uncommon"},
                    { "Octopus", "Limited"},
                    { "Pharaoh", "Rare"},
                    { "Pinstripe", "Limited"},
                    { "Poison", "Limited"},
                    { "Ribbon", "Uncommon"},
                    { "Ripple", "Uncommon"},
                    { "Savannah", "Common"},
                    { "Speckle", "Common"},
                    { "Swirl", "Common"},
                    { "Tide", "Limited"},
                    { "Wasp", "Rare"},
                    { "Wolf", "Uncommon"}

                };
                return genes;
            }
            else if (type == "Aether")
            {
                string[,] genes = new string[,]
                {
                    { "Basic", "Plentiful"},
					{ "Cinder", "Uncommon"},
					{ "Spool", "Common"},
					{ "Twinkle", "Rare"},
					{ "Candy", "Limited"},
					{ "Bar", "Uncommon"},
					{ "Boulder", "Limited"},
					{ "Clown", "Common"},
					{ "Fade", "Common"},
					{ "Flaunt", "Uncommon"},
					{ "Jaguar", "Uncommon"},
					{ "Jupiter", "Uncommon"},
					{ "Laced", "Common"},
					{ "Lionfish", "Uncommon"},
					{ "Metallic", "Rare"},
					{ "Mosaic", "Uncommon"},
					{ "Petals", "Rare"},
					{ "Piebald", "Common"},
					{ "Python", "Uncommon"},
					{ "Skink", "Limited"},
					{ "Starmap", "Rare"},
					{ "Stitched", "Limited"},
					{ "Tide", "Limited"}


                };

                return genes;
            }
            else //Modern Genes
			{

				string[,] genes = new string[,] {
                { "Basic", "Plentiful"},
				{ "Bar", "Uncommon"},
				{ "Boulder", "Limited"},
				{ "Cherub", "Uncommon"},
				{ "Clown", "Common"},
				{ "Crystal", "Rare"},
				{ "Fade", "Common"},
				{ "Falcon", "Common"},
				{ "Fern", "Limited"},
				{ "Flaunt", "Uncommon"},
				{ "Giraffe", "Uncommon"},
				{ "Ground", "Limited"},
				{ "Harlequin", "Rare"},
				{ "Iridescent", "Rare"},
				{ "Jaguar", "Uncommon"},
				{ "Jupiter", "Uncommon"},
				{ "Laced", "Common"},
				{ "Leopard", "Common"},
				{ "Lionfish", "Uncommon"},
				{ "Metallic", "Rare"},
				{ "Mosaic", "Uncommon"},
				{ "Petals", "Rare"},
				{ "Pharaoh", "Rare"},
				{ "Piebald", "Common"},
				{ "Pinstripe", "Limited"},
				{ "Poison", "Limited"},
				{ "Python", "Uncommon"},
				{ "Ribbon", "Uncommon"},
				{ "Ripple", "Uncommon"},
				{ "Savannah", "Common"},
				{ "Skink", "Limited"},
				{ "Slime", "Limited"},
				{ "Starmap", "Rare"},
				{ "Stitched", "Limited"},
				{ "Swirl", "Common"},
				{ "Tapir", "Common"},
				{ "Tide", "Limited"},
				{ "Tiger", "Common"},
				{ "Vipera", "Uncommon"},
				{ "Wasp", "Rare"},
				{ "Speckle", "Common"}

                };

				return genes;
			}

			
		} //NEW

		internal string [,] CreateBreedList()
		{
			string[,] breeds = new string[,]
			{
				{"Aberration", "Ancient" },
				{"Aether", "Ancient" },
				{"Banescale", "Ancient" },
				{"Bogsneak", "Uncommon" },
				{"Coatl", "Rare" },
				{"Fae", "Plentiful" },
				{"Gaoler", "Ancient" },
				{"Guardian", "plentiful" },
				{"Imperial", "Limited" },
				{"Mirror", "Plentiful" },
				{"Nocturne", "Limited" },
				{"Obelisk", "Uncommon" },
				{"Pearlcatcher", "Common" },
				{"Ridgeback", "Common" },
				{"Skydancer", "Uncommon" },
				{"Snapper", "Common" },
				{"Spiral", "Common" },
				{"Tundra", "Plentiful" },
				{"Veilspun", "Ancient" }, //Aquire New breed spelling and rate.
				{"Undertide", "Ancient" },
				{"Wildclaw", "Rare" }
			};

			return breeds;
		} //NEW

		internal string[,] CreateColorArray()
		{
			string[,] colors = {
				{"Maize", "FFFDEA"},
				{"Cream", "FFEFDC"},
				{"Antique", "D8D6CD"},
				{"White", "FFFFFF"},
				{"Moon", "D8D7D8"},
				{"Ice", "DAE0F3"},
				{"Orca", "E1DFFF"},
				{"Platinum", "C8BECE"},
				{"Silver", "BBBABF"},
				{"Dust", "9D9D9F"},
				{"Grey", "808080"},
				{"Smoke", "9494A9"},
				{"Gloom", "545365"},
				{"Lead", "413C40"},
				{"Shale", "4D484F"},
				{"Flint", "636268"},
				{"Charcoal", "555555"},
				{"Coal", "4B4946"},
				{"Oilslick", "352B25"},
				{"Black", "333333"},
				{"Obsidian", "1D2224"},
				{"Eldritch", "252A25"},
				{"Midnight", "292B38"},
				{"Shadow", "3B2F45"},
				{"Blackberry", "4C2A4F"},
				{"Mulberry", "6E235D"},
				{"Plum", "863290"},
				{"Wisteria", "724D79"},
				{"Thistle", "8F7D8B"},
				{"Fog", "A593B0"},
				{"Mist", "E1CEFF"},
				{"Lavender", "CCA4E0"},
				{"Heather", "9777BD"},
				{"Purple", "A261CF"},
				{"Orchid", "D951FF"},
				{"Amethyst", "993BD0"},
				{"NightShade", "792FB2"},
				{"Violet", "653F9C"},
				{"Grape", "560FBE"},
				{"Royal", "4D2D89"},
				{"Eggplant", "332B65"},
				{"Iris", "535195"},
				{"Storm", "757ADB"},
				{"Twilight", "474BA0"},
				{"Indigo", "2D237B"},
				{"Sapphire", "0D095B"},
				{"Navy", "212B5F"},
				{"Cobalt", "003584"},
				{"Ultramarine", "1D51E7"},
				{"Blue", "324BA9"},
				{"Periwinkle", "4967D5"},
				{"Lapis", "287CEF"},
{"Splash", "6394DD"},
{"Cornflower", "75A8FF"},
{"Sky", "AEC8FF"},
{"Stonewash", "7995C1"},
{"Overcast", "454F69"},
{"Steel", "556979"},
{"Denim", "2F4557"},
{"Abyss", "0B1F25"},
{"Phthalo", "0B2D47"},
{"Azure", "0A3D67"},
{"Caribbean", "0086CE"},
{"Teal", "2B768F"},
{"Cerulean", "00B3D5"},
{"Cyan", "00FFF0"},
{"Robin", "9AEAEF"},
{"Aqua", "73C4C4"},
{"Turquoise", "3BA0A1"},
{"Spruce", "8BBBB2"},
{"Pistachio", "E2FFE6"},
{"Seafoam", "B2E2BD"},
{"Mint", "9AFFC7"},
{"Jade", "61AB89"},
{"Spearmint", "158E67"},
{"Thicket", "005F49"},
{"Peacock", "1F4739"},
{"Emerald", "21613F"},
{"Shamrock", "236925"},
{"Jungle", "1E361A"},
{"Hunter", "1D2715"},
{"Forest", "425035"},
{"Camo", "51694D"},
{"Algae", "97AF8B"},
{"Swamp", "687F67"},
{"Avocado", "567D34"},
{"Green", "629C3F"},
{"Fern", "7FCE73"},
{"Mantis", "99FF9C"},
{"Pear", "8ECD55"},
{"Leaf", "A5E32D"},
{"Radioactive", "C6FF00"},
{"Honeydew", "D0E673"},
{"Peridot", "E8FFB5"},
{"Chartreuse", "B4CD3D"},
{"Spring", "9DA932"},
{"Crocodile", "828335"},
{"Olive", "697135"},
{"Murk", "4B4521"},
{"Moss", "7F7745"},
{"Goldenrod", "BEA55D"},
{"Amber", "C18E1B"},
{"Honey", "D1B300"},
{"Lemon", "FFE63B"},
{"Yellow", "F9E255"},
{"Grapefruit", "F7FF6F"},
{"Banana", "FFEC80"},
{"Sanddollar", "EBE7AE"},
{"Flaxen", "FDE9AE"},
{"Ivory", "FFD297"},
{"Buttercup", "F6BF6B"},
{"Gold", "E8AF49"},
{"Metals", "D1B047"},
{"Merigold", "FFB43B"},
{"Sunshine", "FA912B"},
{"Saffron", "FF8400"},
{"Sunset", "FFA249"},
{"Peach", "FFB577"},
{"Cantaloupe", "FF984F"},
{"Orange", "D5602B"},
{"Bronze", "B2570D"},
{"Terracotta", "B23B07"},
{"Carrot", "FF5500"},
{"Fire", "EF5C23"},
{"Pumpkin", "FF6941"},
{"Tangerine", "FF7360"},
{"Cinnamon", "C05B39"},
{"Caramel", "C67147"},
{"Sand", "B27749"},
{"Tan", "C49A71"},
{"Beige", "CABBA2"},
{"Stone", "827A64"},
{"Taupe", "6D675B"},
{"Slate", "564D48"},
{"Driftwood", "776359"},
{"Latte", "977B6D"},
{"Dirt", "77493F"},
{"Clay", "613F3D"},
{"Sable", "57372D"},
{"Umber", "2F1F1B"},
{"Soil", "5A4534"},
{"Hickory", "735739"},
{"Tarnish", "855D33"},
{"Ginger", "90532B"},
{"Brown", "8D5B3E"},
{"Chocolate", "563012"},
{"Auburn", "7B3D1D"},
{"Copper", "A44B29"},
{"Rust", "8A3220"},
{"Tomato", "BA311C"},
{"Vermilion", "E22D17"},
{"Ruby", "CD000F"},
{"Cherry", "AA0025"},
{"Crimson", "850012"},
{"Garnet", "5B0F15"},
{"Sanguine", "2F0003"},
{"Blood", "451717"},
{"Maroon", "652127"},
{"Berry", "8B272D"},
{"Red", "C1272D"},
{"Strawberry", "DE3335"},
{"Cerise", "A22929"},
{"Carmine", "B13A3A"},
{"Brick", "9A534D"},
{"Coral","CC6F6F"},
{"Blush","FFA2A2"},
{"Cottoncandy","EB7997"},
{"Watermelon","DB518D"},
{"Magenta","E934AA"},
{"Fuchsia","EC0089"},
{"Rasberry","8A0349"},
{"Wine","4D0F29"},
{"Mauve","9C4975"},
{"Pink","E77FBF"},
{"Bubblegum","EAA9FF"},
{"Rose","FFD6F6"},
{"Pearl","FBEDF9"}
			};

			return colors;
		}

		internal string[] CreateGenderList()
		{
			string[] Genders = new string[] { "Female", "Male" };

			return Genders;
		}

		internal string[] CreateEyeTypeList()
		{
			string[] eyeTypes = { "Common", 
				"Uncommon", 
				"Unusual", 
				"Rare", 
				"Bright", 
				"Pastel", 
				"Faceted", 
				"Goat", 
				"Multi-Gaze", 
				"Primal",
				"Glowing",
				"Dark Sclera",
				"Innocent", 
				"Swirl"
				};

			return eyeTypes;
		}

		internal string[] CreateFlightList()
		{
			string[] flights = {"Plague", "Earth", "Light", "Shadow", "Fire", "Ice", "Water", "Lightning", "Wind", "Nature", "Arcane"};

			return flights;
		}

		public string WithURL(string imgLink, string url)
		{
			return "[url=" + url + "][img]" + imgLink + "[/img][/url]";
		}

		public string ImgURL(string type, string batchNum, string id, string ext)
		{
			return "http://flightrising.com/rendern/" + type + "/" + batchNum + "/" + id + ext;
		}

		public string GetURL(string id)
		{
			return "http://flightrising.com/main.php?dragon=" + id; ;
		}

		public string GetAvatarImg(string id)
		{
			return "http://flightrising.com/main.php?dragon=" + id; ;
		}
	}
}
