using ClinicSystemDataAccess;
using System.Data;

namespace ClinicSystemBusiness
{
    public class PaymentMethods
    {
        private enum Mode { Add, Update };
        private Mode _mode;
        public int Id { get; set; }
        public string Name { get; set; }

        public PaymentMethods()
        {
            this.Id = -1;
            this.Name = string.Empty;
            _mode = Mode.Add;
        }
        private PaymentMethods(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            _mode = Mode.Update;
        }
        private bool _Add()
        {
            this.Id = PaymentMethodsData.Add(this.Name);
            return (this.Id == -1);
        }
        private bool _Update()
        {
            return PaymentMethodsData.Update(this.Id, this.Name);
        }
        public bool Save()
        {
            switch (_mode)
            {
                case Mode.Add: return _Add();
                case Mode.Update: return _Update();
            }
            return false;
        }
        public static PaymentMethods Find(int id)
        {
            string name = string.Empty;
            if (PaymentMethodsData.GetPaymentMethods(id, ref name))
            {
                return new PaymentMethods(id, name);
            }
            return null;
        }
        public static DataTable All()
        {
            return PaymentMethodsData.All();
        }
        public static bool Exist(int id)
        {
            return PaymentMethodsData.Exist(id);
        }
        public static bool Delete(int id)
        {
            if (!Exist(id))
            {
                return false;
            }
            return PaymentMethodsData.Delete(id);
        }
        public static string GetNameById(int id)
        {
            return PaymentMethodsData.GetNameById(id);
        }
        public static int GetIdByName(string name)
        {
            return PaymentMethodsData.GetIdByName(name);
        }
    }
}
