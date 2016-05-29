using System.Collections.Generic;

namespace CardMakerLib
{
	public class Deck
	{
		#region Members
		public string ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<string> CardIDs { get; set; }
		#endregion

		#region Constructor
		public Deck()
		{
			ID = "";
			Name = "New deck";
			Description = "No description";
			CardIDs = new List<string>();
		}
		#endregion
	}
}