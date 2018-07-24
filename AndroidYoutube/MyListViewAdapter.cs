using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AndroidYoutube
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> people;
        private Context context;

        public MyListViewAdapter(Context context, List<Person> people)
        {
            this.people = people;
            this.context = context;
        }
        public override Person this[int position] => people[position];

        public override int Count => people.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
                row = LayoutInflater.From(context).Inflate(Resource.Layout.listview_row, null, false);

            TextView firstName = row.FindViewById<TextView>(Resource.Id.firstName);
            TextView lastName = row.FindViewById<TextView>(Resource.Id.lastName);
            TextView age = row.FindViewById<TextView>(Resource.Id.age);
            TextView gender = row.FindViewById<TextView>(Resource.Id.gender);

            firstName.Text = people[position].FirstName;
            lastName.Text = people[position].LastName;
            age.Text = people[position].Age;
            gender.Text = people[position].Gender;

            return row;
        }
    }
}