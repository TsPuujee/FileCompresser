using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FileExplorer
{
    class zurag
    {
        private Dictionary<string, int> iconCashe = new Dictionary<string, int>();         
        private int reserveRange = 4;                                                      
        
        public int GetIconIndexByExtention(string extention)
        {
            List<string> extentions = iconCashe.Keys.ToList<string>();
            if (extention == null || extention.Length == 0 || extention == ".exe" || extentions.IndexOf(extention) == -1)
            {
                return -1;
            }
            return iconCashe[extention];
        }
        public int AddIconForFile(FileInfo file, ImageList smallIconList, ImageList largeIconList)
        {
            string fileExtention = file.Extension.ToLower();
            
            Icon fileIcon = Icon.ExtractAssociatedIcon(file.FullName);
            if (fileIcon == null)
            {
                return 0;
            }

            smallIconList.Images.Add(fileIcon);
            largeIconList.Images.Add(fileIcon);
            

            if (fileExtention != ".exe" && fileExtention.Length != 0)
            {
                iconCashe.Add(fileExtention, smallIconList.Images.Count - 1);
            }
            

            return smallIconList.Images.Count - 1;
        }
        
        public void ClearIconCashAndLists(ImageList smallIconList, ImageList largeIconList)
        {
            iconCashe.Clear();
            for (int i = reserveRange; i < smallIconList.Images.Count; i++)
            {
                smallIconList.Images.RemoveAt(i);
                largeIconList.Images.RemoveAt(i);
            }
        }
    }
}