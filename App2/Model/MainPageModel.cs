using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using App2.Annotations;

namespace App2.Model
{
    public class MainPageModel : INotifyPropertyChanged
    {

     
            private string _password;
            private string _email;
            public string password;
            public string email;

            public MainPageModel()
            {
                Password = password;
                Email = email;
            }

        public string Email
            {
                get { return _email; }
                set { _email = value; }

            }
            public string Password
            {
                get { return _password; }
                set { _password = value; }

            }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    }

