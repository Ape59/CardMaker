namespace CardMakerLib
{
	public class Card
	{
		#region Members
		public string ID { get; set; }
		public string Group { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string ImagePath { get; set; }
		#endregion

		#region Constructor
		public Card()
		{
			ID = "";
			Group = "";
			Name = "New card";
			Description = "No description";
			ImagePath = "";
		}
		#endregion
	}
}
