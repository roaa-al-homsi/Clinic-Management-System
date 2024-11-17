using ClinicSystemBusiness;
using System;
using System.Windows.Forms;

namespace ClinicSystem.Payments
{
    public partial class frmManagePayments : Form
    {
        public frmManagePayments()
        {
            InitializeComponent();
        }
        private void _RefreshPaymentData()
        {
            dgvManageIPayments.DataSource = Payment.All();
        }
        private void frmManagePayments_Load(object sender, EventArgs e)
        {
            _RefreshPaymentData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAddUpdatePayment frmAddUpdatePayment = new frmAddUpdatePayment(-1);
            frmAddUpdatePayment.ShowDialog();
        }
    }
}
