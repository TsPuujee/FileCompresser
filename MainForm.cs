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
    public partial class Form1 : Form
    {
        static int key = 5;

        public static string Nuutsal(string Message)
        {
            String Message1 = String.Empty;
            foreach (Char a in Message)
            {
                Message1 += (Char)(a + key);
            }
            return Message1;
        }

        public static string Nuutslal_garga(string Message)
        {
            String Message1 = String.Empty;
            foreach (Char a in Message)
            {
                Message1 += (Char)(a - key);
            }
            return Message1;
        }
        public static String t1;
        public static String Display1(Node n, String a, String b)
        {
            if (n != null)
            {
                int a1 = 0;
                if (n.hus().Item1.CompareTo(a) == 0)
                {
                    t1 = b;
                    return b;
                }
                Display1(n.leftLeaf, a, b + "0");
                Display1(n.rightLeaf, a, b + "1");
                return t1;
            }
            return null;
        }

        public static string str;
        public static string strs;
        public static string strs1;
        public static Dictionary<String, int> Dawtamj = new Dictionary<String, int>();
        public static Dictionary<String, String> Code_hus = new Dictionary<String, String>();
        private const int BYTE_IN_KILOBYTE = 1024;
        private const int COLUMN_WIDTH = 120;
        private const int chir_zai = 10;
        
        private string topLevelName = "Компьютер";                                                              
        private string[] viewModes = { "Том зураг", "Жижиг зураг", "Жагсаалт", "Дэлгэрэнгүй" };   
        
        private Dictionary<string, int> columnsFiles = new Dictionary<string, int>();                          
        private Dictionary<string, int> columnsDrives = new Dictionary<string, int>();                         
        private string[] columnsForFiles = { "Нэр", "Хэмжээ", "Үүссэн огноо", "Огноо өөрчлөгдсөн" };
        private string[] columnsForDrives = { "Нэр", "Төрөл", "Файлын систем", "Нийт хэмжээ", "Үлдсэн зай" };   
        
        private List<FileSystemInfo> fileSystemItems = new List<FileSystemInfo>();                              

        private zurag zurag = new zurag();       
        public static int He=0;
        private chireh chir = new chireh();

        public void reset()
        {
            t1 = String.Empty;
            str = String.Empty;
            strs = String.Empty; 
            strs1 = String.Empty;
            Dawtamj.Clear();
            Code_hus.Clear();

        }
        public bool readFile1()
        {
            if (str != null)
            {
                if (str.Contains(".pjl"))
                {
                    using (StreamReader reader = new StreamReader(str))
                    {
                        string line = reader.ReadLine();
                        He = Int32.Parse(Nuutslal_garga(line));
                        for (int i = 0; i < He; i++)
                        {
                            line = Nuutslal_garga(reader.ReadLine());
                            string[] words;
                            words = line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                            Code_hus.Add(words[0],words[1]);
                        }

                        while (true)
                        {
                            String line1 = reader.ReadLine();
                            if (line1 == null)
                            {
                                break;
                            }
                            line = Nuutslal_garga(line1);
                            strs1 = strs1 + line;

                            //Console.WriteLine(Nuutslal_garga(line));
                        }
                        
                    }
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public bool readFile()
        {
            if (str != null)
            {
                if (str.Contains(".txt"))
                {
                    using (StreamReader reader = new StreamReader(str))
                    {
                        while (true)
                        {
                            string line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            strs = strs + line;
                            //Console.WriteLine(Nuutslal_garga(line));
                        }
                    }
                    return true;
                }
                else return false;
            }
            else return false;
        }
        String shine;
        public int  bintodec(String a)
        {
            return Convert.ToInt32(a, 2) ;
        }
        public String dectobin(string a)
        {
            int a1 = Int32.Parse(a);
            return Convert.ToString(a1, 2);
        }
        public static string zad;

        public void zadal()
        {
            if (readFile1() == true)
            {
                String ner = str.Substring(0, str.Length - 4) + "1.txt";
                using (StreamWriter writer = new StreamWriter(ner))
                {
                    for(int i = 0; i < strs1.Length; i++)
                    {
                        String a3;
                        char aa3 = strs1[i];
                        int aaaa3 = aa3;
                        String aaa3 = aaaa3.ToString();
                        a3 = dectobin(aaa3);
                        a3 = a3.PadLeft(8, '0');
                        zad = zad + a3;
                      //  writer.Write(dectobin("180"));
                    }
                    for(int i=0;i<zad.Length;i++)
                    {
                       // label1.Text = String.Empty;
                        foreach (KeyValuePair<String, String> kvp in Code_hus)
                        {
                            //label1.Text = strs1;
                           if (zad.Substring(i).IndexOf(kvp.Value)==0)
                            {
                                if(kvp.Key.CompareTo("*")==0)
                                    writer.Write(" ");
                                else writer.Write(kvp.Key);
                                i = i + kvp.Value.Length-1;
                               
                                break;
                                label1.Text = label1.Text + kvp.Key;
                            }
                        }
                       // writer.Write("puujee");
                    }
                }
                               
            }
        }
        public void shah()
        {
            if (readFile() == true)
            {
                //Console.WriteLine(str);
                foreach (char currentChar in strs)
                {
                    if (Dawtamj.ContainsKey(currentChar.ToString()))
                    { Dawtamj[currentChar.ToString()]++; }
                    else
                    { Dawtamj.Add(currentChar.ToString(), 1); }
                }
                daraalal dar = new daraalal();

                foreach (KeyValuePair<String, int> kvp in Dawtamj)
                {
                    BinaryTree b = new BinaryTree();
                    b.insert(Tuple.Create(kvp.Key, kvp.Value));
                    dar.oruul(b);

                }
                dar.Uusge();

                foreach (KeyValuePair<String, int> kvp in Dawtamj)
                {
                    if (kvp.Key.CompareTo(" ") == 0)
                        Code_hus.Add("*", Display1(dar.asdqwe().root1(), kvp.Key, ""));
                    else
                        Code_hus.Add(kvp.Key, Display1(dar.asdqwe().root1(), kvp.Key, ""));
                }

                String ner = str.Substring(0, str.Length - 4) + ".pjl";
               
                using (StreamWriter writer = new StreamWriter(ner))
                {
                    writer.Write(Nuutsal(Code_hus.Count.ToString()) +"\n");
                    foreach (KeyValuePair<String, String> kvp in Code_hus)
                    {
                        writer.Write(Nuutsal(kvp.Key + " " + kvp.Value) + "\n");

                        //Console.WriteLine("Code {0}:\t{1}", kvp.Key, kvp.Value);
                      //  richTextBox1.Text = richTextBox1.Text + kvp.Key + " " + kvp.Value + "\n";
                    }
                    
                    for (int i = 0; i < strs.Length; i++)
                    {
                        if (strs.Substring(i, 1).CompareTo(" ") == 0)
                        {
                            String code = Code_hus["*"];
                            shine = shine + code;//.PadLeft(6,'0');
                        }
                        else {
                            String code = Code_hus[strs.Substring(i, 1)];
                            shine = shine + code;
                        }
                    }
                    for(int i = 0; i < shine.Length; i = i + 8)
                    {
                        String a;
                        if (shine.Length - i < 8) a = shine.Substring(i, shine.Length - i);
                        else a = shine.Substring(i, 8);
                        String baa = bintodec(a).ToString();
                        //baa = baa.PadLeft(3, '0');
                        int baa1 = Int32.Parse(baa);
                        char baa3 = (char)baa1;
                        String baa2 = baa3.ToString();
                        writer.Write(Nuutsal(baa2));
                    }
                }
            }
            else
            {
                MessageBox.Show( "Та .txt өргөтгөлтэй файл сонгоно уу?","Алдаа" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public Form1()
        {
            InitializeComponent();

            Application.ThreadException += Application_ThreadException;
            

            foreach (string column in columnsForFiles)
            {
                columnsFiles.Add(column, COLUMN_WIDTH);
            }

            foreach (string column in columnsForDrives)
            {
                columnsDrives.Add(column, COLUMN_WIDTH);
            }
            

            foreach (string item in viewModes)
            {
                toolStripComboBox1.Items.Add(item);
            }
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox1.SelectedIndexChanged += toolStripComboBox1_SelectedIndexChanged;
            
            lv_files.MouseDoubleClick += lv_files_MouseDoubleClick;
            lv_files.ColumnClick += lv_files_ColumnClick;
            
            lv_files.View = View.LargeIcon;
            
            tsl_path.Text = topLevelName;
            
            tv_files.BeforeExpand += tv_files_BeforeExpand;
            tv_files.AfterSelect += tv_files_AfterSelect;
            
            tv_files.AfterLabelEdit += tv_files_AfterLabelEdit;
            
            lv_files.MouseDown += lv_files_MouseDown;
            lv_files.MouseMove += lv_files_MouseMove;
            lv_files.DragEnter += lv_files_DragEnter;
            lv_files.DragLeave += lv_files_DragLeave;
            lv_files.DragDrop += lv_files_DragDrop;
            lv_files.QueryContinueDrag += lv_files_QueryContinueDrag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDrives();
        }
        
        void lv_files_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem currentItem = lv_files.GetItemAt(e.X, e.Y);
            if (currentItem != null)
            {
                currentItem.Selected = true;
                chir.isSelected = true;
                chir.startPositionPoint.X = e.X;
                chir.startPositionPoint.Y = e.Y;
            }
        }

        void lv_files_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && chir.isSelected)
            {
                chir.currentPositionPoint.X = e.X;
                chir.currentPositionPoint.Y = e.Y;

                if (chir.GetDistance() >= chir_zai)
                {
                    ListViewItem currentLvi = lv_files.GetItemAt(e.X, e.Y);
                    if (currentLvi == null)
                    {
                        return;
                    }
                    lv_files.DoDragDrop(currentLvi, DragDropEffects.Move);
                    chir.isDrag = true;
                }
            }
        }

        void lv_files_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        void lv_files_DragLeave(object sender, EventArgs e)
        {
            chir.isDrag = false;
        }

        void lv_files_DragDrop(object sender, DragEventArgs e)
        {
            chir = new chireh();
            
            Point clPoint = lv_files.PointToClient(new Point(e.X, e.Y));
            ListViewItem destItem = lv_files.GetItemAt(clPoint.X, clPoint.Y);

            if (destItem != null)
            {
                DirectoryInfo destDirectory = destItem.Tag as DirectoryInfo;

                if (destDirectory == null)
                {
                    return;
                }
                else
                {
                    ListViewItem tempLvi = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                    FileSystemInfo tempFsi = (FileSystemInfo)tempLvi.Tag;
                    DirectoryInfo tempDi = tempFsi as DirectoryInfo;
                    if (tempDi != null)
                    {
                        if (tempDi == destDirectory)
                        {
                            return;
                        }
                    }
                }
                
                ListViewItem srcItem = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                FileSystemInfo srcFileSystemItem = srcItem.Tag as FileSystemInfo;
                
                string newPath = Path.Combine(destDirectory.FullName, srcFileSystemItem.Name);
                if (MoveFileObject(srcFileSystemItem, newPath))
                {
                    if (SetFileSystemItems(tsl_path.Text))
                    {
                        ShowFileSystemItems();
                    }
                    
                    tv_files.SelectedNode.Collapse();
                    tv_files.SelectedNode.Expand();
                }
            }
        }
        
        void lv_files_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
            if (!chir.isDrag)
            {
                e.Action = DragAction.Cancel;
            }
        }
        
        void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedItem.ToString())
            {
                case "Том зураг":
                    lv_files.View = View.LargeIcon;
                    break;
                case "Жижиг зураг":
                    lv_files.View = View.SmallIcon;
                    break;
                case "Дэлгэрэнгүй":
                    lv_files.View = View.Details;
                    lv_files.FullRowSelect = true;
                    break;
                case "Жагсаалт":
                    lv_files.View = View.List;
                    break;
                default:
                    MessageBox.Show("Ийм горим байхгүй", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        

        void lv_files_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selection = lv_files.GetItemAt(e.X, e.Y);
            object tag = selection.Tag;
            if (tag is FileInfo)
            {
                str = ((FileInfo)tag).FullName;
                label1.Text = ((FileInfo)tag).FullName;
                return;
            }
            string path = null;
            if (tag is DriveInfo)
            {
                path = ((DriveInfo)tag).RootDirectory.ToString();
            }
            else if (tag is DirectoryInfo)
                {
                    path = ((DirectoryInfo)tag).FullName;
                }
            if (SetFileSystemItems(path))
            {
                ShowFileSystemItems();
                tsl_path.Text = path;
                ShowPathInTree(path);
            }
        }
        
        void tsb_upLevel_Click(object sender, EventArgs e)
        {
            string path = tsl_path.Text;
            if (path == topLevelName)
            {
                return;
            }
            DirectoryInfo currentDirectory = new DirectoryInfo(path);
            DirectoryInfo parentDirectory = currentDirectory.Parent;
            if (parentDirectory != null)
            {
                SetFileSystemItems(parentDirectory.FullName);
                ShowFileSystemItems();
                tsl_path.Text = parentDirectory.FullName;
                ShowPathInTree(tsl_path.Text);
            }
            else
            {
                ShowDrives();
            }
        }
        

        void lv_files_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        
            if (tsl_path.Text == topLevelName)
            {
                return;
            }
            
            int currentColumn = e.Column;
            
            hartsuul currentComparer = (hartsuul)lv_files.ListViewItemSorter;
            
            if (currentComparer == null)
            {
                currentComparer = new hartsuul();
            }
            
            if (currentColumn == currentComparer.columnIndex)
            {
                if (currentComparer.sortOrder == hartsuul.SORTORDER.ASC)
                {
                    currentComparer.sortOrder = hartsuul.SORTORDER.DESC;
                    lv_files.Columns[currentColumn].ImageIndex = 3;
                }
                else
                {
                    currentComparer.sortOrder = hartsuul.SORTORDER.ASC;
                    lv_files.Columns[currentColumn].ImageIndex = 2;
                }
            }
            
            else
            {
                lv_files.Columns[currentComparer.columnIndex].ImageIndex = -1;
                lv_files.Columns[currentComparer.columnIndex].TextAlign = HorizontalAlignment.Center;
                lv_files.Columns[currentComparer.columnIndex].TextAlign = HorizontalAlignment.Left;

                currentComparer.columnIndex = currentColumn;
                currentComparer.sortOrder = hartsuul.SORTORDER.ASC;
                lv_files.Columns[currentColumn].ImageIndex = 2;
            }
            
            lv_files.ListViewItemSorter = currentComparer;
            lv_files.Sort();
        }
        
        void tv_files_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode currentNode = e.Node;
            
            currentNode.Nodes.Clear();

            string[] directories = Directory.GetDirectories(currentNode.FullPath);
            foreach (string directory in directories)
            {
                TreeNode t = new TreeNode(Path.GetFileName(directory), 0, 1);
                currentNode.Nodes.Add(t);

                try
                {
                    string[] a = Directory.GetDirectories(directory);
                    if (a.Length > 0)
                    {
                        t.Nodes.Add("?");
                    }
                }
                catch { }
            }
        }
        
        void tv_files_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            string currentPath = e.Node.FullPath;
            
            selectedNode.Expand();
            
            if (SetFileSystemItems(currentPath))
            {
                ShowFileSystemItems();
                tsl_path.Text = currentPath;
            }
            
            else
            {
                ShowPathInTree(tsl_path.Text);
            }
        }
        
        void tv_files_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
        
            string currentPath = e.Node.FullPath;
            string newDirectoryName = e.Label;

            if (newDirectoryName == null || newDirectoryName.Trim().Length == 0)
            {
                e.CancelEdit = true;
                return;
            }
            
            string newFullName = Path.Combine(e.Node.Parent.FullPath, newDirectoryName);
            
            DirectoryInfo currentDirectory = new DirectoryInfo(currentPath);
            
            try
            {
                currentDirectory.MoveTo(newFullName);
                
                if (SetFileSystemItems(newFullName))
                {
                    ShowFileSystemItems();
                    tsl_path.Text = newFullName;
                }
            }
            catch
            {
                MessageBox.Show("Алдаа гарлаа", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.CancelEdit = true;
            }
        }
        
        
        public bool SetFileSystemItems(string path)
        {
            
            try
            {
                string[] access = Directory.GetDirectories(path);
            }
            catch 
            {
                MessageBox.Show("Алдаа гарлаа", "Алдаа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            if (fileSystemItems != null && fileSystemItems.Count != 0)
            {
                fileSystemItems.Clear();
            }
            
            string[] directories = Directory.GetDirectories(path);
            foreach (string directory in directories)
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                fileSystemItems.Add(di);
            }
            
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                fileSystemItems.Add(fi);
            }

            return true;
        }
        
        private void ShowFileSystemItems()
        {
            lv_files.BeginUpdate();
            
            lv_files.Items.Clear();

            if (fileSystemItems == null || fileSystemItems.Count == 0)
            {
                return;
            }
            
            SetColumsForFolders();                          
            
            zurag.ClearIconCashAndLists(il_DiscFoldersFilesIcons_Small, il_DiscFoldersFilesIcons_Large);
            
            ListViewItem lviFile = null;
            foreach (FileSystemInfo file in fileSystemItems)
            {
                    
                lviFile = new ListViewItem();
                lviFile.Tag = file;
                lviFile.Text = file.Name;
                
                if (file is DirectoryInfo)
                {
                    lviFile.ImageIndex = 1;
                    lviFile.SubItems.Add("Хавтас");
                }
                
                else if (file is FileInfo)
                {
                    FileInfo currentFile = file as FileInfo;
                    if (currentFile == null) 
                    {
                        return;
                    }

                    string fileExtention = currentFile.Extension.ToLower();
                    
                    int iconIndex = zurag.GetIconIndexByExtention(fileExtention);
                    
                    if (iconIndex != -1)
                    {
                        lviFile.ImageIndex = iconIndex;
                    }

                    
                    else
                    {
                        lviFile.ImageIndex = zurag.AddIconForFile((FileInfo)file, il_DiscFoldersFilesIcons_Small, il_DiscFoldersFilesIcons_Large);
                    }
                    lviFile.SubItems.Add(((FileInfo)file).Length.ToString());
                }
                lviFile.SubItems.Add(file.CreationTime.ToString());
                lviFile.SubItems.Add(file.LastWriteTime.ToString());

                lv_files.Items.Add(lviFile);

                lv_files.EndUpdate();
            }
        }
        
        private void ShowDrives()
        {
            tsl_path.Text = topLevelName;
            
            if (lv_files != null && lv_files.Items.Count != 0)
            {
                lv_files.Items.Clear();
            }
            if (tv_files != null && tv_files.Nodes.Count != 0)
            {
                tv_files.Nodes.Clear();
            }
            
            DriveInfo[] discs = DriveInfo.GetDrives();

            if (discs.Length == 0)
            {
                MessageBox.Show("Диск олдсонгүй", "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            
            SetColumsForDrives();

            ListViewItem lviDisc;
            foreach (DriveInfo disc in discs)
            {
                if (disc.IsReady)
                {
                    string totalSize = String.Format("{0:F2} GB", (double)disc.TotalSize / (BYTE_IN_KILOBYTE * BYTE_IN_KILOBYTE * BYTE_IN_KILOBYTE));             //в Гб
                    string freeSpace = String.Format("{0:F2} GB", (double)disc.TotalFreeSpace / (BYTE_IN_KILOBYTE * BYTE_IN_KILOBYTE * BYTE_IN_KILOBYTE));        //в Гб

                    lviDisc = new ListViewItem(disc.Name, 0);
                    lviDisc.SubItems.Add(disc.DriveType.ToString());
                    lviDisc.SubItems.Add(disc.DriveFormat.ToString());
                    lviDisc.SubItems.Add(totalSize);
                    lviDisc.SubItems.Add(freeSpace);

                    lviDisc.Tag = disc;

                    lv_files.Items.Add(lviDisc);
                }
            }

            foreach (DriveInfo disc in discs)
            {
                if(disc.IsReady)
                {
            
                    TreeNode tnDisc = new TreeNode(disc.Name, 2, 2);
                    tv_files.Nodes.Add(tnDisc);
            
                    try
                    {
                        string[] directoriesInDisc = Directory.GetDirectories(disc.RootDirectory.ToString());
                        if (directoriesInDisc.Length > 0)
                        {
                            TreeNode tempNode = new TreeNode("?");
                            tnDisc.Nodes.Add(tempNode);
                        }
                    }
                    catch { }
                }
            }
            
        }
        
        private void ShowPathInTree(string path)
        {
        
            string[] directories = path.Split('\\');
            
            string root = Path.GetPathRoot(path);
            
            TreeNode currentNode = null;
            foreach (TreeNode treeNode in tv_files.Nodes)
            {
                if (treeNode.Text == root)
                {
                    treeNode.Expand();
                    currentNode = treeNode;
                    break;
                }
            }
            
            for (int i = 1; i < directories.Length; i++)
            {
            
                if (directories[i].Length == 0) 
                {
                    continue;
                }
                
                foreach (TreeNode treeNode in currentNode.Nodes)
                {
                    if (treeNode.Text == directories[i])
                    {
                        treeNode.Expand();
                        currentNode = treeNode;
                    }
                }
            }
            
            tv_files.SelectedNode = currentNode;
        }

        private bool MoveFileObject(FileSystemInfo fsObject, string newPath)
        {
            string message = "";
            try
            {
                if (fsObject is DirectoryInfo)
                {
                    message = "Алдаа гарлаа";
                    ((DirectoryInfo)fsObject).MoveTo(newPath);
                }
                else
                {
                    message = "Файлыг зөөх боломжгүй байна";
                    ((FileInfo)fsObject).MoveTo(newPath);
                }
                return true;
            }
            catch
            {
                MessageBox.Show(message, "Анхааруулга", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        
        private void SetColumsForDrives()
        {
            if (lv_files.Columns.Count != 0)
            {
                lv_files.Columns.Clear();
            }

            ColumnHeader column = null;
            foreach (KeyValuePair<string, int> item in columnsDrives)
            {
                column = new ColumnHeader();
                column.Text = item.Key;
                column.Width = item.Value;
                column.TextAlign = HorizontalAlignment.Left;
                lv_files.Columns.Add(column);
            }
        }

        private void SetColumsForFolders()
        {
            if (lv_files.Columns.Count != 0)
            {
                lv_files.Columns.Clear();
            }
        
            int sortedColumnIndex = 0;
            hartsuul.SORTORDER sortOrder = hartsuul.SORTORDER.ASC;
            
            hartsuul currentComparer = (hartsuul)lv_files.ListViewItemSorter;
            if (currentComparer != null)
            {
                sortedColumnIndex = currentComparer.columnIndex;
                sortOrder = currentComparer.sortOrder;
            }
            
            ColumnHeader column = null;
            int currentColumnIndex = 0;
            foreach (KeyValuePair<string, int> item in columnsFiles)
            {
                column = new ColumnHeader();
                column.Text = item.Key;
                column.Width = item.Value;
                
                if (sortedColumnIndex == currentColumnIndex)
                {
                    if (sortOrder == hartsuul.SORTORDER.ASC)
                    {
                        column.ImageIndex = 2;
                    }
                    else
                    {
                        column.ImageIndex = 3;
                    }
                }

                lv_files.Columns.Add(column);
                currentColumnIndex++;
            }
        }

        private void tv_files_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            shah();
            reset();
            string path = tsl_path.Text;
            if (path == topLevelName)
            {
                return;
            }
            DirectoryInfo parentDirectory = new DirectoryInfo(path);
            if (parentDirectory != null)
            {
                SetFileSystemItems(parentDirectory.FullName);
                ShowFileSystemItems();
                tsl_path.Text = parentDirectory.FullName;
                ShowPathInTree(tsl_path.Text);
            }
            else
            {
                ShowDrives();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            zadal();
            reset();
            string path = tsl_path.Text;
            if (path == topLevelName)
            {
                return;
            }
            DirectoryInfo parentDirectory = new DirectoryInfo(path);
            if (parentDirectory != null)
            {
                SetFileSystemItems(parentDirectory.FullName);
                ShowFileSystemItems();
                tsl_path.Text = parentDirectory.FullName;
                ShowPathInTree(tsl_path.Text);
            }
            else
            {
                ShowDrives();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}