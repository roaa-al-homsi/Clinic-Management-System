using ClinicSystem.Permissions;
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
            _GetNamesOptionAllowedFromUserPermission(_user.Permission);
            labPersonId.Text = _user.PersonId.ToString();
        }
        private void frmAddUpdateUsers_Load(object sender, EventArgs e)
        {
            _LoadUserDataToForm();
        }
        private void _CalculatePermissionUser()
        {
            foreach (var checkedItem in checkedListBox1.CheckedItems)
            {
                string item = checkedItem.ToString();
                if (item == "Doctors")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Doctors;
                }
                else if (item == "Patients")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Patients;
                }
                else if (item == "Appointments")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Appointments;
                }
                else if (item == "Payments")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Payments;
                }
                else if (item == "Employees")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Employees;
                }
                else if (item == "Users")
                {
                    _PermissionOnlyUser += (int)ManagePermissions.enMainMenuPermission.Users;
                }
                if (_PermissionOnlyUser == 63)
                {
                    _PermissionOnlyUser = -1;
                }
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _PermissionOnlyUser = 0; // Reset and calculate the combined permission
            _CalculatePermissionUser();

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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void _GetNamesOptionAllowedFromUserPermission(int User_Permission)
        {
            checkedListBox1.BeginUpdate(); // Pause updates for performance
            try
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    string itemName = checkedListBox1.Items[i].ToString();
                    int permissionValue = 0;

                    // Map each item to its corresponding permission value
                    switch (itemName)
                    {
                        case "Doctors":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Doctors;
                            break;
                        case "Patients":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Patients;
                            break;
                        case "Appointments":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Appointments;
                            break;
                        case "Payments":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Payments;
                            break;
                        case "Employees":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Employees;
                            break;
                        case "Users":
                            permissionValue = (int)ManagePermissions.enMainMenuPermission.Users;
                            break;

                    }

                    // Check if the permission bit is set in User_Permission
                    if ((User_Permission & permissionValue) == permissionValue)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                    else
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            }
            finally
            {
                checkedListBox1.EndUpdate(); // Resume updates
            }
        }
        private void btnSelectPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePersons frmAddUpdate = new frmAddUpdatePersons(_user.PersonId);
            frmAddUpdate.DataBack += DataBackPerson;
            frmAddUpdate.ShowDialog();
        }
    }
}
