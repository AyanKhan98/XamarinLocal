using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App2
{
    class ListViewAdapter : BaseAdapter<string>
    {
        List<string> list;
        Context context;
        public ListViewAdapter(Context context, List<string> list)
        {
            this.context = context;
            this.list = list;
        }
        public override string this[int position]
        {
            get { return list[position]; }
        }


        public override int Count
        {
            get
            {
                return list.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row==null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.List_view_layout, null, false);
            }
            TextView text = row.FindViewById<TextView>(Resource.Id.textName);
            text.Text = list[position];

            return row;

        }
    }
}