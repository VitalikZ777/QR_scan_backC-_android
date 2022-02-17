using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace test_android
{
    [Activity(Label = "test_android", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            //System.Timers.Timer timer = new System.Timers.Timer();
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            TextView edittext1 = FindViewById<TextView>(Resource.Id.editText1);


            button1.Click += async (sender, e) =>
            {
                RunUpdateLoop();
                //  var   timer2 = new Timer(x => OnTimedEvent(), null, TimeSpan.FromSeconds(10), TimeSpan.FromSeconds(10));
                // timer.Interval = 1;
                //  timer.Elapsed += OnTimedEvent;
                // timer.Enabled = true;
            };
            button2.Click += (sender, e) =>
            {
                button1.Enabled = false;
            };
            // Show the percentage on our label.
            //labelPerc.Text = e.ProgressPercentage.ToString() ;

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            //labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
            // (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
            // (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));

            async void RunUpdateLoop()
            {
                int count = 1;
                
                    await Task.Delay(1000);
                   
                    ProgressBar progressBar1= FindViewById<ProgressBar>(Resource.Id.progressBar1);
                    progressBar1.Progress= 50;
                //edittext1.Text = string.Format("{0} ticks!", count++);
                await Task.Delay(1000);

                progressBar1.Progress = 75;
                await Task.Delay(1000);

                progressBar1.Progress = 100;
            }
        }
    }
}
