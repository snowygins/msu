
namespace File_manadger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.propertiesFile = new System.Windows.Forms.Button();
            this.createFile = new System.Windows.Forms.Button();
            this.createFolder = new System.Windows.Forms.Button();
            this.copyF = new System.Windows.Forms.Button();
            this.deleteF = new System.Windows.Forms.Button();
            this.moveFiles = new System.Windows.Forms.Button();
            this.searchFile = new System.Windows.Forms.Button();
            this.fileSeachTextBox = new System.Windows.Forms.TextBox();
            this.reNameFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1063, 0);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Вперед";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(8, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1130, 493);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "doc.png");
            this.iconList.Images.SetKeyName(1, "folder.jpg");
            this.iconList.Images.SetKeyName(2, "mp3.jpg");
            this.iconList.Images.SetKeyName(3, "pdf.jpg");
            this.iconList.Images.SetKeyName(4, "exe.jpg");
            this.iconList.Images.SetKeyName(5, "png.png");
            this.iconList.Images.SetKeyName(6, "text.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя файла";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(88, 597);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(18, 17);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(936, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип файла";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(1069, 597);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(18, 17);
            this.fileTypeLabel.TabIndex = 6;
            this.fileTypeLabel.Text = "--";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(81, 0);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(976, 22);
            this.filePathTextBox.TabIndex = 7;
            // 
            // propertiesFile
            // 
            this.propertiesFile.Location = new System.Drawing.Point(348, 28);
            this.propertiesFile.Name = "propertiesFile";
            this.propertiesFile.Size = new System.Drawing.Size(89, 23);
            this.propertiesFile.TabIndex = 8;
            this.propertiesFile.Text = "Свойства";
            this.propertiesFile.UseVisualStyleBackColor = true;
            this.propertiesFile.Click += new System.EventHandler(this.propertiesFile_Click);
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(0, 57);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(128, 23);
            this.createFile.TabIndex = 9;
            this.createFile.Text = "Создать файл";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.createFile_Click);
            // 
            // createFolder
            // 
            this.createFolder.Location = new System.Drawing.Point(0, 28);
            this.createFolder.Name = "createFolder";
            this.createFolder.Size = new System.Drawing.Size(128, 23);
            this.createFolder.TabIndex = 10;
            this.createFolder.Text = "Создать папку";
            this.createFolder.UseVisualStyleBackColor = true;
            this.createFolder.Click += new System.EventHandler(this.createFolder_Click);
            // 
            // copyF
            // 
            this.copyF.Location = new System.Drawing.Point(176, 28);
            this.copyF.Name = "copyF";
            this.copyF.Size = new System.Drawing.Size(132, 23);
            this.copyF.TabIndex = 11;
            this.copyF.Text = "Копировать";
            this.copyF.UseVisualStyleBackColor = true;
            this.copyF.Click += new System.EventHandler(this.copyF_Click);
            // 
            // deleteF
            // 
            this.deleteF.Location = new System.Drawing.Point(348, 57);
            this.deleteF.Name = "deleteF";
            this.deleteF.Size = new System.Drawing.Size(89, 23);
            this.deleteF.TabIndex = 12;
            this.deleteF.Text = "Удалить";
            this.deleteF.UseVisualStyleBackColor = true;
            this.deleteF.Click += new System.EventHandler(this.deleteF_Click);
            // 
            // moveFiles
            // 
            this.moveFiles.Location = new System.Drawing.Point(176, 57);
            this.moveFiles.Name = "moveFiles";
            this.moveFiles.Size = new System.Drawing.Size(132, 23);
            this.moveFiles.TabIndex = 13;
            this.moveFiles.Text = "Переместить";
            this.moveFiles.UseVisualStyleBackColor = true;
            this.moveFiles.Click += new System.EventHandler(this.moveFiles_Click);
            // 
            // searchFile
            // 
            this.searchFile.Location = new System.Drawing.Point(742, 29);
            this.searchFile.Name = "searchFile";
            this.searchFile.Size = new System.Drawing.Size(75, 23);
            this.searchFile.TabIndex = 14;
            this.searchFile.Text = "Поиск";
            this.searchFile.UseVisualStyleBackColor = true;
            this.searchFile.Click += new System.EventHandler(this.searchFile_Click);
            // 
            // fileSeachTextBox
            // 
            this.fileSeachTextBox.Location = new System.Drawing.Point(823, 29);
            this.fileSeachTextBox.Name = "fileSeachTextBox";
            this.fileSeachTextBox.Size = new System.Drawing.Size(315, 22);
            this.fileSeachTextBox.TabIndex = 15;
            // 
            // reNameFiles
            // 
            this.reNameFiles.Location = new System.Drawing.Point(490, 29);
            this.reNameFiles.Name = "reNameFiles";
            this.reNameFiles.Size = new System.Drawing.Size(143, 23);
            this.reNameFiles.TabIndex = 16;
            this.reNameFiles.Text = "Переименовать";
            this.reNameFiles.UseVisualStyleBackColor = true;
            this.reNameFiles.Click += new System.EventHandler(this.reNameFiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 623);
            this.Controls.Add(this.reNameFiles);
            this.Controls.Add(this.fileSeachTextBox);
            this.Controls.Add(this.searchFile);
            this.Controls.Add(this.moveFiles);
            this.Controls.Add(this.deleteF);
            this.Controls.Add(this.copyF);
            this.Controls.Add(this.createFolder);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.propertiesFile);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Файловый менеджер MSU-FM-SDI-2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button propertiesFile;
        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.Button createFolder;
        private System.Windows.Forms.Button copyF;
        private System.Windows.Forms.Button deleteF;
        private System.Windows.Forms.Button moveFiles;
        private System.Windows.Forms.Button searchFile;
        private System.Windows.Forms.TextBox fileSeachTextBox;
        private System.Windows.Forms.Button reNameFiles;
    }
}

