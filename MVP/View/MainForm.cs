using ModelMainForm.MVP.Controller;
using ModelMainForm.MVP.Model;
using System;
using System.Windows.Forms;

namespace ModelMainForm
{
    public partial class MainForm : Form
    {

        public MainForm(MainFormController controller)
        {
            this.controller = controller;
            InitializeComponent();

            UpdateDataOfWorkersInDataGrid();
            UpdateDataServicesInDataGrid();
        }

        // First Tab

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateDataOfWorkersInDataGrid();
            UpdateDataServicesInDataGrid();
        }

        private void AddSerivce_Click(object sender, EventArgs e)
        {
   
            try
            {
                controller.AddService(ServiceName.Text, ServicePirce.Text);
                UpdateDataServicesInDataGrid();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка. Цена должна быть числом.");
            }
            catch (ArgumentException uncorrectValue)
            {
                MessageBox.Show(uncorrectValue.Message);
            }
            catch (Exception serviceExisting)
            {
                MessageBox.Show(serviceExisting.Message);
            }
            ServiceName.Text = "";
            ServicePirce.Text = "";
        }

        private void UpdateDataServicesInDataGrid()
        {
            var source1 = new BindingSource(controller.ReturnListOfServices(), null);
            FirstServicesDataGridView.DataSource = source1;
            FirstServicesDataGridView.Update();
        }
        private void UpdateDataOfWorkersInDataGrid()
        {
            workersListDataGridView.Rows.Clear();

            foreach(var worker in controller.ReturnListOfWorkers())
            {
                //TODO: переделать, заменить на динамический полиморфизм
                if (worker.GetType() == typeof(Manager))
                    workersListDataGridView.Rows.Add(worker.Name.ToString(), "Администратор".ToString());
                if (worker.GetType() == typeof(Master))
                    workersListDataGridView.Rows.Add(worker.Name.ToString(), "Мастер".ToString());
            }

            FirstServicesDataGridView.Update();
        }

