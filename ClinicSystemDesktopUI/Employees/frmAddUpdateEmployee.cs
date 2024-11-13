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
        private int _id;
        private Employee _employee;
        public frmAddUpdateEmployee(int employeeId)
        {
            InitializeComponent();
            _id = employeeId;
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
            _employee = Employee.Find(_id);
            this.Tag = "Update Employee";
            txtSalary.Text = _employee.Salary.ToString();
            cbCareer.SelectedIndex = cbCareer.FindString(Career.GetNameById(_employee.CareerId));
            labPersonId.Text = _employee.PersonId.ToString();
            labEmployeeId.Visible = true;
            labEmployeeId.Text = _employee.Id.ToString();
            labEmployee.Visible = true;

        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePersons addUpdatePersons = new frmAddUpdatePersons(-1);
            addUpdatePersons.DataBack += DataBackPerson;
            addUpdatePersons.ShowDialog();
        }
        private void LoadPersonInfo(Person person)
        {
            txtAddress.Text = person.Address;
            txtEmail.Text = person.Email;
            txtFullName.Text = person.Name;
            txtPhone.Text = person.Phone;
            cbCountry.SelectedIndex = cbCountry.FindString(Countries.GetNameByID(person.CountryId));
            cbGendre.SelectedItem = person.Gender;
            if (person.BirthDate != DateTime.MinValue)
            {
                TimePicBirthDate.Value = person.BirthDate;
            }

            picPerson1.ImageLocation = (string.IsNullOrWhiteSpace(person.ImagePath) ? null : person.ImagePath);
            picPerson.ImageLocation = (string.IsNullOrWhiteSpace(person.ImagePath) ? null : person.ImagePath);
        }
        private void DataBackPerson(object sender, int personId)
        {
            Person person = Person.Find(personId);
            if (person != null)
            {
                LoadPersonInfo(person);
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
                labEmployee.Visible = true;
                labEmployeeId.Visible = true;
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
