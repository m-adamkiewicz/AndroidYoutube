using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using System.Collections.Generic;

namespace AndroidYoutube
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private List<Person> myListContent;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.content_main);

            ListView peopleView = FindViewById<ListView>(Resource.Id.myListView);

            myListContent = new List<Person>
            {
                new Person{FirstName="Bob",LastName="Johnson",Age="22",Gender="Male"},
                new Person{FirstName="Tom",LastName="Garnett",Age="24",Gender="Male"},
                new Person{FirstName="Susan",LastName="Johnson",Age="19",Gender="Female"},
            };

            peopleView.Adapter = new MyListViewAdapter(this, myListContent);
            peopleView.ItemClick += peopleView_ItemClick;
            peopleView.ItemLongClick += peopleView_ItemLongClick;

        }

        private void peopleView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(myListContent[e.Position].LastName);
        }

        private void peopleView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(myListContent[e.Position].FirstName);
        }
    }
}

