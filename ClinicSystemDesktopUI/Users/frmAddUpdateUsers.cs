using ClinicSystem.Persons;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Users
{
    public partial class frmAddUpdateUsers : Form
    {
        public frmAddUpdateUsers(int userId)
        {
            InitializeComponent();
            _UserId = userId;
            _mode = (_UserId == -1) ? Mode.Add : Mode.Update;
        }
        private enum Mode { Add, Update }
        private Mode _mode;
        private User _user;
        private int _UserId;
        private int _PermissionOnlyUser = 0;


        private void _LoadUserDataToForm()
        {
            if (_mode == Mode.Add)
            {
                this.Tag = "Add User";
                _user = new User();
                return;
            }
            this.Tag = "Update User";
            panelContainerUserInfo.Enabled = true;
            _user = User.FindById(_UserId);
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;

            labPersonId.Text = _user.PersonId.ToString();
        }
        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _LoadUserDataToForm();
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            _PermissionOnlyUser = 0; // Reset and calculate the combined permission


            _user.PersonId = int.Parse(labPersonId.Text);
            _user.UserName = txtUserName.Text;
            _user.Password = txtPassword.Text;
            _user.Permission = _PermissionOnlyUser;

            if (_user.Save())
            {
                labUser.Visible = true;
                labUserId.Visible = true;
                labUserId.Text = _user.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed Successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelectPerson_Click(object sender, System.EventArgs e)
        {
            frmAddUpdatePersons frmAddUpdate = new frmAddUpdatePersons(_user.PersonId);
            frmAddUpdate.DataBack += DataBackPerson;
            frmAddUpdate.ShowDialog();
        }
        private void DataBackPerson(object sender, int PersonId)
        {
            Person person = Person.Find(PersonId);
            if (person != null)
            {
                uc_personInfo1.ViewDataPerson(person);
                labPersonId.Text = PersonId.ToString();
                picPerson.ImageLocation = (!string.IsNullOrWhiteSpace(person.ImagePath)) ? person.ImagePath : null;
                panelContainerUserInfo.Enabled = true;
            }
        }



    }
}
