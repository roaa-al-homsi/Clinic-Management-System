using ClinicSystemBusiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClinicSystem.Payments
{
    public partial class frmAddUpdatePayment : Form
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        private int _paymentId;
        private Payment _payment;
        public frmAddUpdatePayment(int paymentId)
        {
            InitializeComponent();
            _paymentId = paymentId;
            _mode = _paymentId == -1 ? Mode.Add : Mode.Update;
        }
        private void _FillComboPaymentsMethods()
        {
            DataTable dataTable = PaymentMethods.All();
            foreach (DataRow row in dataTable.Rows)
            {
                cbMethods.Items.Add(row["Name"]);
            }
        }
        private void _LoadPaymentData()
        {
            if (_mode == Mode.Add)
            {
                _payment = new Payment();
                this.Text = "Add Payment";
                return;
            }
            this.Text = "Update Payment";
            _payment = Payment.Find(_paymentId);
            txtAmount.Text = _payment.Amount.ToString();
            txtNotes.Text = _payment.AdditionalNotes.ToString();
            tpDatePayment.Value = _payment.Date;
            labPaymentId.Text = _payment.Id.ToString();
            cbMethods.SelectedIndex = cbMethods.FindString(PaymentMethods.GetNameById(_payment.PaymentMethodsId));
        }
        private void frmAddUpdatePayment_Load(object sender, EventArgs e)
        {
            _FillComboPaymentsMethods();
            _LoadPaymentData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _payment.Amount = Convert.ToInt16(txtAmount.Text);
            _payment.AdditionalNotes = txtNotes.Text;
            _payment.Date = tpDatePayment.Value;
            _payment.PaymentMethodsId = PaymentMethods.GetIdByName(cbMethods.Text);
            if (_payment.Save())
            {
                labPaymentId.Text = _payment.Id.ToString();
                MessageBox.Show("Data Saved Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
