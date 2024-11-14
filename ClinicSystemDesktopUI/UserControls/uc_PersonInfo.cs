using ClinicSystemBusiness;
using System.Data;
using System.Windows.Forms;

namespace ClinicSystem.UserControls
{
    public partial class uc_personInfo : UserControl
    {
        public uc_personInfo()
        {
            InitializeComponent();
        }
        private void _FillComboBoxCountries()
        {
            DataTable dataTable = Countries.All();
            foreach (DataRow row in dataTable.Rows)
            {
                cbCountries.Items.Add(row["Name"]);
            }
        }
        public void ViewDataPerson(Person person)
        {
            if (person != null)
            {
                _FillComboBoxCountries();

                labPersonId.Text = person.Id.ToString();
                txtAddress.Text = person.Address;
                txtEmail.Text = person.Email;
                txtFullName.Text = person.Name;
                txtPhone.Text = person.Phone;
                TimePicBirthDate.Value = person.BirthDate;
                cbGendre.SelectedItem = person.Gender;
                cbCountries.SelectedIndex = cbCountries.FindString(Countries.GetNameByID(person.CountryId));
                picPerson.ImageLocation = string.IsNullOrEmpty(person.ImagePath) ? null : person.ImagePath;
            }
        }


    }
}
