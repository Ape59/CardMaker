using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormMenu : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		#endregion

		#region Constructor
		public FormMenu(CardMaker f_CardMaker)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;
		}
		#endregion

		#region OnGame
		private void btnGame_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormSelectDeck(m_CardMaker));
		}
		#endregion

		#region OnDecks
		private void btnDecks_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormDecks(m_CardMaker));
		}
		#endregion

		#region OnCards
		private void btnCards_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormCards(m_CardMaker, string.Empty));
		}
		#endregion
	}
}
