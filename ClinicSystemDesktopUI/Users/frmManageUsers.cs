using ClinicSystem.MainMenu;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Users
{
    public partial class frmManageUsers : Form
    {
        private frmMainMenuScreen _MainMenuScreen;
        public frmManageUsers(frmMainMenuScreen frmMainMenuScreen)
        {
            InitializeComponent();
            _MainMenuScreen = frmMainMenuScreen;
        }
        private void _RefreshUsersData()
        {
            dgvAllUsers.DataSource = User.All();
        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsersData();
        }
        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            _MainMenuScreen.OpenChildFormAsync(new frmAddUpdateUsers(-1));
        }
        private void ItemUpdate_Click_1(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(dgvAllUsers.CurrentRow.Cells[0].Value);
            _MainMenuScreen.OpenChildFormAsync(new frmAddUpdateUsers(userId));
        }
        private void ItemDelete_Click_1(object sender, EventArgs e)
        {
            int UserId = (int)dgvAllUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure delete this Customer?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (User.Delete(UserId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshUsersData();
        }
    }
}
