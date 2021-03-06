using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_manadger
{
    public partial class Form1 : Form
    {
        private string filePath = ""; //путь
        private bool isFile = false; //файл
        private bool isStart = true;// начало
        private string currentlySelectedItemName = "";//имя выбранного элемента
        public Form1()
        {
            InitializeComponent();
        }
        private void toStart()//функция начального окна
        {
            filePath = "";
            filePathTextBox.Text = "";
            listView1.Items.Clear();
            string[] Drives = Environment.GetLogicalDrives();
            foreach (string s in Drives)//выводит найденные элементы
            {
                listView1.Items.Add(s, 1);
            }
            isStart = true;
        }

        private void Form1_Load(object sender, EventArgs e)//конструктор формы
        {
            toStart();
        }

        public void loadFilesAndDirectories()//Функция вывода всех найденных файлов и папок в этой папке
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {

                if (isFile)//Если выбранный файл оказывается файлом, то он открывается
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else //взять информацию о файле
                {
                    fileAttr = File.GetAttributes(filePath);

                }

                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)//Если выбранный элемент папка, то открыть и вывести все что в ней
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // получить все файлы
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // получить все директории
                    string fileExtension = "";
                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToUpper();//временная переменная для работы switch
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 4);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 0);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 5);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                        }

                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 1);//добавление папок
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            {

            }
        }

        public void loadButtonAction()//кнопка вперед
        {
            if (isStart != true)
            {
                filePath = removeBackSlash(filePathTextBox.Text);
            }
            else// переход по выбранному пути
            {
                if(listView1.SelectedItems.Count == 0)
                    filePath = removeBackSlash(filePathTextBox.Text);
                else
                    filePath = listView1.SelectedItems[0].Text;
                filePath = filePath.Substring(0, filePath.Length - 2) + ":/";
                isStart = false;
            }
            loadFilesAndDirectories();
            filePathTextBox.Text = filePath;
            isFile = false;
        }

        public string removeBackSlash(string pathfile)
        {//Функция удаления / из пути
            string path = pathfile;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                pathfile = path.Substring(0, path.Length - 1);
            }
            if (!pathfile.Contains("/"))//Если / нет в пути то один добавляется в конце
                pathfile += "/";
            return pathfile;
        }


        public void goBack()//кнопка назад
        {
            try
            {
                if (filePathTextBox.Text.Length == 3 || filePath =="")
                {
                    toStart();//начальное окно
                }
                else
                {//Удаляет не нужные / и названия предыдущей папки
                    string path = removeBackSlash(filePathTextBox.Text);
                    path = path.Substring(0, path.LastIndexOf("/"));
                    this.isFile = false;
                    filePathTextBox.Text = path;
                    loadButtonAction();
                }
            }
            catch (Exception e)
            {

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)//обрабатывает нажатие на элемент
        {
            currentlySelectedItemName = e.Item.Text;
            try
            {
                FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    isFile = false;
                    filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;
                }
                else
                {
                    isFile = true;
                }
            }
            catch
            {
                
            }
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)//обработка двойного щелчка
        {
            loadButtonAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
        }

        private void propertiesFile_Click(object sender, EventArgs e)//свойство
        {
            FileInfo fileInf = new FileInfo(filePath + "/" + currentlySelectedItemName);
            try
            {
                MessageBox.Show("Имя файла: " + fileInf.Name + "\nРазмер: " + fileInf.Length + "\nВремя: " + fileInf.CreationTime + "\nАтрибуты: " + fileInf.Attributes + "\nПрава доступа" + fileInf.LastAccessTime);
            }
            catch
            {

            }
        }

        private void createFile_Click(object sender, EventArgs e)//создание файла
        {
            Form2 dialog = new Form2("Укажите имя файла и расширение","");
            dialog.ShowDialog();
            if (dialog.result.Equals(DialogResult.OK))
            {
                string name = dialog.name;
                File.Create(filePath + "/" + name).Close();
                loadFilesAndDirectories();
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)//копирования папки
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Исходный каталог не существует или не может быть найден : "
                    + sourceDirName);
            }
            DirectoryInfo[] dirs = dir.GetDirectories();
            Directory.CreateDirectory(destDirName);
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }
        private void copyF_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2("Укажите новое расположение файла / папки", filePath);
            dialog.ShowDialog();
            if (dialog.result.Equals(DialogResult.OK))
            {
                try
                {
                    string path = dialog.name;
                    FileInfo info = new FileInfo(filePath + "/" + currentlySelectedItemName);
                    if (info.Attributes.ToString().Equals("Directory"))
                    {
                        DirectoryCopy(filePath + "/" + currentlySelectedItemName, path + "/" + currentlySelectedItemName, true);
                    }
                    else
                    {
                        File.Copy(filePath + "/" + currentlySelectedItemName, path + "/" + currentlySelectedItemName);
                    }
                }
                catch
                {
                    MessageBox.Show("Файл уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteF_Click(object sender, EventArgs e)//кнопка удалить
        {
            FileInfo info = new FileInfo(filePath + "/" + currentlySelectedItemName);
            if (info.Attributes.ToString().Equals("Directory"))
            {

                Directory.Delete(filePath + "/" + currentlySelectedItemName, true);
            }
            else
            {
                File.Delete(filePath + "/" + currentlySelectedItemName);
                isFile = false;
            }
            loadFilesAndDirectories();
        }

        private void createFolder_Click(object sender, EventArgs e)//кнопка создать папку
        {
            Form2 dialog = new Form2("Укажите имя папки","");
            dialog.ShowDialog();
            if (dialog.result.Equals(DialogResult.OK))
            {
                string name = dialog.name;
                Directory.CreateDirectory(filePath + "/" + name);
                loadFilesAndDirectories();
            }
        }

        private void moveFiles_Click(object sender, EventArgs e)//кнопка перемещение
        {
            Form2 dialog = new Form2("Укажите новое расположение файла / папки", filePath);
            dialog.ShowDialog();
            if (dialog.result.Equals(DialogResult.OK))
            {
                try
                {
                    string path = dialog.name;
                    FileInfo info = new FileInfo(filePath + "/" + currentlySelectedItemName);
                    if (info.Attributes.ToString().Equals("Directory"))
                    {
                        Directory.Move(filePath + "/" + currentlySelectedItemName, path + "/" + currentlySelectedItemName);
                    }
                    else
                    {
                        File.Move(filePath + "/" + currentlySelectedItemName, path + "/" + currentlySelectedItemName);
                    }
                    isFile = false;
                    loadFilesAndDirectories();
                }
                catch
                {
                    MessageBox.Show("Файл уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool search(string s)//кнопка поиска
        {
            listView1.Items.Clear();
            try
            {
                foreach (string findedFile in Directory.EnumerateFiles(s, fileSeachTextBox.Text,
                   SearchOption.AllDirectories))
                {
                    FileInfo FI;
                    try
                    {
                        FI = new FileInfo(findedFile);
                        string fileExtension = "";
                        fileExtension = FI.Extension.ToUpper();
                        switch (fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(FI.Name, 2);
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(FI.Name, 4);
                                break;

                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(FI.Name, 6);
                                break;
                            case ".PDF":
                                listView1.Items.Add(FI.Name, 3);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(FI.Name, 0);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(FI.Name, 5);
                                break;

                            default:
                                listView1.Items.Add(FI.Name, 6);
                                break;
                        }
                        filePathTextBox.Text += "/Search";
                        return true;
                    }
                    catch
                    {
                        continue;
                    }

                }
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        private void searchFile_Click(object sender, EventArgs e)//берет первый диск и проверяет все файлы в нем пока не найдет нужные,
                                                                 //если нет то следующий и так либо пока не найдет либо выдаст,
                                                                 //что файла нет
        {

            string[] Drives = Environment.GetLogicalDrives();
            foreach (string s in Drives)
            {
                if (search(s))
                    break;
            }
            if (!filePathTextBox.Text.Contains("Searth"))
            {
                fileSeachTextBox.Text = "";
                if (listView1.Items.Count == 0)
                {
                    MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (filePath == "")
                        toStart();
                    else
                        loadFilesAndDirectories();
                }
            }

        }

        private void reNameFiles_Click(object sender, EventArgs e)//кнопка переименовать
        {
            Form2 dialog = new Form2("Укажите имя файла",currentlySelectedItemName);
            dialog.ShowDialog();
            if (dialog.result.Equals(DialogResult.OK))
            {
                FileInfo info = new FileInfo(filePath + "/" + currentlySelectedItemName);
                if (!info.Attributes.ToString().Equals("Directory"))
                {
                    string name = dialog.name;
                    File.Move(filePath + "/" + currentlySelectedItemName, filePath + "/" + name);
                    currentlySelectedItemName = name;
                    isFile = false;
                    loadFilesAndDirectories();
                }
                else
                {
                    string name = dialog.name;
                    Directory.Move(filePath + "/" + currentlySelectedItemName, filePath + "/" + name);
                    currentlySelectedItemName = name;
                    loadFilesAndDirectories();
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {//заполнение строки
            FileInfo info;
            if (filePath != "")
            {
                info = new FileInfo(filePath + "/" + currentlySelectedItemName);
            }
            else
                info = new FileInfo(currentlySelectedItemName);
            fileNameLabel.Text = info.Name;
            if (!info.Attributes.ToString().Equals("Directory"))
                fileTypeLabel.Text = info.Extension;
            else
                fileTypeLabel.Text = info.Attributes.ToString();
        }
    }
}