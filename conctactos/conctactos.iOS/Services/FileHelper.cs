using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using conctactos.iOS.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(FileHelper))]
namespace conctactos.iOS.Services
{
   public  class FileHelper.services.Ifriendhelper
    {
        public FileHelper() { }
     public string GetlocalFilePath(string fileName)
    {
        string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        string libFolder= NSIndexPath.Combine(docFolder,",,","DataBases");
        if (!Directory.Exists(libFolder))
        {
            Directory.CreateDirectory(libFolder);
        }
        return Path.Combine(libFolder, fileName);
    }
    }
}