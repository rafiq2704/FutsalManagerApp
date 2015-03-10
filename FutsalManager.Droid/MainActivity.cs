﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace FutsalManager.Droid
{
    [Activity(Label = "Super Bobai Cup", ScreenOrientation = ScreenOrientation.Landscape, MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button _newTournamentButton;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _newTournamentButton = FindViewById<Button>(Resource.Id.newTournamentButton);
            _newTournamentButton.Click += delegate { StartActivity(typeof(TournamentSetupActivity)); };

        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.MainMenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.maintainPlayer:
                    StartActivity(typeof(PlayerListActivity));
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }            
        }
    }
}

