using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormEditDeck : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		private Deck m_Deck = null;
		private List<string> m_lstCardIDsTemp = null;
		#endregion

		#region Constructor
		public FormEditDeck(CardMaker f_CardMaker, Deck f_Deck)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;
			m_Deck = f_Deck;

			m_lstCardIDsTemp = new List<string>();
			m_lstCardIDsTemp.AddRange(m_Deck.CardIDs);
		}
		#endregion

		#region OnLoad
		private void FormEditDeck_Load(object sender, EventArgs e)
		{
			edtName.Text = m_Deck.Name;
			edtDescription.Text = m_Deck.Description;

			RefreshCardsSource();
			RefreshCardsDeck();
			RefreshButtons();
			RefreshGroups();
		}
		#endregion

		#region OnTextChanged
		private void cmbGroup_TextChanged(object sender, EventArgs e)
		{
			RefreshCardsSource();
		}
		#endregion

		#region OnSelectionChanged
		private void dgvCardsSource_SelectionChanged(object sender, EventArgs e)
		{
			RefreshButtons();
		}

		private void dgvCardsDeck_SelectionChanged(object sender, EventArgs e)
		{
			RefreshButtons();
		}
		#endregion

		#region OnAddCard
		private void btnAddCard_Click(object sender, EventArgs e)
		{
			Card selectedCard = null;

			if(dgvCardsSource.SelectedRows.Count == 1)
			{
				selectedCard = (Card)dgvCardsSource.SelectedRows[0].Tag;

				m_lstCardIDsTemp.Add(selectedCard.ID);
				m_lstCardIDsTemp.Sort();

				RefreshCardsDeck();
			}
		}
		#endregion

		#region OnRemoveCard
		private void btnRemoveCard_Click(object sender, EventArgs e)
		{
			string strSelectedCardID = string.Empty;

			if(dgvCardsDeck.SelectedRows.Count == 1)
			{
				strSelectedCardID = (string)dgvCardsDeck.SelectedRows[0].Tag;

				m_lstCardIDsTemp.Remove(strSelectedCardID);

				RefreshCardsDeck();
			}
		}
		#endregion

		#region OnApply
		private void btnApply_Click(object sender, EventArgs e)
		{
			m_Deck.Name = edtName.Text;
			m_Deck.Description = edtDescription.Text;
			m_Deck.CardIDs = m_lstCardIDsTemp;

			if (m_CardMaker.Data.Decks.Contains(m_Deck) == false)
			{
				m_CardMaker.Data.Decks.Add(m_Deck);
			}

			if (m_CardMaker.SaveData() == false)
			{
				MessageBox.Show(m_CardMaker.Error, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			FormChanger.SetForm(new FormDecks(m_CardMaker));
		}
		#endregion

		#region OnCancel
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormDecks(m_CardMaker));
		}
		#endregion

		#region RefreshGroups
		private void RefreshGroups()
		{
			cmbGroup.Items.Clear();
			foreach (Card card in m_CardMaker.Data.Cards)
			{
				if (cmbGroup.Items.Contains(card.Group) == false)
				{
					cmbGroup.Items.Add(card.Group);
				}
			}
		}
		#endregion

		#region RefreshButtons
		private void RefreshButtons()
		{
			btnAddCard.Enabled = dgvCardsSource.SelectedRows.Count == 1;
			btnRemoveCard.Enabled = dgvCardsDeck.SelectedRows.Count == 1;
		}
		#endregion

		#region RefreshCardsSource
		private void RefreshCardsSource()
		{
			DataGridViewRow row = null;
			Card selectedCard = null;

			if (dgvCardsSource.SelectedRows.Count == 1)
			{
				selectedCard = (Card)dgvCardsSource.SelectedRows[0].Tag;
			}

			dgvCardsSource.Rows.Clear();

			foreach (Card card in m_CardMaker.Data.Cards)
			{
				if (card.Group == cmbGroup.Text)
				{
					row = dgvCardsSource.Rows[dgvCardsSource.Rows.Add()];
					row.Cells[clmCardSourceName.Name].Value = card.Name;
					row.Tag = card;

					if (card == selectedCard)
					{
						row.Selected = true;
					}
				}
			}
		}
		#endregion

		#region RefreshCardsDeck
		private void RefreshCardsDeck()
		{
			DataGridViewRow row = null;
			Card card = null;
			string strSelectedCardID = string.Empty;

			if(dgvCardsDeck.SelectedRows.Count == 1)
			{
				strSelectedCardID = (string)dgvCardsDeck.SelectedRows[0].Tag;
			}

			dgvCardsDeck.Rows.Clear();

			foreach(string strCardID in m_lstCardIDsTemp)
			{
				card = null;
				foreach(Card c in m_CardMaker.Data.Cards)
				{
					if(c.ID == strCardID)
					{
						card = c;
						break;
					}
				}

				if(card != null)
				{
					row = dgvCardsDeck.Rows[dgvCardsDeck.Rows.Add()];
					row.Cells[clmCardDeckName.Name].Value = card.Name;
					row.Tag = strCardID;
				}
			}
		}
		#endregion
	}
}
