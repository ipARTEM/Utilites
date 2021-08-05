
namespace Utilites
{
    partial class Utilite
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
            System.Windows.Forms.TabControl Counter;
            this.Счётчик1 = new System.Windows.Forms.TabPage();
            this.labelCounter = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CBRandom = new System.Windows.Forms.CheckBox();
            this.BRandomCopy = new System.Windows.Forms.Button();
            this.BRandomCler = new System.Windows.Forms.Button();
            this.TBRandom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelRandom = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RTBNotepad = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIInserDate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIInserTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CLBPass = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BCreatePassword = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.NUDPassLeng = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CBFrom = new System.Windows.Forms.ComboBox();
            this.CBTo = new System.Windows.Forms.ComboBox();
            this.BConvert = new System.Windows.Forms.Button();
            this.TBFrom = new System.Windows.Forms.TextBox();
            this.TBTo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CBMetric = new System.Windows.Forms.ComboBox();
            Counter = new System.Windows.Forms.TabControl();
            Counter.SuspendLayout();
            this.Счётчик1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPassLeng)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Counter
            // 
            Counter.Controls.Add(this.tabPage4);
            Counter.Controls.Add(this.tabPage3);
            Counter.Controls.Add(this.Счётчик1);
            Counter.Controls.Add(this.tabPage2);
            Counter.Controls.Add(this.tabPage1);
            Counter.Dock = System.Windows.Forms.DockStyle.Fill;
            Counter.Location = new System.Drawing.Point(0, 24);
            Counter.Name = "Counter";
            Counter.SelectedIndex = 0;
            Counter.Size = new System.Drawing.Size(800, 426);
            Counter.TabIndex = 0;
            // 
            // Счётчик1
            // 
            this.Счётчик1.Controls.Add(this.labelCounter);
            this.Счётчик1.Controls.Add(this.buttonReset);
            this.Счётчик1.Controls.Add(this.buttonMinus);
            this.Счётчик1.Controls.Add(this.buttonPlus);
            this.Счётчик1.Location = new System.Drawing.Point(4, 22);
            this.Счётчик1.Name = "Счётчик1";
            this.Счётчик1.Padding = new System.Windows.Forms.Padding(3);
            this.Счётчик1.Size = new System.Drawing.Size(792, 400);
            this.Счётчик1.TabIndex = 0;
            this.Счётчик1.Text = "Счётчик";
            this.Счётчик1.UseVisualStyleBackColor = true;
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCounter.Location = new System.Drawing.Point(277, 135);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(25, 25);
            this.labelCounter.TabIndex = 3;
            this.labelCounter.Text = "0";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(370, 135);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(90, 34);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(245, 209);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(90, 34);
            this.buttonMinus.TabIndex = 1;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(245, 48);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(90, 34);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CBRandom);
            this.tabPage2.Controls.Add(this.BRandomCopy);
            this.tabPage2.Controls.Add(this.BRandomCler);
            this.tabPage2.Controls.Add(this.TBRandom);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.labelRandom);
            this.tabPage2.Controls.Add(this.buttonRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CBRandom
            // 
            this.CBRandom.AutoSize = true;
            this.CBRandom.Location = new System.Drawing.Point(381, 85);
            this.CBRandom.Name = "CBRandom";
            this.CBRandom.Size = new System.Drawing.Size(127, 17);
            this.CBRandom.TabIndex = 9;
            this.CBRandom.Text = "Добавить в TextBox";
            this.CBRandom.UseVisualStyleBackColor = true;
            // 
            // BRandomCopy
            // 
            this.BRandomCopy.Location = new System.Drawing.Point(381, 292);
            this.BRandomCopy.Name = "BRandomCopy";
            this.BRandomCopy.Size = new System.Drawing.Size(75, 23);
            this.BRandomCopy.TabIndex = 8;
            this.BRandomCopy.Text = "Копировать";
            this.BRandomCopy.UseVisualStyleBackColor = true;
            this.BRandomCopy.Click += new System.EventHandler(this.BRandomCopy_Click);
            // 
            // BRandomCler
            // 
            this.BRandomCler.Location = new System.Drawing.Point(381, 337);
            this.BRandomCler.Name = "BRandomCler";
            this.BRandomCler.Size = new System.Drawing.Size(75, 23);
            this.BRandomCler.TabIndex = 7;
            this.BRandomCler.Text = "Очистить";
            this.BRandomCler.UseVisualStyleBackColor = true;
            this.BRandomCler.Click += new System.EventHandler(this.BRandomCler_Click);
            // 
            // TBRandom
            // 
            this.TBRandom.Location = new System.Drawing.Point(164, 135);
            this.TBRandom.Multiline = true;
            this.TBRandom.Name = "TBRandom";
            this.TBRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBRandom.Size = new System.Drawing.Size(184, 225);
            this.TBRandom.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "От";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(228, 85);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(228, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelRandom
            // 
            this.labelRandom.AutoSize = true;
            this.labelRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRandom.Location = new System.Drawing.Point(374, 135);
            this.labelRandom.Name = "labelRandom";
            this.labelRandom.Size = new System.Drawing.Size(0, 39);
            this.labelRandom.TabIndex = 1;
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(381, 28);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(75, 23);
            this.buttonRandom.TabIndex = 0;
            this.buttonRandom.Text = "Задать";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RTBNotepad);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(792, 400);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Блокнот";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RTBNotepad
            // 
            this.RTBNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBNotepad.Location = new System.Drawing.Point(0, 0);
            this.RTBNotepad.Name = "RTBNotepad";
            this.RTBNotepad.Size = new System.Drawing.Size(792, 400);
            this.RTBNotepad.TabIndex = 0;
            this.RTBNotepad.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.блокнотToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // TSMIExit
            // 
            this.TSMIExit.Name = "TSMIExit";
            this.TSMIExit.Size = new System.Drawing.Size(109, 22);
            this.TSMIExit.Text = "Выход";
            this.TSMIExit.Click += new System.EventHandler(this.TSMIExit_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAbout});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // TSMIAbout
            // 
            this.TSMIAbout.Name = "TSMIAbout";
            this.TSMIAbout.Size = new System.Drawing.Size(149, 22);
            this.TSMIAbout.Text = "О программе";
            this.TSMIAbout.Click += new System.EventHandler(this.TSMIAbout_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIInserDate,
            this.TSMIInserTime,
            this.toolStripMenuItem2,
            this.TSMISave,
            this.TSMIDownload});
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // TSMIInserDate
            // 
            this.TSMIInserDate.Name = "TSMIInserDate";
            this.TSMIInserDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.TSMIInserDate.Size = new System.Drawing.Size(199, 22);
            this.TSMIInserDate.Text = "Вставить дату";
            this.TSMIInserDate.Click += new System.EventHandler(this.TSMIInserDate_Click);
            // 
            // TSMIInserTime
            // 
            this.TSMIInserTime.Name = "TSMIInserTime";
            this.TSMIInserTime.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.TSMIInserTime.Size = new System.Drawing.Size(199, 22);
            this.TSMIInserTime.Text = "Вставить время";
            this.TSMIInserTime.Click += new System.EventHandler(this.TSMIInserTime_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // TSMISave
            // 
            this.TSMISave.Name = "TSMISave";
            this.TSMISave.Size = new System.Drawing.Size(199, 22);
            this.TSMISave.Text = "Сохранить";
            this.TSMISave.Click += new System.EventHandler(this.TSMISave_Click);
            // 
            // TSMIDownload
            // 
            this.TSMIDownload.Name = "TSMIDownload";
            this.TSMIDownload.Size = new System.Drawing.Size(199, 22);
            this.TSMIDownload.Text = "Загрузить";
            this.TSMIDownload.Click += new System.EventHandler(this.TSMIDownload_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.NUDPassLeng);
            this.tabPage3.Controls.Add(this.TBPassword);
            this.tabPage3.Controls.Add(this.BCreatePassword);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.CLBPass);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 400);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Генератор паролей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CLBPass
            // 
            this.CLBPass.CheckOnClick = true;
            this.CLBPass.FormattingEnabled = true;
            this.CLBPass.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CLBPass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы:@,<,>,?,#,$,%,^,&,*,(,),_,+,~"});
            this.CLBPass.Location = new System.Drawing.Point(9, 16);
            this.CLBPass.Name = "CLBPass";
            this.CLBPass.Size = new System.Drawing.Size(304, 94);
            this.CLBPass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Длина пароля";
            // 
            // BCreatePassword
            // 
            this.BCreatePassword.Location = new System.Drawing.Point(238, 116);
            this.BCreatePassword.Name = "BCreatePassword";
            this.BCreatePassword.Size = new System.Drawing.Size(75, 23);
            this.BCreatePassword.TabIndex = 3;
            this.BCreatePassword.Text = "Создать пароль";
            this.BCreatePassword.UseVisualStyleBackColor = true;
            this.BCreatePassword.Click += new System.EventHandler(this.BCreatePassword_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(9, 158);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(302, 20);
            this.TBPassword.TabIndex = 4;
            // 
            // NUDPassLeng
            // 
            this.NUDPassLeng.Location = new System.Drawing.Point(112, 119);
            this.NUDPassLeng.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPassLeng.Name = "NUDPassLeng";
            this.NUDPassLeng.Size = new System.Drawing.Size(120, 20);
            this.NUDPassLeng.TabIndex = 5;
            this.NUDPassLeng.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDPassLeng.ValueChanged += new System.EventHandler(this.NUDPassLeng_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.CBMetric);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.TBTo);
            this.tabPage4.Controls.Add(this.TBFrom);
            this.tabPage4.Controls.Add(this.BConvert);
            this.tabPage4.Controls.Add(this.CBTo);
            this.tabPage4.Controls.Add(this.CBFrom);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 400);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Конвертор";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CBFrom
            // 
            this.CBFrom.FormattingEnabled = true;
            this.CBFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.CBFrom.Location = new System.Drawing.Point(52, 61);
            this.CBFrom.Name = "CBFrom";
            this.CBFrom.Size = new System.Drawing.Size(121, 21);
            this.CBFrom.TabIndex = 0;
            this.CBFrom.Text = "mm";
            // 
            // CBTo
            // 
            this.CBTo.FormattingEnabled = true;
            this.CBTo.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.CBTo.Location = new System.Drawing.Point(403, 60);
            this.CBTo.Name = "CBTo";
            this.CBTo.Size = new System.Drawing.Size(121, 21);
            this.CBTo.TabIndex = 1;
            this.CBTo.Text = "mm";
            // 
            // BConvert
            // 
            this.BConvert.Location = new System.Drawing.Point(253, 58);
            this.BConvert.Name = "BConvert";
            this.BConvert.Size = new System.Drawing.Size(75, 23);
            this.BConvert.TabIndex = 2;
            this.BConvert.Text = "Конвертер";
            this.BConvert.UseVisualStyleBackColor = true;
            this.BConvert.Click += new System.EventHandler(this.BConvert_Click);
            // 
            // TBFrom
            // 
            this.TBFrom.Location = new System.Drawing.Point(52, 217);
            this.TBFrom.Name = "TBFrom";
            this.TBFrom.Size = new System.Drawing.Size(121, 20);
            this.TBFrom.TabIndex = 3;
            this.TBFrom.Text = "1";
            // 
            // TBTo
            // 
            this.TBTo.Location = new System.Drawing.Point(403, 217);
            this.TBTo.Name = "TBTo";
            this.TBTo.ReadOnly = true;
            this.TBTo.Size = new System.Drawing.Size(121, 20);
            this.TBTo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<= =>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBMetric
            // 
            this.CBMetric.FormattingEnabled = true;
            this.CBMetric.Items.AddRange(new object[] {
            "Длина",
            "Вес"});
            this.CBMetric.Location = new System.Drawing.Point(253, 119);
            this.CBMetric.Name = "CBMetric";
            this.CBMetric.Size = new System.Drawing.Size(75, 21);
            this.CBMetric.TabIndex = 6;
            this.CBMetric.Text = "длина";
            this.CBMetric.SelectedIndexChanged += new System.EventHandler(this.CBMetric_SelectedIndexChanged);
            // 
            // Utilite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(Counter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Utilite";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            Counter.ResumeLayout(false);
            this.Счётчик1.ResumeLayout(false);
            this.Счётчик1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPassLeng)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIAbout;
        private System.Windows.Forms.TabPage Счётчик1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        public System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelRandom;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.TextBox TBRandom;
        private System.Windows.Forms.Button BRandomCler;
        private System.Windows.Forms.Button BRandomCopy;
        private System.Windows.Forms.CheckBox CBRandom;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox RTBNotepad;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIInserDate;
        private System.Windows.Forms.ToolStripMenuItem TSMIInserTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMISave;
        private System.Windows.Forms.ToolStripMenuItem TSMIDownload;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckedListBox CLBPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BCreatePassword;
        private System.Windows.Forms.NumericUpDown NUDPassLeng;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox TBTo;
        private System.Windows.Forms.TextBox TBFrom;
        private System.Windows.Forms.Button BConvert;
        private System.Windows.Forms.ComboBox CBTo;
        private System.Windows.Forms.ComboBox CBFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBMetric;
    }
}