        private void DeleteService_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in FirstServicesDataGridView.SelectedRows)
            {
                // TODO: row.Tag
                if (row.Cells[0].Value.ToString() == Constants.START_SERVICE)
                    MessageBox.Show("Вы не можете удалить данный тип услуги");
                else
                    FirstServicesDataGridView.Rows.Remove(row);
            }
        }

        private void FirstSaveButton_Click(object sender, EventArgs e)
        {
            if (FirstServicesDataGridView.RowCount < 2)
            {
                MessageBox.Show("Вы не добавили ни одного сервиса");
                return;
            }
            // Enable Second Page on TabControl
            AddWorkerButton.Enabled = true;
            deleteWorkerButton.Enabled = true;
            SecondSaveButton.Enabled = true;
            SecondServicesDataGridView.Enabled = true;

            // Disable First Page on TabControl
            AddSerivce.Enabled = false;
            DeleteService.Enabled = false;
            ServiceName.Enabled = false;
            ServicePirce.Enabled = false;
            FirstSaveButton.Enabled = false;
            ClearServicesButton.Enabled = false;


            var source1 = new BindingSource(controller.DynamicRenderingOfDataGrid(Constants.MASTER_TYPE), null);
            SecondServicesDataGridView.DataSource = source1;
            SecondServicesDataGridView.Update();

            CounterOfServicesOfWorker = 0;
            //serialization
            controller.Serialization();
        }

        // Second Tab

        private void SecondServicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = SecondServicesDataGridView.Rows[e.RowIndex];
            string name = Convert.ToString(row.Cells[0].Value.ToString());
            int price = Convert.ToInt32(row.Cells[1].Value);

            if ((bool)SecondServicesDataGridView[2, e.RowIndex].EditedFormattedValue == true)
            {
                MasterRadioButton.Enabled = false;
                ManagerRadioButton.Enabled = false;
                
                
                var form = new AddMasterForm();
                form.ShowDialog();
                int time = form.GetTime();
                
                CounterOfServicesOfWorker++;

                controller.AddServiceToWorker(name, price, time);
            }
            else
            {
                CounterOfServicesOfWorker--;
                controller.RemoveServiceOfWorker(name);
            }
    }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
           
            MasterRadioButton.Enabled = true;
            ManagerRadioButton.Enabled = true;
      
            if (CounterOfServicesOfWorker == 0)
                MessageBox.Show("Добавьте хотябы один сервис работнику");
            else
            {
                try
                {
                    if (MasterRadioButton.Checked)
                        controller.AddWorker(NameOfWorkerTextBox.Text, Constants.MASTER_TYPE);
                    
                    if (ManagerRadioButton.Checked)
                        controller.AddWorker(NameOfWorkerTextBox.Text, Constants.MANAGER_TYPE);
                    
                    UpdateDataOfWorkersInDataGrid();
                }
                catch (Exception workerExisting)
                {
                    MessageBox.Show(workerExisting.Message);
                }

            }
            NameOfWorkerTextBox.Text = "";
        }

        private void DeleteWorkerButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in workersListDataGridView.SelectedRows)
            {
                workersListDataGridView.Rows.Remove(row);
                controller.DeleteWorker(row.Cells[0].Value.ToString());
            }
        }

        private void ManagerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var source1 = new BindingSource(controller.DynamicRenderingOfDataGrid(Constants.MANAGER_TYPE), null);
            SecondServicesDataGridView.DataSource = source1;
            SecondServicesDataGridView.Update();
        }

        private void MasterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var source1 = new BindingSource(controller.DynamicRenderingOfDataGrid(Constants.MASTER_TYPE), null);
            SecondServicesDataGridView.DataSource = source1;
            SecondServicesDataGridView.Update();
        }

        private void SecondSaveButton_Click(object sender, EventArgs e)
        {
            int counterOfManager = 0;
            int countnerOfMaster = 0;
            for (int rowCount = 0; rowCount < workersListDataGridView.Rows.Count - 1; rowCount++)
            {
                if (workersListDataGridView[1, rowCount].Value.ToString() == Constants.MASTER_TYPE)
                    countnerOfMaster++;
                if (workersListDataGridView[1, rowCount].Value.ToString() == Constants.MANAGER_TYPE)
                    counterOfManager++;

            }
            if (counterOfManager == 0 || countnerOfMaster == 0)
                MessageBox.Show("Чтобы запустить модель, вам нужно добавить работников обоих типов");
            else
            {
                // Disable second Page on TabControl
                AddWorkerButton.Enabled = false;
                deleteWorkerButton.Enabled = false;
                SecondSaveButton.Enabled = false;
                SecondServicesDataGridView.Enabled = false;

                // Enable third Page on TabControl
                StartModelButton.Enabled = true;
            }
        }

        // Thrid Tab

        private void StartModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                // статистику, заявки
                controller.ClearSatistics();
                controller.StartModel(Convert.ToInt32(ModelTimeTextBox.Text), Convert.ToInt32(ApplicationIntensityTextBox.Text));
                UpdateStaitisticOfWorkers();
                MessageBox.Show("Моделирование завершено");
            }
            catch(FormatException)
            {
                MessageBox.Show("Вы ввели не число");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStaitisticOfWorkers()
        {
            StatisticsDataGridView.Rows.Clear();

            foreach (var worker in controller.ReturnListOfWorkers())
            {
                StatisticsOfWorkers stat = worker.ReturnStatistics();
                StatisticsDataGridView.Rows.Add(worker.Name.ToString(), 
                    stat.GetAmountOfMoneyEarned().ToString(),
                    stat.GetNumberOfClientsServed().ToString(),
                    stat.GetDownTime().ToString());
               
            }


            StatisticsDataGridView.Update();
        }

        private void ClearServicesButton_Click(object sender, EventArgs e)
        {
            controller.ClearServices();
            UpdateDataServicesInDataGrid();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 0 && FirstSaveButton.Enabled == true)
                MessageBox.Show("Чтобы продолжить, сохраните изменения во вкладке списка услуг");
            if (tabControl1.SelectedIndex != 1 && SecondSaveButton.Enabled == true)
                MessageBox.Show("Чтобы продолжить, сохраните изменения во вкладке списка работников");
        }
        
        private MainFormController controller;
        private int CounterOfServicesOfWorker;

        private void StatisticsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
