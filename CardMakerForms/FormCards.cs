using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormCards : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		#endregion

		#region Constructor
		public FormCards(CardMaker f_CardMaker, string f_strGroup)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;

			cmbGroup.Text = f_strGroup;
		}
		#endregion

		#region OnLoad
		private void FormCards_Load(object sender, EventArgs e)
		{
			RefreshGroups();
			RefreshButtons();
			RefreshCards();
		}
		#endregion

		#region OnTextChanged
		private void cmbGroup_TextChanged(object sender, EventArgs e)
		{
			RefreshButtons();
			RefreshCards();
		}
		#endregion

		#region OnSelectionChanged
		private void dgvCards_SelectionChanged(object sender, EventArgs e)
		{
			RefreshButtons();
		}
		#endregion

		#region OnAddCard
		private void btnAddCard_Click(object sender, EventArgs e)
		{
			Card card = null;

			if (cmbGroup.Text.Length > 0)
			{
				card = new Card();
				card.ID = Guid.NewGuid().ToString();
				card.Group = cmbGroup.Text;

				FormChanger.SetForm(new FormEditCard(m_CardMaker, card));
			}
		}
		#endregion

		#region OnEditCard
		private void btnEditCard_Click(object sender, EventArgs e)
		{
			Card selectedCard = null;

			if (dgvCards.SelectedRows.Count == 1)
			{
				selectedCard = (Card)dgvCards.SelectedRows[0].Tag;

				FormChanger.SetForm(new FormEditCard(m_CardMaker, selectedCard));
			}
		}
		#endregion

		#region OnRemoveCard
		private void btnRemoveCard_Click(object sender, EventArgs e)
		{
			Card selectedCard = null;

			if (dgvCards.SelectedRows.Count == 1)
			{
				selectedCard = (Card)dgvCards.SelectedRows[0].Tag;

				m_CardMaker.Data.Cards.Remove(selectedCard);

				if (m_CardMaker.SaveData() == false)
				{
					MessageBox.Show(m_CardMaker.Error, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				RefreshGroups();
				RefreshButtons();
				RefreshCards();
			}
		}
		#endregion

		#region OnCancel
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormMenu(m_CardMaker));
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
			btnAddCard.Enabled = cmbGroup.Text.Length > 0;
			btnEditCard.Enabled = dgvCards.SelectedRows.Count == 1;
			btnRemoveCard.Enabled = dgvCards.SelectedRows.Count == 1;
		}
		#endregion

		#region RefreshCards
		private void RefreshCards()
		{
			DataGridViewRow row = null;
			Card selectedCard = null;

			if(dgvCards.SelectedRows.Count == 1)
			{
				selectedCard = (Card)dgvCards.SelectedRows[0].Tag;
			}

			dgvCards.Rows.Clear();

			foreach(Card card in m_CardMaker.Data.Cards)
			{
				if(card.Group == cmbGroup.Text)
				{
					row = dgvCards.Rows[dgvCards.Rows.Add()];
					row.Cells[clmCardName.Name].Value = card.Name;
					row.Tag = card;

					if(card == selectedCard)
					{
						row.Selected = true;
					}
				}
			}
		}
		#endregion
	}
}
