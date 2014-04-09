using System.Collections.Generic;
namespace TrelloNet
{
	public class List : IListId, IUpdatableList
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public bool Closed { get; set; }
		public string IdBoard { get; set; }
		public double Pos { get; set; }

        public List<Card> Cards { get; set; }

        public List() 
        {
            this.Cards = new List<Card>();
        }

		public string GetListId()
		{
			return Id;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}