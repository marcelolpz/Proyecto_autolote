using Proyecto_autolote.ModelsWebServices;
using Proyecto_autolote.Services;
using Proyecto_autolote.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto_autolote.Viewmodel
{
    public class VMMainPage : INotifyPropertyChanged
    {
        public VMMainPage()
        {

            Ingresar = new Command(async () => {


                RestClient client = new RestClient();
                var result = await client.validacionUsuario<Authenticator>(
                    this.usuario,
                    this.pass);


                if (result.items[0].validacion == 1)
                {

                    VWPaginaPrincipal mn = new VWPaginaPrincipal();
                    NavigationPage.SetHasBackButton(mn, false);
                    await App.Current.MainPage.Navigation.PushAsync(mn);

                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Mensaje",
                        "Usuario y Contraseña Incorrectos", "Ok");

                    Resultado = "Error de Inicio de Sesion!";
                }


            });

        }

        string usuario = "";

        public string Usuario
        {
            get => usuario;
            set
            {
                usuario = value;
                var args = new PropertyChangedEventArgs(nameof(Usuario));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string pass;

        public string Pass
        {
            get => pass;
            set
            {
                pass = value;
                var args = new PropertyChangedEventArgs(nameof(Pass));
                PropertyChanged?.Invoke(this, args);

            }
        }

        string resultado;

        public string Resultado
        {
            get => resultado;
            set
            {
                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);

            }
        }

        public Command Ingresar { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
