using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Employees
{
    public partial class frmManageEmployees : Form
    {
        public frmManageEmployees()
        {
            InitializeComponent();
        }
        private void _RefreshEmployeeData()
        {
            dgvManageEmployees.DataSource = Employee.All();


        }
        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            _RefreshEmployeeData();
        }
    }
}
