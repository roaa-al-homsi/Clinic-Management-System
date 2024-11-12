using ClinicSystem.Persons;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Employees
{
    public partial class frmAddUpdateEmployee : Form
    {


        public frmAddUpdateEmployee()
        {
            InitializeComponent();
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
            cbCountry.SelectedItem = person.Country;
            cbGendre.SelectedItem = person.Gender;
            TimePicBirthDate.Value = person.BirthDate.Date;
            picPerson.ImageLocation = (string.IsNullOrWhiteSpace(person.ImagePath) ? null : person.ImagePath);

        }
        private void DataBackPerson(object sender, int personId)
        {
            Person person = Person.Find(personId);
            if (person != null)
            {
                labPersonId.Text = personId.ToString();
                LoadPersonInfo(person);
                panelContainerEmployeeInfo.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
