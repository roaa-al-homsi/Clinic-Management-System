using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Prescriptions
{
    public partial class frmManagePrescriptions : Form
    {
        public frmManagePrescriptions()
        {
            InitializeComponent();
        }
        private void _RefreshPrescriptionsData()
        {
            dgvManagePrescriptions.DataSource = Prescription.All();
        }
        private void frmManagePrescriptions_Load(object sender, EventArgs e)
        {
            _RefreshPrescriptionsData();
        }
    }
}
