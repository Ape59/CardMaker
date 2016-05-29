using System.Collections.Generic;

namespace CardMakerLib
{
	public class CardMakerData
	{
		#region Members
		public List<Card> Cards { get; set; }
		public List<Deck> Decks { get; set; }
		#endregion

		#region Constructor
		public CardMakerData()
		{
			Cards = new List<Card>();
			Decks = new List<Deck>();
		}
		#endregion
	}
}
