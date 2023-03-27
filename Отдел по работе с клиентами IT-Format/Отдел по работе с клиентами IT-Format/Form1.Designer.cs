
namespace Отдел_по_работе_с_клиентами_IT_Format
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпроектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.заказыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кожухар_ИТ2001_ITformatDataSet = new Отдел_по_работе_с_клиентами_IT_Format.Кожухар_ИТ2001_ITformatDataSet();
            this.кодуслугиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.услугиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.наименованиепроектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.техническоезаданиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.проектыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.проектыTableAdapter = new Отдел_по_работе_с_клиентами_IT_Format.Кожухар_ИТ2001_ITformatDataSetTableAdapters.ПроектыTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеОКлиентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыИПроектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.этапыПроектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыTableAdapter = new Отдел_по_работе_с_клиентами_IT_Format.Кожухар_ИТ2001_ITformatDataSetTableAdapters.ЗаказыTableAdapter();
            this.услугиTableAdapter = new Отдел_по_работе_с_клиентами_IT_Format.Кожухар_ИТ2001_ITformatDataSetTableAdapters.УслугиTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кожухар_ИТ2001_ITformatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектыBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпроектаDataGridViewTextBoxColumn,
            this.номерзаказаDataGridViewTextBoxColumn,
            this.кодуслугиDataGridViewTextBoxColumn,
            this.наименованиепроектаDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.датаокончанияDataGridViewTextBoxColumn,
            this.техническоезаданиеDataGridViewTextBoxColumn,
            this.датаоплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.проектыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1724, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодпроектаDataGridViewTextBoxColumn
            // 
            this.кодпроектаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.кодпроектаDataGridViewTextBoxColumn.DataPropertyName = "Код_проекта";
            this.кодпроектаDataGridViewTextBoxColumn.HeaderText = "Код_проекта";
            this.кодпроектаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпроектаDataGridViewTextBoxColumn.Name = "кодпроектаDataGridViewTextBoxColumn";
            this.кодпроектаDataGridViewTextBoxColumn.Width = 124;
            // 
            // номерзаказаDataGridViewTextBoxColumn
            // 
            this.номерзаказаDataGridViewTextBoxColumn.DataPropertyName = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.DataSource = this.заказыBindingSource;
            this.номерзаказаDataGridViewTextBoxColumn.DisplayMember = "Наименование_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.HeaderText = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерзаказаDataGridViewTextBoxColumn.Name = "номерзаказаDataGridViewTextBoxColumn";
            this.номерзаказаDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.номерзаказаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.номерзаказаDataGridViewTextBoxColumn.ValueMember = "Номер_заказа";
            this.номерзаказаDataGridViewTextBoxColumn.Width = 180;
            // 
            // заказыBindingSource
            // 
            this.заказыBindingSource.DataMember = "Заказы";
            this.заказыBindingSource.DataSource = this.кожухар_ИТ2001_ITformatDataSet;
            // 
            // кожухар_ИТ2001_ITformatDataSet
            // 
            this.кожухар_ИТ2001_ITformatDataSet.DataSetName = "Кожухар_ИТ2001_ITformatDataSet";
            this.кожухар_ИТ2001_ITformatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кодуслугиDataGridViewTextBoxColumn
            // 
            this.кодуслугиDataGridViewTextBoxColumn.DataPropertyName = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.DataSource = this.услугиBindingSource;
            this.кодуслугиDataGridViewTextBoxColumn.DisplayMember = "Наименование_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.HeaderText = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодуслугиDataGridViewTextBoxColumn.Name = "кодуслугиDataGridViewTextBoxColumn";
            this.кодуслугиDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.кодуслугиDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.кодуслугиDataGridViewTextBoxColumn.ValueMember = "Код_услуги";
            this.кодуслугиDataGridViewTextBoxColumn.Width = 180;
            // 
            // услугиBindingSource
            // 
            this.услугиBindingSource.DataMember = "Услуги";
            this.услугиBindingSource.DataSource = this.кожухар_ИТ2001_ITformatDataSet;
            // 
            // наименованиепроектаDataGridViewTextBoxColumn
            // 
            this.наименованиепроектаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_проекта";
            this.наименованиепроектаDataGridViewTextBoxColumn.HeaderText = "Наименование_проекта";
            this.наименованиепроектаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиепроектаDataGridViewTextBoxColumn.Name = "наименованиепроектаDataGridViewTextBoxColumn";
            this.наименованиепроектаDataGridViewTextBoxColumn.Width = 250;
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            this.датаначалаDataGridViewTextBoxColumn.Width = 127;
            // 
            // датаокончанияDataGridViewTextBoxColumn
            // 
            this.датаокончанияDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.датаокончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.HeaderText = "Дата_окончания";
            this.датаокончанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаокончанияDataGridViewTextBoxColumn.Name = "датаокончанияDataGridViewTextBoxColumn";
            this.датаокончанияDataGridViewTextBoxColumn.Width = 150;
            // 
            // техническоезаданиеDataGridViewTextBoxColumn
            // 
            this.техническоезаданиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.техническоезаданиеDataGridViewTextBoxColumn.DataPropertyName = "Техническое_задание";
            this.техническоезаданиеDataGridViewTextBoxColumn.HeaderText = "Техническое_задание";
            this.техническоезаданиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.техническоезаданиеDataGridViewTextBoxColumn.Name = "техническоезаданиеDataGridViewTextBoxColumn";
            this.техническоезаданиеDataGridViewTextBoxColumn.Width = 185;
            // 
            // датаоплатыDataGridViewTextBoxColumn
            // 
            this.датаоплатыDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаоплатыDataGridViewTextBoxColumn.DataPropertyName = "Дата_оплаты";
            this.датаоплатыDataGridViewTextBoxColumn.HeaderText = "Дата_оплаты";
            this.датаоплатыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаоплатыDataGridViewTextBoxColumn.Name = "датаоплатыDataGridViewTextBoxColumn";
            // 
            // проектыBindingSource
            // 
            this.проектыBindingSource.DataMember = "Проекты";
            this.проектыBindingSource.DataSource = this.кожухар_ИТ2001_ITformatDataSet;
            // 
            // проектыTableAdapter
            // 
            this.проектыTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеОКлиентахToolStripMenuItem,
            this.заказыИПроектыToolStripMenuItem,
            this.оКомпанииToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1840, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеОКлиентахToolStripMenuItem
            // 
            this.данныеОКлиентахToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.договорToolStripMenuItem});
            this.данныеОКлиентахToolStripMenuItem.Name = "данныеОКлиентахToolStripMenuItem";
            this.данныеОКлиентахToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.данныеОКлиентахToolStripMenuItem.Text = "Данные о клиентах";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // договорToolStripMenuItem
            // 
            this.договорToolStripMenuItem.Name = "договорToolStripMenuItem";
            this.договорToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.договорToolStripMenuItem.Text = "Договор";
            this.договорToolStripMenuItem.Click += new System.EventHandler(this.договорToolStripMenuItem_Click);
            // 
            // заказыИПроектыToolStripMenuItem
            // 
            this.заказыИПроектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem,
            this.проектыToolStripMenuItem});
            this.заказыИПроектыToolStripMenuItem.Name = "заказыИПроектыToolStripMenuItem";
            this.заказыИПроектыToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.заказыИПроектыToolStripMenuItem.Text = "Заказы и проекты";
            // 
            // заказыToolStripMenuItem
            // 
            this.заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            this.заказыToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.заказыToolStripMenuItem.Text = "Заказы";
            this.заказыToolStripMenuItem.Click += new System.EventHandler(this.заказыToolStripMenuItem_Click);
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.этапыПроектовToolStripMenuItem});
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.проектыToolStripMenuItem.Text = "Проекты";
            // 
            // этапыПроектовToolStripMenuItem
            // 
            this.этапыПроектовToolStripMenuItem.Name = "этапыПроектовToolStripMenuItem";
            this.этапыПроектовToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.этапыПроектовToolStripMenuItem.Text = "Этапы проектов";
            this.этапыПроектовToolStripMenuItem.Click += new System.EventHandler(this.этапыПроектовToolStripMenuItem_Click);
            // 
            // оКомпанииToolStripMenuItem
            // 
            this.оКомпанииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.услугиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.оКомпанииToolStripMenuItem.Name = "оКомпанииToolStripMenuItem";
            this.оКомпанииToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.оКомпанииToolStripMenuItem.Text = "О компании";
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            this.услугиToolStripMenuItem.Click += new System.EventHandler(this.услугиToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // заказыTableAdapter
            // 
            this.заказыTableAdapter.ClearBeforeFill = true;
            // 
            // услугиTableAdapter
            // 
            this.услугиTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip7.Name = "contextMenuStrip7";
            this.contextMenuStrip7.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(382, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(658, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(944, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1040, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Заказ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Услуга:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Проект:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 640);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Отдел по работе с клиентами";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кожухар_ИТ2001_ITformatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.услугиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.проектыBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Кожухар_ИТ2001_ITformatDataSet кожухар_ИТ2001_ITformatDataSet;
        private System.Windows.Forms.BindingSource проектыBindingSource;
        private Кожухар_ИТ2001_ITformatDataSetTableAdapters.ПроектыTableAdapter проектыTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеОКлиентахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыИПроектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem этапыПроектовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оКомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.BindingSource заказыBindingSource;
        private Кожухар_ИТ2001_ITformatDataSetTableAdapters.ЗаказыTableAdapter заказыTableAdapter;
        private System.Windows.Forms.BindingSource услугиBindingSource;
        private Кожухар_ИТ2001_ITformatDataSetTableAdapters.УслугиTableAdapter услугиTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпроектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn номерзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn кодуслугиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиепроектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn техническоезаданиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip7;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

