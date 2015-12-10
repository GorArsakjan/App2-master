using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App2.Model;
using App2.Common;
using App2.Persistency;

namespace App2.ViewModel
{
    public class RegisterViewModel
    {
        public ObservableCollection<RegisterModel> RegisterInfo { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _email { get; set; }
        public string _password { get; set; }
        public string _addres { get; set; }
        public string _creditCardNumber { get; set; }
        public string _zipCode { get; set; }
        public string _expiryMonth { get; set; }
        public string _expiryYear { get; set; }
        public string _city { get; set; }


        public RelayCommand AddRegisterInfo { get; set; }
        public RelayCommand GetRegisterInfo { get; set; }
        public RelayCommand SaveRegisterInfo { get; set; }

        public RegisterViewModel()
        {
            AddRegisterInfo = new RelayCommand(Add);
            GetRegisterInfo = new RelayCommand(LoadRegisterInfo);
            SaveRegisterInfo = new RelayCommand(Save);

            RegisterInfo = new ObservableCollection<RegisterModel>();

            RegisterInfo.Add(new RegisterModel("Toms", "Uluks", "ulukst@gmail.com", "whatadick", "ELIARARD","5555","Roskilde", "4000", "10","1996"));
        }

        public void Add()
        {
            RegisterInfo.Add(new RegisterModel(_firstName, _lastName, _email, _addres, _password, _creditCardNumber, _city, _zipCode, _expiryMonth, _expiryYear));
        }
        
        private async void LoadRegisterInfo()
        {
            var customerInfos = await PersistencyService.LoadRegisterInfoAsJsonAsync();
            if (customerInfos != null)
            {
                RegisterInfo.Clear();
                foreach (var customerInfo in RegisterInfo)
                {
                    RegisterInfo.Add(customerInfo);
                }
            }
        }
    
        public async void Save()
        {
            MainPageModel page = new MainPageModel();

            RegisterInfo.Add(new RegisterModel(_firstName, _lastName, _email, _addres, _password, _creditCardNumber, _city, _zipCode, _expiryMonth, _expiryYear));
            PersistencyService.SaveRegisterInfoAsJsonAsync(RegisterInfo);


        }



    }
}


        
    
