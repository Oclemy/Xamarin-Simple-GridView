using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections;


namespace Simple_GridView
{
    [Activity(Label = "Simple GridView", MainLauncher = true, Icon = "@drawable/simplesmile")]
    public class MainActivity : Activity
    {
        GridView gv;
        ArrayAdapter adapter;
        ArrayList players;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            gv = FindViewById<GridView>(Resource.Id.gv);

            getData();

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, players);

            //BIND
            gv.Adapter = adapter;

            gv.ItemClick += gv_ItemClick;
          
        }

        void gv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, players[e.Position].ToString(), ToastLength.Short).Show();
        }

        //FILL DATA
        private void getData()
        {
            players = new ArrayList();
            players.Add("Juan Mata");
            players.Add("Juan Mata");
            players.Add("Jesus Navas");
            players.Add("John Barnes");
            players.Add("John Doe");
            players.Add("Joel CampBell");
            players.Add("John Moh");
            players.Add("Jose Mou");
            players.Add("Joe Aurorah");
            players.Add("Julius Finch");
            players.Add("July Sasha");
            players.Add("Joan Emmy");
        }


       
    }
}

