using ClinicSystemBusiness;
using System.Data;
using System.Windows.Forms;

namespace ClinicSystem.Persons
{
    public partial class frmAddUpdatePersons : Form
    {
        //Declare a delegate 
        public delegate void DataBackEventHandle(object sender, int PersonId);
        public event DataBackEventHandle DataBack;
        private enum Mode { Add, Update }
        private Mode _mode;
        private int _personId;
        private Person _person;
        public frmAddUpdatePersons(int id)
        {
            InitializeComponent();
            _personId = id;
            _mode = (_personId == -1) ? Mode.Add : Mode.Update;
        }
        private void _FillComboBoxCountries()
        {
            DataTable dataTable = Countries.All();
            foreach (DataRow row in dataTable.Rows)
            {
                cbCountries.Items.Add(row["Name"]);
            }
        }
        private void _LoadPersonData()
        {

            if (_mode == Mode.Add)
            {
                _person = new Person();
                this.Text = "Add person";
                return;
            }
            else
            {
                this.Text = "Update Person";
                linkRemove.Visible = true;
                _person = Person.Find(_personId);
                labPersonId.Text = _personId.ToString();
                txtAddress.Text = _person.Address;
                txtEmail.Text = _person.Email;
                txtFullName.Text = _person.Name;
                txtPhone.Text = _person.Phone;
                TimePicBirthDate.Value = _person.BirthDate;
                cbGendre.SelectedItem = _person.Gender;
                cbCountries.SelectedIndex = cbCountries.FindString(Countries.GetNameByID(_person.CountryId));
                picPerson.ImageLocation = string.IsNullOrEmpty(_person.ImagePath) ? null : _person.ImagePath;
            }
        }
        private void frmAddUpdatePersons_Load(object sender, System.EventArgs e)
        {
            _FillComboBoxCountries();
            _LoadPersonData();
        }
        private void _FillPersonBeforeSave()
        {
            _person.Address = txtAddress.Text;
            _person.Email = txtEmail.Text;
            _person.Name = txtFullName.Text;
            _person.Phone = txtPhone.Text;
            _person.BirthDate = TimePicBirthDate.Value.Date;
            _person.CountryId = Countries.GetIdByName(cbCountries.Text);
            _person.Gender = cbGendre.SelectedItem.ToString();
            _person.ImagePath = (picPerson.ImageLocation != null) ? picPerson.ImageLocation.ToString() : string.Empty;

        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _FillPersonBeforeSave();
            if (_person.Save())
            {
                labPerson.Visible = true;
                labPersonId.Visible = true;
                labPersonId.Text = _person.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataBack?.Invoke(this, _person.Id);
            this.Close();
        }
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void linkSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                picPerson.Load(selectedFilePath);
                picPerson.ImageLocation = selectedFilePath;
            }
        }
        private void linkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPerson.ImageLocation = null;
        }

        private void txtPhone_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void cbGendre_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
