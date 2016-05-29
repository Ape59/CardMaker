using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormEditCard : Form
	{
		#region Members
		private CardMaker m_CardMaker = null;
		private Card m_Card = null;
		#endregion

		#region Constructor
		public FormEditCard(CardMaker f_CardMaker, Card f_Card)
		{
			InitializeComponent();

			m_CardMaker = f_CardMaker;
			m_Card = f_Card;
		}
		#endregion

		#region OnLoad
		private void FormEditCard_Load(object sender, EventArgs e)
		{
			edtName.Text = m_Card.Name;
			edtDescription.Text = m_Card.Description;
		}
		#endregion

		#region OnApply
		private void btnApply_Click(object sender, EventArgs e)
		{
			m_Card.Name = edtName.Text;
			m_Card.Description = edtDescription.Text;

			if (m_CardMaker.Data.Cards.Contains(m_Card) == false)
			{
				m_CardMaker.Data.Cards.Add(m_Card);
			}

			if(m_CardMaker.SaveData() == false)
			{
				MessageBox.Show(m_CardMaker.Error, "Fehler beim Speichern", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			FormChanger.SetForm(new FormCards(m_CardMaker, m_Card.Group));
		}
		#endregion

		#region OnCancel
		private void btnCancel_Click(object sender, EventArgs e)
		{
			FormChanger.SetForm(new FormCards(m_CardMaker, m_Card.Group));
		}
		#endregion
	}
}
