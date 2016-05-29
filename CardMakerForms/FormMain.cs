using System;
using System.Windows.Forms;

using CardMakerLib;

namespace CardMakerForms
{
	public partial class FormMain : Form
	{
		#region Members
		private CardMaker m_CardMaker = new CardMaker();
		#endregion

		#region Constructor
		public FormMain()
		{
			InitializeComponent();
		}
		#endregion

		#region OnLoad
		private void FormMain_Load(object sender, EventArgs e)
		{
			if (m_CardMaker.LoadData(Application.StartupPath + "\\CardMakerData.xml") == false)
			{
				MessageBox.Show(m_CardMaker.Error, "Fehler beim Laden", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			FormChanger.SetParent(this);
			FormChanger.SetForm(new FormMenu(m_CardMaker));
		}
		#endregion
	}
}
