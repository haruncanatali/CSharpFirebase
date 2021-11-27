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

namespace XamarinFirebaseCRUD
{
    public static class DboAnahtar
    {
        public static string AuthSecret { get; set; } = "yourAuthKey";
        public static string BasePath { get; set; } = "yourBasePath";
    }
}