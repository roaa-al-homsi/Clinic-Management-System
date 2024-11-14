using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Doctors
{
    public partial class frmManageDoctorcs : Form
    {
        public frmManageDoctorcs()
        {
            InitializeComponent();
        }
        private void _RefreshDoctorsData()
        {
            dgvManageDoctors.DataSource = Doctor.All();
        }
        private void frmManageDoctorcs_Load(object sender, EventArgs e)
        {
            _RefreshDoctorsData();
        }
    }
}
