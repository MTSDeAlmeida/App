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

namespace App1.Droid.Resources
{
    public class StatusBarHelper
    {
        public static View DecorView
        {
            get;
            set;
        }
        public static ActionBar AppActionBar
        {
            get;
            set;
        }
    }
}