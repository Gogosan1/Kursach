namespace ModelMainForm
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServicesPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearServicesButton = new System.Windows.Forms.Button();
            this.FirstSaveButton = new System.Windows.Forms.Button();
            this.ServicePirce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteService = new System.Windows.Forms.Button();
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.AddSerivce = new System.Windows.Forms.Button();
            this.WorkersPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SecondSaveButton = new System.Windows.Forms.Button();
            this.SecondServicesDataGridView = new System.Windows.Forms.DataGridView();
            this.NameOfWorkerTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.deleteWorkerButton = new System.Windows.Forms.Button();
            this.MasterRadioButton = new System.Windows.Forms.RadioButton();
            this.ManagerRadioButton = new System.Windows.Forms.RadioButton();
            this.workersListDataGridView = new System.Windows.Forms.DataGridView();
            this.ModelPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApplicationIntensityTextBox = new System.Windows.Forms.TextBox();
            this.StartModelButton = new System.Windows.Forms.Button();
            this.ModelTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StatisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claimWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfServiceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ServicesPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstServicesDataGridView)).BeginInit();
            this.WorkersPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondServicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersListDataGridView)).BeginInit();
            this.ModelPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimWorkerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(1425, 584);
            this.splitContainer1.SplitterDistance = 696;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServicesPage);
            this.tabControl1.Controls.Add(this.WorkersPage);
            this.tabControl1.Controls.Add(this.ModelPage);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 584);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ServicesPage
            // 
            this.ServicesPage.Controls.Add(this.groupBox2);
            this.ServicesPage.Location = new System.Drawing.Point(4, 25);
            this.ServicesPage.Name = "ServicesPage";
            this.ServicesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ServicesPage.Size = new System.Drawing.Size(688, 555);
            this.ServicesPage.TabIndex = 1;
            this.ServicesPage.Text = "Список услуг парикмахерской";
            this.ServicesPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearServicesButton);
            this.groupBox2.Controls.Add(this.FirstSaveButton);
            this.groupBox2.Controls.Add(this.ServicePirce);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DeleteService);
            this.groupBox2.Controls.Add(this.ServiceName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FirstServicesDataGridView);
            this.groupBox2.Controls.Add(this.AddSerivce);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 549);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список услуг салона";
            // 
            // ClearServicesButton
            // 
            this.ClearServicesButton.Location = new System.Drawing.Point(457, 283);
            this.ClearServicesButton.Name = "ClearServicesButton";
            this.ClearServicesButton.Size = new System.Drawing.Size(115, 23);
            this.ClearServicesButton.TabIndex = 10;
            this.ClearServicesButton.Text = "Сброс";
            this.ClearServicesButton.UseVisualStyleBackColor = true;
            this.ClearServicesButton.Click += new System.EventHandler(this.ClearServicesButton_Click);
            // 
            // FirstSaveButton
            // 
            this.FirstSaveButton.Location = new System.Drawing.Point(457, 323);
            this.FirstSaveButton.Name = "FirstSaveButton";
            this.FirstSaveButton.Size = new System.Drawing.Size(115, 23);
            this.FirstSaveButton.TabIndex = 9;
            this.FirstSaveButton.Text = "Сохранить";
            this.FirstSaveButton.UseVisualStyleBackColor = true;
            this.FirstSaveButton.Click += new System.EventHandler(this.FirstSaveButton_Click);
            // 
            // ServicePirce
            // 
            this.ServicePirce.Location = new System.Drawing.Point(208, 234);
            this.ServicePirce.Name = "ServicePirce";
            this.ServicePirce.Size = new System.Drawing.Size(100, 22);
            this.ServicePirce.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Стоимость услуги";
            // 
            // DeleteService
            // 
            this.DeleteService.Location = new System.Drawing.Point(6, 150);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(603, 23);
            this.DeleteService.TabIndex = 3;
            this.DeleteService.Text = "удалить услугу";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // ServiceName
            // 
            this.ServiceName.Location = new System.Drawing.Point(208, 192);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(100, 22);
            this.ServiceName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вид услуги";
            // 
            // FirstServicesDataGridView
            // 
            this.FirstServicesDataGridView.AutoGenerateColumns = false;
            this.FirstServicesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.FirstServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirstServicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn});
            this.FirstServicesDataGridView.DataSource = this.serviceBindingSource;
            this.FirstServicesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstServicesDataGridView.Location = new System.Drawing.Point(3, 18);
            this.FirstServicesDataGridView.Name = "FirstServicesDataGridView";
            this.FirstServicesDataGridView.RowHeadersWidth = 51;
            this.FirstServicesDataGridView.RowTemplate.Height = 24;
            this.FirstServicesDataGridView.Size = new System.Drawing.Size(676, 126);
            this.FirstServicesDataGridView.TabIndex = 4;
            // 
            // AddSerivce
            // 
            this.AddSerivce.Location = new System.Drawing.Point(356, 218);
            this.AddSerivce.Name = "AddSerivce";
            this.AddSerivce.Size = new System.Drawing.Size(192, 23);
            this.AddSerivce.TabIndex = 2;
            this.AddSerivce.Text = "добавить услугу";
            this.AddSerivce.UseVisualStyleBackColor = true;
            this.AddSerivce.Click += new System.EventHandler(this.AddSerivce_Click);
            // 
            // WorkersPage
            // 
            this.WorkersPage.Controls.Add(this.groupBox4);
            this.WorkersPage.Controls.Add(this.workersListDataGridView);
            this.WorkersPage.Location = new System.Drawing.Point(4, 25);
            this.WorkersPage.Name = "WorkersPage";
            this.WorkersPage.Padding = new System.Windows.Forms.Padding(3);
            this.WorkersPage.Size = new System.Drawing.Size(688, 555);
            this.WorkersPage.TabIndex = 2;
            this.WorkersPage.Text = "Список работников";
            this.WorkersPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SecondSaveButton);
            this.groupBox4.Controls.Add(this.SecondServicesDataGridView);
            this.groupBox4.Controls.Add(this.NameOfWorkerTextBox);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.AddWorkerButton);
            this.groupBox4.Controls.Add(this.deleteWorkerButton);
            this.groupBox4.Controls.Add(this.MasterRadioButton);
            this.groupBox4.Controls.Add(this.ManagerRadioButton);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 370);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // SecondSaveButton
            // 
            this.SecondSaveButton.Enabled = false;
            this.SecondSaveButton.Location = new System.Drawing.Point(460, 320);
            this.SecondSaveButton.Name = "SecondSaveButton";
            this.SecondSaveButton.Size = new System.Drawing.Size(115, 23);
            this.SecondSaveButton.TabIndex = 10;
            this.SecondSaveButton.Text = "Сохранить";
            this.SecondSaveButton.UseVisualStyleBackColor = true;
            this.SecondSaveButton.Click += new System.EventHandler(this.SecondSaveButton_Click);
            // 
            // SecondServicesDataGridView
            // 
            this.SecondServicesDataGridView.AutoGenerateColumns = false;
            this.SecondServicesDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SecondServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecondServicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfServiceColumn,
            this.PriceColumn,
            this.CheckBoxColumn});
            this.SecondServicesDataGridView.DataSource = this.serviceBindingSource;
            this.SecondServicesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondServicesDataGridView.Enabled = false;
            this.SecondServicesDataGridView.Location = new System.Drawing.Point(3, 18);
            this.SecondServicesDataGridView.Name = "SecondServicesDataGridView";
            this.SecondServicesDataGridView.RowHeadersWidth = 51;
            this.SecondServicesDataGridView.RowTemplate.Height = 24;
            this.SecondServicesDataGridView.Size = new System.Drawing.Size(676, 184);
            this.SecondServicesDataGridView.TabIndex = 8;
            this.SecondServicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SecondServicesDataGridView_CellContentClick);
            // 
            // NameOfWorkerTextBox
            // 
            this.NameOfWorkerTextBox.Location = new System.Drawing.Point(383, 222);
            this.NameOfWorkerTextBox.Name = "NameOfWorkerTextBox";
            this.NameOfWorkerTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameOfWorkerTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введите имя сотрудника";
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Enabled = false;
            this.AddWorkerButton.Location = new System.Drawing.Point(185, 269);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(192, 23);
            this.AddWorkerButton.TabIndex = 4;
            this.AddWorkerButton.Text = "добавить сотрудника";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // deleteWorkerButton
            // 
            this.deleteWorkerButton.Enabled = false;
            this.deleteWorkerButton.Location = new System.Drawing.Point(383, 269);
            this.deleteWorkerButton.Name = "deleteWorkerButton";
            this.deleteWorkerButton.Size = new System.Drawing.Size(192, 23);
            this.deleteWorkerButton.TabIndex = 5;
            this.deleteWorkerButton.Text = "удалить сотрудника";
            this.deleteWorkerButton.UseVisualStyleBackColor = true;
            this.deleteWorkerButton.Click += new System.EventHandler(this.DeleteWorkerButton_Click);
            // 
            // MasterRadioButton
            // 
            this.MasterRadioButton.AutoSize = true;
            this.MasterRadioButton.Checked = true;
            this.MasterRadioButton.Location = new System.Drawing.Point(33, 219);
            this.MasterRadioButton.Name = "MasterRadioButton";
            this.MasterRadioButton.Size = new System.Drawing.Size(77, 20);
            this.MasterRadioButton.TabIndex = 1;
            this.MasterRadioButton.TabStop = true;
            this.MasterRadioButton.Text = "Мастер";
            this.MasterRadioButton.UseVisualStyleBackColor = true;
            this.MasterRadioButton.CheckedChanged += new System.EventHandler(this.MasterRadioButton_CheckedChanged);
            // 
            // ManagerRadioButton
            // 
            this.ManagerRadioButton.AutoSize = true;
            this.ManagerRadioButton.Location = new System.Drawing.Point(33, 245);
            this.ManagerRadioButton.Name = "ManagerRadioButton";
            this.ManagerRadioButton.Size = new System.Drawing.Size(131, 20);
            this.ManagerRadioButton.TabIndex = 2;
            this.ManagerRadioButton.Text = "Администратор";
            this.ManagerRadioButton.UseVisualStyleBackColor = true;
            this.ManagerRadioButton.CheckedChanged += new System.EventHandler(this.ManagerRadioButton_CheckedChanged);
            // 
            // workersListDataGridView
            // 
            this.workersListDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.workersListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ProfessionColumn});
            this.workersListDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.workersListDataGridView.Location = new System.Drawing.Point(3, 3);
            this.workersListDataGridView.Name = "workersListDataGridView";
            this.workersListDataGridView.RowHeadersWidth = 51;
            this.workersListDataGridView.RowTemplate.Height = 24;
            this.workersListDataGridView.Size = new System.Drawing.Size(682, 179);
            this.workersListDataGridView.TabIndex = 2;
            // 
            // ModelPage
            // 
            this.ModelPage.Controls.Add(this.groupBox1);
            this.ModelPage.Location = new System.Drawing.Point(4, 25);
            this.ModelPage.Name = "ModelPage";
            this.ModelPage.Padding = new System.Windows.Forms.Padding(3);
            this.ModelPage.Size = new System.Drawing.Size(688, 555);
            this.ModelPage.TabIndex = 0;
            this.ModelPage.Text = "Запуск модели";
            this.ModelPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ApplicationIntensityTextBox);
            this.groupBox1.Controls.Add(this.StartModelButton);
            this.groupBox1.Controls.Add(this.ModelTimeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 191);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество заявок в час";
            // 
            // ApplicationIntensityTextBox
            // 
            this.ApplicationIntensityTextBox.Location = new System.Drawing.Point(354, 73);
            this.ApplicationIntensityTextBox.Name = "ApplicationIntensityTextBox";
            this.ApplicationIntensityTextBox.Size = new System.Drawing.Size(100, 22);
            this.ApplicationIntensityTextBox.TabIndex = 5;
            // 
            // StartModelButton
            // 
            this.StartModelButton.Enabled = false;
            this.StartModelButton.Location = new System.Drawing.Point(179, 127);
            this.StartModelButton.Name = "StartModelButton";
            this.StartModelButton.Size = new System.Drawing.Size(192, 23);
            this.StartModelButton.TabIndex = 0;
            this.StartModelButton.Text = "Запуск моделирования";
            this.StartModelButton.UseVisualStyleBackColor = true;
            this.StartModelButton.Click += new System.EventHandler(this.StartModelButton_Click);
            // 
            // ModelTimeTextBox
            // 
            this.ModelTimeTextBox.Location = new System.Drawing.Point(354, 29);
            this.ModelTimeTextBox.Name = "ModelTimeTextBox";
            this.ModelTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.ModelTimeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время моделирования в часах";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StatisticsDataGridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 584);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Статистика по итогам моделирования";
            // 
            // StatisticsDataGridView
            // 
            this.StatisticsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.StatisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.StatisticsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatisticsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.StatisticsDataGridView.Name = "StatisticsDataGridView";
            this.StatisticsDataGridView.RowHeadersWidth = 51;
            this.StatisticsDataGridView.RowTemplate.Height = 24;
            this.StatisticsDataGridView.Size = new System.Drawing.Size(719, 563);
            this.StatisticsDataGridView.TabIndex = 1;
            this.StatisticsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StatisticsDataGridView_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя работника";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Выручка от работника (руб.)";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество обслуженных клиентов (человек)";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Время простоя (минут)";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(ModelMainForm.Service);
            // 
            // claimWorkerBindingSource
            // 
            this.claimWorkerBindingSource.DataSource = typeof(ModelMainForm.MVP.Model.ClaimWorker);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Имя";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 62;
            // 
            // ProfessionColumn
            // 
            this.ProfessionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProfessionColumn.HeaderText = "Профессия";
            this.ProfessionColumn.MinimumWidth = 6;
            this.ProfessionColumn.Name = "ProfessionColumn";
            this.ProfessionColumn.Width = 110;
            // 
            // NameOfServiceColumn
            // 
            this.NameOfServiceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameOfServiceColumn.DataPropertyName = "Name";
            this.NameOfServiceColumn.HeaderText = "Имя";
            this.NameOfServiceColumn.MinimumWidth = 6;
            this.NameOfServiceColumn.Name = "NameOfServiceColumn";
            this.NameOfServiceColumn.ReadOnly = true;
            this.NameOfServiceColumn.Width = 62;
            // 
            // PriceColumn
            // 
            this.PriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PriceColumn.DataPropertyName = "Price";
            this.PriceColumn.HeaderText = "Цена услуги";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 117;
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.FalseValue = "false";
            this.CheckBoxColumn.HeaderText = "выбор услуг работника";
            this.CheckBoxColumn.IndeterminateValue = "";
            this.CheckBoxColumn.MinimumWidth = 6;
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.TrueValue = "true";
            this.CheckBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nameDataGridViewTextBoxColumn1.Width = 62;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена услуги";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.priceDataGridViewTextBoxColumn.Width = 117;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 584);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Программа моделирования работы парикмахерской";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ServicesPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstServicesDataGridView)).EndInit();
            this.WorkersPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondServicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersListDataGridView)).EndInit();
            this.ModelPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claimWorkerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddSerivce;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.DataGridView FirstServicesDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ModelPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ApplicationIntensityTextBox;
        private System.Windows.Forms.Button StartModelButton;
        private System.Windows.Forms.TextBox ModelTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ServicesPage;
        private System.Windows.Forms.TextBox ServicePirce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServiceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView StatisticsDataGridView;
        private System.Windows.Forms.BindingSource claimWorkerBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button FirstSaveButton;
        private System.Windows.Forms.TabPage WorkersPage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SecondSaveButton;
        private System.Windows.Forms.DataGridView SecondServicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox NameOfWorkerTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddWorkerButton;
        private System.Windows.Forms.Button deleteWorkerButton;
        private System.Windows.Forms.RadioButton MasterRadioButton;
        private System.Windows.Forms.RadioButton ManagerRadioButton;
        private System.Windows.Forms.DataGridView workersListDataGridView;
        private System.Windows.Forms.Button ClearServicesButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfServiceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfessionColumn;
    }
}

