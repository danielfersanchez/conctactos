using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using conctactos.Droid.Services;
using conctactos.services;
[assembly:Dependency(typeof(FileHelper))]
namespace conctactos.Droid.Services
{
    using System;
    using conctactos.services;
    using System.IO;
    public class FileHelper : services.Ifriendhelper
    {
        public FileHelper()
        {

        }
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return path.Combine(path, fileName);
        }
                       
    }

}