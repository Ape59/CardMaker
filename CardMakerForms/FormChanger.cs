using System.Windows.Forms;

namespace CardMakerForms
{
	static class FormChanger
	{
		private static Control m_Parent = null;

		public static void SetParent(Control f_Parent)
		{
			m_Parent = f_Parent;
		}

		public static void SetForm(Form f_Form)
		{
			m_Parent.Controls.Clear();

			f_Form.TopLevel = false;
			f_Form.FormBorderStyle = FormBorderStyle.None;
			f_Form.Dock = DockStyle.Fill;
			f_Form.Show();

			m_Parent.Controls.Add(f_Form);
		}
	}
}
