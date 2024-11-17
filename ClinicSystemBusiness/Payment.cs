using ClinicSystemDataAccess;
using System;
using System.Data;

namespace ClinicSystemBusiness
{
    public class Payment
    {
        private enum Mode { Add, Update }
        private Mode _mode;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string AdditionalNotes { get; set; }
        public int PaymentMethodsId { get; set; }
        public PaymentMethods PaymentMethods { get; set; }

        public Payment()
        {
            this.Id = -1;
            this.PaymentMethodsId = -1;
            this.Amount = 0;
            this.AdditionalNotes = string.Empty;
            this.PaymentMethodsId = 0;
            this.Date = DateTime.MinValue;
            this.PaymentMethods = new PaymentMethods();
            _mode = Mode.Add;
        }
        private Payment(int id, DateTime date, int amount, string additionalNotes, int paymentMethodId)
        {
            PaymentMethods = PaymentMethods.Find(paymentMethodId);
            this.PaymentMethodsId = paymentMethodId;
            this.Id = id;
            this.Date = date;
            this.Amount = amount;
            this.AdditionalNotes = additionalNotes;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = PaymentsData.Add(this.Date, this.Amount, this.AdditionalNotes, this.PaymentMethodsId);
            return (this.Id != -1);
        }
        private bool _Update()
        {
            return PaymentsData.Update(this.Id, this.Date, this.Amount, this.AdditionalNotes, this.PaymentMethodsId);
        }
        private bool _ReadyPayment()
        {
            if (this.Date == DateTime.MinValue || this.Amount <= 0 || !PaymentMethodsData.Exist(this.PaymentMethodsId))
            {
                return false;
            }
            return true;
        }
        public bool Save()
        {
            if (!_ReadyPayment())
            {
                return false;
            }

            switch (_mode)
            {
                case Mode.Add: return _Add();
                case Mode.Update: return _Update();
            }
            return false;
        }
        public static Payment Find(int id)
        {
            int amount = 0;
            DateTime date = DateTime.MinValue;
            string additionalNotes = string.Empty;
            int paymentMethodId = -1;
            if (PaymentsData.GetPayment(id, ref date, ref amount, ref additionalNotes, ref paymentMethodId))
            {
                return new Payment(id, date, amount, additionalNotes, paymentMethodId);
            }
            return null;
        }
        public static DataTable All()
        {
            return PaymentsData.All();
        }
        public static bool Exist(int id)
        {
            return PaymentsData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            else
            {
                return PaymentsData.Delete(id);
            }
        }
    }
}
