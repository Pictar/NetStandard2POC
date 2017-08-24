﻿using Android.App;
using Android.Widget;
using Android.OS;
using NetStandardClassLibrary;

namespace XamarinAndroidApp
{
    [Activity(Label = "XamarinAndroidApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var test = new TestClass();
            test.TestMethod();
        }
    }
}

