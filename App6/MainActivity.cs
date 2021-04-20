using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;

namespace App6
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText Email;
        EditText Password;
        Button Login;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Email = FindViewById<EditText>(Resource.Id.userEmail);
            Password = FindViewById<EditText>(Resource.Id.userPassword);
            Login = FindViewById<Button>(Resource.Id.btnLogin);

            Login.Click += Login_Click;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (Email.Text == "example@gmail.com" && Password.Text == "12345")
            {
                Intent intent = new Intent(this, typeof(DashboardActivity));
                StartActivity(intent);
                //Toast.MakeText(this, "Login Successful", ToastLength.Long).Show();
            }
            else
            {
                Toast.MakeText(this, "Invalid Login", ToastLength.Long).Show();
            }
        }
    }
}