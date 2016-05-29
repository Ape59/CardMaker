using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormGame : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		private Game m_Game = null;
		private Card m_Card = null;
		#endregion

		#region Constructor
		public FormGame(CardMaker f_CardMaker, Game f_Game)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;
			m_Game = f_Game;
		}
		#endregion

		#region OnLoad
		private void FormGame_Load(object sender, EventArgs e)
		{
			RefreshCard();
			RefreshGUI();
		}
		#endregion

		#region OnPickCard
		private void btnPickCard_Click(object sender, EventArgs e)
		{
			m_Card = m_Game.PickCard();

			RefreshCard();
			RefreshGUI();
		}
		#endregion

		#region OnCancel
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormMenu(m_CardMaker));
		}
		#endregion

		#region RefreshGUI
		private void RefreshGUI()
		{
			btnPickCard.Enabled = m_Game.StackSize > 0;

			lblStackSize.Text = string.Format("Karten im Stapel: {0}", m_Game.StackSize);
		}
		#endregion

		#region RefreshCard
		private void RefreshCard()
		{
			if (m_Card != null)
			{
				lblName.Text = m_Card.Name;
				lblDescription.Text = m_Card.Description;

				pnlCard.Visible = true;
			}
			else
			{
				pnlCard.Visible = false;
			}
		}
		#endregion
	}
}
