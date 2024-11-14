using ClinicSystem.MainMenu;
using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Employees
{
    public partial class frmManageEmployees : Form
    {
        private frmMainMenuScreen _frmMainMenuScreen;
        public frmManageEmployees(frmMainMenuScreen frmMainMenuScreen)
        {
            InitializeComponent();
            _frmMainMenuScreen = frmMainMenuScreen;
        }
        private void _RefreshEmployeeData()
        {
            dgvManageEmployees.DataSource = Employee.All();

        }
        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            _RefreshEmployeeData();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateEmployee(-1));
        }
        private void tsUpdate_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(dgvManageEmployees.CurrentRow.Cells[0].Value);
            _frmMainMenuScreen.OpenChildFormAsync(new frmAddUpdateEmployee(employeeId));
        }
    }
}
