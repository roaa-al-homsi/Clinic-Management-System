using ClinicSystem.Persons;
using ClinicSystemBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicSystem.Doctors
{
    public partial class frmAddUpdateDoctor : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private int _doctorId;
        private int _employeeId;
        private Doctor _doctor;
        private Employee _employee;

        public frmAddUpdateDoctor(int doctorId)
        {
            InitializeComponent();
            _doctorId = doctorId;
            _mode = _doctorId == -1 ? Mode.Add : Mode.Update;
        }
        private void _FillComboSpecialization()
        {
            DataTable dataTable = MedicalSpecialties.All();
            foreach (DataRow row in dataTable.Rows)
            {
                cbSpecialization.Items.Add(row["Name"]);
            }
        }
        private void _LoadDoctorData()
        {
            if (_mode == Mode.Add)
            {
                _doctor = new Doctor();
                this.Tag = "Add Doctor";
                return;
            }
            this.Tag = "Add Doctor";
            _doctor = Doctor.Find(_doctorId);
            _employeeId = _doctor.EmployeeId;
            labDoctorId.Text = _doctor.Id.ToString();
            labEmployeeDocId.Text = _doctor.EmployeeId.ToString();
            picPerson.ImageLocation = _doctor.Employee.Person.ImagePath;
            cbSpecialization.SelectedIndex = cbSpecialization.FindString(MedicalSpecialties.GetNameById(_doctor.MedicalSpecialtiesId));

        }
        private void _LoadEmployeeData()
        {
            if (_mode == Mode.Add)
            {
                _employee = new Employee();
                return;
            }

            _employee = Employee.Find(_employeeId);
            picPerson.ImageLocation = _employee.Person.ImagePath;
            labEmployeeId.Text = _employeeId.ToString();
            txtSalary.Text = _employee.Salary.ToString();
            labPersonId.Text = _employee.PersonId.ToString();
        }
        private void DataBackPerson(object sender, int personId)
        {
            Person person = Person.Find(personId);
            if (person != null)
            {
                uc_personInfo1.ViewDataPerson(person);
                labPersonId.Text = personId.ToString();
                picPerson.ImageLocation = person.ImagePath;
                picDoctor.ImageLocation = person.ImagePath;
            }
        }
        private void btnSelectPerson_Click_1(object sender, EventArgs e)
        {
            frmAddUpdatePersons addUpdatePersons = new frmAddUpdatePersons(_doctor.Employee.PersonId);
            addUpdatePersons.DataBack += DataBackPerson;
            addUpdatePersons.ShowDialog();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmAddUpdateDoctor_Load(object sender, EventArgs e)
        {
            _FillComboSpecialization();
            _LoadDoctorData();
            _LoadEmployeeData();
            cbSpecialization.SelectedIndex = 0;
        }
        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            _employee.Salary = int.Parse(txtSalary.Text);
            _employee.CareerId = Career.GetIdByName(txtCareer.Text);
            _employee.PersonId = int.Parse(labPersonId.Text);
            if (_employee.Save())
            {
                labEmployeeId.Text = _employee.Id.ToString();
                labEmployeeDocId.Text = _employee.Id.ToString();
                _employeeId = _employee.Id;
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _doctor.EmployeeId = Convert.ToInt16(labEmployeeDocId.Text);
            _doctor.MedicalSpecialtiesId = MedicalSpecialties.GetIdByName(cbSpecialization.Text);
            if (_doctor.Save())
            {
                labDoctorId.Text = _doctor.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
