using System;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using WikiKart.Models;
using WikiKart.Views.AccessApp;

namespace WikiKart.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public string email;
        public string password;
        public string name;
        public string age;

        public bool isRunning;
        public bool isVisible;
        public bool isEnabled;
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public string NameTxt
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        public string AgeTxt
        {
            get { return this.age; }
            set { SetValue(ref this.age, value); }
        }

        public bool IsVisibleTxt
        {
            get { return this.isVisible; }
            set { SetValue(ref this.isVisible, value); }
        }

        public bool IsEnabledTxt
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }

        public bool IsRunningTxt
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
        }
        private async void RegisterMethod()
        {
            if (string.IsNullOrEmpty(this.email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Tienes que introducir un correo electronico",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Tienes que introducir una contraseña",
                    "Aceptar");
                return;
            }

            
            if (string.IsNullOrEmpty(this.name))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Tienes que introducir tu nombre",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.age))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Tienes que introducir tu edad",
                    "Aceptar");
                return;
            }

            this.IsVisibleTxt = true;
            this.IsRunningTxt = true;
            this.IsEnabledTxt = false;


            var user = new UserModel
            {
                EmailField = email,
                PasswordField = password,
                NamesField = name,
                AgeField = age,
                Creation_Date = DateTime.Now,
            };

            await App.Database.SaveUserModelAsync(user);

            await Application.Current.MainPage.DisplayAlert("Te has registrado correctamente!! ", "Bienvenido " + name.ToString() + " a WikiKart", "Vale");

            this.IsRunningTxt = false;
            this.IsVisibleTxt = false;
            this.IsEnabledTxt = true;

            await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
            
        }
        public RegisterViewModel()
        {
            IsEnabledTxt = true;
        }
    }
}
