using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;

using Microsoft.Maui.ApplicationModel;

using Plugin.Firebase.Core.Platforms.Android;
using Plugin.Firebase.Crashlytics;
using Firebase;

namespace PluginFirebaseTest
{
	[Activity(Label = "Plugin.Firebase Test", Icon = "@mipmap/ic_launcher",  Exported = true)]
	[IntentFilter(new[] {Intent.ActionMain}, Categories = new[] {Intent.CategoryLauncher, Intent.CategoryDefault})]
	public class ActivityStart : Activity
	{

		public ActivityStart() : base() { }

		public ActivityStart(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

		protected override void OnCreate(Bundle bundle)
		{
			Platform.Init(Application);

			base.OnCreate(bundle);

			SetContentView(Resource.Layout.start);

			CrossFirebase.Initialize(this);

			// This line was added after unsuccessfully following the tutorial
			FirebaseApp.InitializeApp(this);

			CrossFirebaseCrashlytics.Current.SetCrashlyticsCollectionEnabled(true);
		}

		
	}
}