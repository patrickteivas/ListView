﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListView
{
    class CustomAdapter : BaseAdapter<string>
    {
        readonly string[] items;
        readonly Activity context;

        public CustomAdapter(Activity context, string[] items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override string this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get { return items.Length; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);

             view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position];
            return view;
        }
    }
}