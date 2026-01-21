using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        internal static void DeleteFile(string photo)
        {
            if (string.IsNullOrWhiteSpace(photo))
            {
                return;
            }

            try
            {
                File.Delete(GetImagePath(photo));
            }
            catch (Exception ex)
            {
                Debug.Print($"Не удалось удалить файл {photo}."); // PKGH Отладочная печать.
            }
        }
    }
}
