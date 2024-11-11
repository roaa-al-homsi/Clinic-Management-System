using ClinicSystemBusiness;
using System.Windows.Forms;

namespace ClinicSystem.UserControls
{
    public partial class uc_Persons : UserControl
    {
        public uc_Persons()
        {
            InitializeComponent();
        }

        public void ShowDataPerson(Person person)
        {
            if (person != null)
            {
                labPersoId.Text = person.Id.ToString();
                txtFullName.Text = person.Name;
                txtEmail.Text = person.Email;
                txtPhone.Text = person.Phone;
                txtAddress.Text = person.Address;
                cbGendre.SelectedItem = person.Gender;
                cbCountry.SelectedItem = person.Country;
                picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(person.ImagePath)) ? person.ImagePath : null;
            }
        }
    }
}
