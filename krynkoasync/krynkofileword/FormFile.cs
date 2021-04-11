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

namespace krynkofileword
{
    public partial class FormFile : Form
    {
        public FormFile()
        {
            InitializeComponent();
        }
        private void FormFile_Load(object sender, EventArgs e)
        {

        }


        static int count = 0;

        delegate void addlist(string pathfile);
        void addnewitem(string pathfile)
        {
            listViewWords.Items.Add(pathfile);
        }

        delegate void incr(int count);
        void incrementcount(int count)
        {
            labelCount.Text = count.ToString();
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.ShowDialog();
            labelBrowse.Text = browser.SelectedPath;
        }// Выбор папки

        bool format(string file)
        {
            string str = null;
                for (int i = file.Length - 1; i >= 0; i++)
                {
                    str += file[i];
                    if (file[i] == '.')
                        break;
                }
                return true;

            
            return false;
        }

        #region разбор папок
        async void searchdirAsync(string path)
        {
            await Task.Run(() => searchdir(path));
        }
        void searchdir(string path)
        {
            FileInfo f = new FileInfo(path);
            string[] dirs = Directory.GetDirectories(path);
            if (dirs != null)
                for (int i = 0; i < dirs.Length; i++)
                    searchdirAsync(dirs[i]);
            string[] files = Directory.GetFiles(path);
            if (files != null)
                for (int i = 0; i < files.Length; i++) 
                {
                    if ((files[i].EndsWith(".txt")) || (files[i].EndsWith(".cs")))
                        searchwordAsync(files[i]);
                }
        }
        #endregion

        #region поиск слова в файле
        async void searchwordAsync(string pathfile)
        {
            await Task.Run(() => { searchword(pathfile); });
        }
        void searchword(string pathfile)
        {
            StreamReader reader = new StreamReader(pathfile);
            string line;
            string[] str;
            while ((line = reader.ReadLine()) != null)
            {
                str = line.Split(new char[] { '\t', ' ' });
                foreach (var item in str)
                    if(item == textBoxFword.Text)
                    {
                        addlist adding= addnewitem;
                        listViewWords.Invoke(adding, pathfile);// добавления файла в список
                        count += 1;
                        incr plus = incrementcount;
                        labelCount.Invoke(plus, count);// инкремент каунта
                        reader.ReadToEnd();// перенос курсора на конец
                        break;
                    }
            }
        }
        #endregion

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (listViewWords.Items.Count != 0)
                listViewWords.Items.Clear();
            if (labelCount.Text != "0")
            {
                count = 0;
                labelCount.Text = "0";
            }
            if (!(labelBrowse.Text == "Путь"))
            {
                labelFword.Text = textBoxFword.Text + " = ";
                searchdirAsync(labelBrowse.Text);
            }
            else
                MessageBox.Show("Path is null");

        }
    }
}
