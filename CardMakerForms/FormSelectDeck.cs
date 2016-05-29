using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormSelectDeck : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		#endregion

		#region Constructor
		public FormSelectDeck(CardMaker f_CardMaker)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;
		}
		#endregion

		#region OnLoad
		private void FormSelectDeck_Load(object sender, EventArgs e)
		{
			RefreshDecks();
			RefreshButtons();
		}
		#endregion

		#region OnSelectionChanged
		private void dgvDecks_SelectionChanged(object sender, EventArgs e)
		{
			RefreshButtons();
		}
		#endregion

		#region OnStartGame
		private void btnStartGame_Click(object sender, EventArgs e)
		{
			Deck selectedDeck = null;
			Game game = null;

			if (dgvDecks.SelectedRows.Count == 1)
			{
				selectedDeck = (Deck)dgvDecks.SelectedRows[0].Tag;

				game = new Game(m_CardMaker, selectedDeck);

				FormChanger.SetForm(new FormGame(m_CardMaker, game));
			}
		}
		#endregion

		#region OnCancel
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormMenu(m_CardMaker));
		}
		#endregion

		#region RefreshButtons
		private void RefreshButtons()
		{
			btnStartGame.Enabled = dgvDecks.SelectedRows.Count == 1;
		}
		#endregion

		#region RefreshDecks
		private void RefreshDecks()
		{
			DataGridViewRow row = null;
			Deck selectedDeck = null;

			if (dgvDecks.SelectedRows.Count == 1)
			{
				selectedDeck = (Deck)dgvDecks.SelectedRows[0].Tag;
			}

			dgvDecks.Rows.Clear();

			foreach (Deck deck in m_CardMaker.Data.Decks)
			{
				row = dgvDecks.Rows[dgvDecks.Rows.Add()];
				row.Cells[clmDeckName.Name].Value = deck.Name;
				row.Cells[clmCardNumber.Name].Value = deck.CardIDs.Count + " Karten";
				row.Tag = deck;

				if (deck == selectedDeck)
				{
					row.Selected = true;
				}
			}
		}

		#endregion
	}
}
