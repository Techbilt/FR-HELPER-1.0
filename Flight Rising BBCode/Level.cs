using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Rising_BBCode
{
	[Serializable]
	class Level
	{
		public string Arena { get; set; }
		public string CollectedItem { get; set; }
		public int ItemNumber { get; set; }
		public string HonorableMentions { get; set; }
		public List<string> dragonTeam { get; set; }
	}
}
