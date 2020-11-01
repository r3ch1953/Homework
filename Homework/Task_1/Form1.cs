using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private Config config = new Config();

        public Form1()
        {
            InitializeComponent();
        }

        private void clbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            lEmployeeInfo.Text = (clbEmployees.SelectedItem as Employee).GetFullInfo();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            if (!CheckError())
                return;

            btnAdd.Enabled = true;
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbCity.Text))
            {
                if (config.Address.ContainsKey(cbCity.Text))
                {
                    cbStreet.Items.Clear();
                    cbStreet.Items.AddRange(config.Address[cbCity.Text].ToArray());
                }
            }
        }

        private bool CheckError()
        {
            bool res = true;

            lErrors.Text = "";

            if (string.IsNullOrEmpty(tbName.Text))
            {
                lErrors.Text += $"Input Error: Name is incorect\n";
                res = false;
            }

            if (string.IsNullOrEmpty(tbSalary.Text))
            {
                lErrors.Text += $"Input Error: Salary is incorrct\n";
                res = false;
            }
            else
            {
                int temp = 0;
                if (!int.TryParse(tbSalary.Text, out temp))
                {
                    lErrors.Text += $"Input Error: Salary is incorrct\n";
                    res = false;
                }
            }

            if (string.IsNullOrEmpty(cbPosition.Text))
            {
                lErrors.Text += $"Input Error: Position is incorrct\n";
                res = false;
            }

            if (string.IsNullOrEmpty(cbCity.Text))
            {
                lErrors.Text += $"Input Error: City is incorrct\n";
                res = false;
            }

            if (string.IsNullOrEmpty(cbStreet.Text))
            {
                lErrors.Text += $"Input Error: Street is incorrct\n";
                res = false;
            }

            return res;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Save")
            {
                if(CheckError())
                {
                    (clbEmployees.CheckedItems[0] as Employee).Name = tbName.Text;
                    (clbEmployees.CheckedItems[0] as Employee).Salary = int.Parse(tbSalary.Text);
                    (clbEmployees.CheckedItems[0] as Employee).Position = cbPosition.Text;
                    (clbEmployees.CheckedItems[0] as Employee).City = cbCity.Text;
                    (clbEmployees.CheckedItems[0] as Employee).Street = cbStreet.Text;

                    UpdateData();
                    SaveConfig(config);

                    btnAdd.Text = "Add";
                }
            }
            else
            {
                btnAdd.Enabled = false;

                config.AddStreet(cbCity.Text, cbStreet.Text);
                if (!config.Positions.Contains(cbPosition.Text))
                {
                    config.AddPosition(cbPosition.Text);
                }

                config.AddEmployee(new Employee(tbName.Text, cbPosition.Text, int.Parse(tbSalary.Text), cbCity.Text, cbStreet.Text));
            }
            ClearInput();
        }

        public void ClearInput()
        {
            tbName.Text = "";
            tbSalary.Text = "";
            cbPosition.Text = "";
            cbCity.Text = "";
            cbStreet.Text = "";
        }

        public void SaveConfig(Config sender)
        {
            sender.Save();
        }

        public void EmployeesChanged(Config sender)
        {
            clbEmployees.Items.Clear();
            clbEmployees.Items.AddRange(config.Employees.ToArray());
        }

        public void UpdateData()
        {
            EmployeesChanged(config);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = false;

            List<Employee> checkedItems = new List<Employee>();
            foreach (var item in clbEmployees.CheckedItems)
            {
                checkedItems.Add((Employee)item);
            }

            foreach (var item in checkedItems)
            {
                config.DelEmployee(item);
            }

        }

        private void tLoading_Tick(object sender, EventArgs e)
        {
            pgLoadingEmployees.Maximum = 100;
            pgLoadingEmployees.Minimum = 0;
            pgLoadingEmployees.Step = 1;
            foreach (var item in config.Employees)
            {
                lLoadingEmployees.Text = $"Loading: {item}";
                Update();
                for (int i = 0; i < 100; i++)
                {
                    pgLoadingEmployees.PerformStep();
                    Thread.Sleep(20);
                }
                pgLoadingEmployees.Value = 0;
            }
            tLoading.Stop();
            pgLoadingEmployees.Visible = false;
            lLoadingEmployees.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config.Path = "config.json";

            try
            {
                config = Config.Load(config.Path);
                tLoading.Start();
                UpdateData();
            }
            catch { }

            config.AddressAdded += SaveConfig;
            config.AddressAdded += UpdateComboBoxes;
            config.PositionAdded += SaveConfig;
            config.PositionAdded += UpdateComboBoxes;

            config.EmployeeAdded += SaveConfig;
            config.EmployeeAdded += EmployeesChanged;

            config.EmployeeDeleted += SaveConfig;
            config.EmployeeDeleted += EmployeesChanged;

            UpdateComboBoxes(config);
            this.cbCity.TextChanged += new System.EventHandler(this.city_TextChanged);
        }

        private void UpdateComboBoxes(Config sender)
        {
            cbCity.Items.Clear();
            cbCity.Items.AddRange(sender.Address.Keys.ToArray());

            cbPosition.Items.Clear();
            cbPosition.Items.AddRange(sender.Positions.ToArray());
        }

        private void clbEmployees_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            btnDel.Enabled = true;

            if (clbEmployees.CheckedItems.Count + 1 == 1)
            {
                btnEdit.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Save";
            tbName.Text = clbEmployees.CheckedItems[0].ToString();
            tbSalary.Text = (clbEmployees.CheckedItems[0] as Employee).Salary.ToString();
            cbPosition.Text = (clbEmployees.CheckedItems[0] as Employee).Position;
            cbCity.Text = (clbEmployees.CheckedItems[0] as Employee).City;
            cbStreet.Text = (clbEmployees.CheckedItems[0] as Employee).Street;
            btnEdit.Enabled = false;
        }
    }
}
