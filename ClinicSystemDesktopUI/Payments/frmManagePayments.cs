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
            dgvManageIPayments.DataSource = MedicalRecords.All();
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int paymentId = Convert.ToInt16(dgvManageIPayments.CurrentRow.Cells[0].Value);
            frmAddUpdatePayment frmAddUpdatePayment = new frmAddUpdatePayment(paymentId);
            frmAddUpdatePayment.ShowDialog();
            _RefreshPaymentData();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int paymentId = Convert.ToInt32(dgvManageIPayments.CurrentRow.Cells[0].Value);

            if (MessageBox.Show("Are you sure delete this payment?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (MedicalRecords.Delete(paymentId))
                {
                    MessageBox.Show("Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            _RefreshPaymentData();
        }
    }
}
