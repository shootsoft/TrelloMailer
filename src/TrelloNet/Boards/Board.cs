using System.Collections.Generic;
using Newtonsoft.Json;

namespace TrelloNet
{
	public class Board : IBoardId, IUpdatableBoard
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Desc { get; set; }
		public bool Closed { get; set; }
		public string IdOrganization { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)] 
        public bool Pinned { get; set; }

		public string Url { get; set; }
		public BoardPreferences Prefs { get; set; }
		public bool Invited { get; set; }
		public Dictionary<Color, string> LabelNames { get; set; }
        public List<List> Lists { get; set; }

        public bool Starred { get; set; }

        public Board()
        {
            Lists = new List<List>();
        }

		public string GetBoardId()
		{
			return Id;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}