using System;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileExplorer
{
    class hartsuul : IComparer
    {
        public enum SORTORDER { DESC, ASC };

        public int columnIndex = 0;                     
        public SORTORDER sortOrder = SORTORDER.ASC;    

        public int Compare(object x, object y)
        {
            FileSystemInfo firstFile = ((ListViewItem)x).Tag as FileSystemInfo;
            FileSystemInfo secondFile = ((ListViewItem)y).Tag as FileSystemInfo;
            
            if (firstFile == null || secondFile == null)
            {
                return 0;
            }
            
            if (firstFile is DirectoryInfo && secondFile is FileInfo)
            {
                return -1;
            }
            if (firstFile is FileInfo && secondFile is DirectoryInfo)
            {
                return 1;
            }
            
            int result = 0;
            switch (columnIndex)
            {
                case 0:
                    result = firstFile.Name.CompareTo(secondFile.Name);
                    break;

                case 1:
                    if (firstFile is FileInfo && secondFile is FileInfo)
                    {
                        result = ((FileInfo)firstFile).Length.CompareTo(((FileInfo)secondFile).Length);
                    }
                    else
                    {
                        return 0;
                    }
                    break;

                case 2:
                    result = firstFile.CreationTime.CompareTo(secondFile.CreationTime);
                    break;

                case 3:
                    result = firstFile.LastWriteTime.CompareTo(secondFile.LastWriteTime);
                    break;

                default:
                    return 0;
            }
            
            if (sortOrder == SORTORDER.ASC)
            {
                return result;
            }
            else
            {
                return (-1) * result;
            }
        }
    }
}