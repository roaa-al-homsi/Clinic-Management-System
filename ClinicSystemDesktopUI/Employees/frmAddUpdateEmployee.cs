using ClinicSystem.Persons;
using ClinicSystemBusiness;
using System;
using System.Data;
using System.Windows.Forms;


namespace ClinicSystem.Employees
{
    public partial class frmAddUpdateEmployee : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private int _employeeId;
        private Employee _employee;
        public frmAddUpdateEmployee(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _mode = employeeId == -1 ? Mode.Add : Mode.Update;
        }
        private void _FillComboCareer()
        {
            DataTable dataTable = Career.All();
            foreach (DataRow row in dataTable.Rows)
            {
                cbCareer.Items.Add(row["Name"]);
            }
        }
        private void _LoadEmployeeData()
        {
            if (_mode == Mode.Add)
            {
                _employee = new Employee();
                this.Tag = "Add Employee";
                return;
            }
            _employee = Employee.Find(_employeeId);
            this.Tag = "Update Employee";
            picPerson.ImageLocation = _employee.Person.ImagePath;
            labEmployeeId.Text = _employeeId.ToString();
            txtSalary.Text = _employee.Salary.ToString();
            cbCareer.SelectedIndex = cbCareer.FindString(Career.GetNameById(_employee.CareerId));
            labPersonId.Text = _employee.PersonId.ToString();
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePersons addUpdatePersons = new frmAddUpdatePersons(_employee.PersonId);
            addUpdatePersons.DataBack += DataBackPerson;
            addUpdatePersons.ShowDialog();
        }
        private void DataBackPerson(object sender, int personId)
        {
            Person person = Person.Find(personId);
            if (person != null)
            {
                uc_personInfo1.ViewDataPerson(person);
                labPersonId.Text = personId.ToString();
            }
        }
        private void frmAddUpdateEmployee_Load(object sender, EventArgs e)
        {
            _FillComboCareer();
            _LoadEmployeeData();
            cbCareer.SelectedIndex = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _employee.Salary = int.Parse(txtSalary.Text);
            _employee.CareerId = Career.GetIdByName(cbCareer.Text);
            _employee.PersonId = int.Parse(labPersonId.Text);
            if (_employee.Save())
            {
                labEmployeeId.Text = _employee.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
