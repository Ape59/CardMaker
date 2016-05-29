using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CardMaker
{
    [Activity(Label = "CardMaker", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
		#region Members
		private Button m_btnSpielen = null;
		private int count = 0;
		#endregion

		#region OnCreate
		protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

			m_btnSpielen = FindViewById<Button>(Resource.Id.MyButton);
			m_btnSpielen.Click += Spielen_Click;
        }
		#endregion

		#region Button Spielen
		private void Spielen_Click(object sender, EventArgs e)
		{
			m_btnSpielen.Text = string.Format("{0} clicks!", count++);
		}
		#endregion
	}
}

