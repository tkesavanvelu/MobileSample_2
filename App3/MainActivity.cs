using Android.App;
using Android.Widget;
using Android.OS;
using Datalib;

namespace App3
{
	[Activity(Label = "Kesavan", MainLauncher = true)]
	public class MainActivity : Activity
	{

		Button btnNext;
		Button btnPrev;
		TextView txtTitle;
		TextView txtDesc;


		DataManager dMgr;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			btnPrev = FindViewById<Button>(Resource.Id.Prev);
			btnNext = FindViewById<Button>(Resource.Id.Next);
			txtTitle = FindViewById<TextView>(Resource.Id.Title);
			txtDesc = FindViewById<TextView>(Resource.Id.Desc);


			btnPrev.Click += BtnPrev_Click;
			btnNext.Click += BtnNext_Click;

			dMgr = new DataManager();
			dMgr.MoveFirst();
			UpdateUI();


		}

		private void BtnNext_Click(object sender, System.EventArgs e)
		{
			dMgr.MoveNext();
			UpdateUI();	
			
		}

		private void BtnPrev_Click(object sender, System.EventArgs e)
		{
			dMgr.MovePrev();
			UpdateUI();
		}

		private void UpdateUI()
		{
			txtTitle.Text = dMgr.Current.Title;
			txtDesc.Text = dMgr.Current.Description;
		}
	}
}

