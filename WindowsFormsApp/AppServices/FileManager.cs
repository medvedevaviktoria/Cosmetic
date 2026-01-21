using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cosmetic.AppServices
{
    internal class FileManager
    {
        public static string GetImagePath(string fileName)
        {
            return System.IO.Path.Combine(Application.StartupPath, "img", fileName);
        }
    }
}
