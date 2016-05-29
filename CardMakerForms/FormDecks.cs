using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormDecks : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		#endregion

		#region Constructor
		public FormDecks(CardMaker f_CardMaker)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;
		}
		#endregion

		#region OnLoad
		private void FormDecks_Load(object sender, EventArgs e)
		{
			RefreshButtons();
			RefreshDecks();
		}
		#endregion

		#region OnSelectionChanged
		private void dgvDecks_SelectionChanged(object sender, EventArgs e)
		{
			RefreshButtons();
		}
		#endregion

		#region OnAddDeck
		private void btnAddDeck_Click(object sender, EventArgs e)
		{
			Deck deck = null;

			deck = new Deck();
			deck.ID = Guid.NewGuid().ToString();

			FormChanger.SetForm(new FormEditDeck(m_CardMaker, deck));
		}
		#endregion

		#region OnEditDeck
		private void btnEditDeck_Click(object sender, EventArgs e)
		{
			Deck selectedDeck = null;

			if (dgvDecks.SelectedRows.Count == 1)
			{
				selectedDeck = (Deck)dgvDecks.SelectedRows[0].Tag;

				FormChanger.SetForm(new FormEditDeck(m_CardMaker, selectedDeck));
			}
		}
		#endregion

		#region OnRemoveDeck
		private void btnRemoveDeck_Click(object sender, EventArgs e)
		{
			Deck selectedDeck = null;

			if (dgvDecks.SelectedRows.Count == 1)
			{
				selectedDeck = (Deck)dgvDecks.SelectedRows[0].Tag;

				m_CardMaker.Data.Decks.Remove(selectedDeck);

				if (m_CardMaker.SaveData() == false)
				{
					MessageBox.Show(m_CardMaker.Error, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				RefreshButtons();
				RefreshDecks();
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
			btnEditDeck.Enabled = dgvDecks.SelectedRows.Count == 1;
			btnRemoveDeck.Enabled = dgvDecks.SelectedRows.Count == 1;
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
