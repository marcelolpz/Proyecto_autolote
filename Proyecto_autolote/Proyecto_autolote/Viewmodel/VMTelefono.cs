using Proyecto_autolote.ModelsWebServices;
using Proyecto_autolote.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_autolote.Viewmodel
{
    public class VMTelefono : INotifyPropertyChanged
    {
        public VMTelefono()
        {
            getListadoTelefonoAsync();
        }

        ItemTelefono telefonoSeleccionado;

        public ItemTelefono TelefonoSeleccionado
        {
            get => telefonoSeleccionado;
            set
            {

                telefonoSeleccionado = value;
                var args = new PropertyChangedEventArgs(nameof(TelefonoSeleccionado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<ItemTelefono> listaTelefono = new ObservableCollection<ItemTelefono>();

        public ObservableCollection<ItemTelefono> ListaTelefono { get => listaTelefono; }


        private async Task getListadoTelefonoAsync()
        {

            RestClient cliente = new RestClient();

            var result = await cliente.ListaTelefono<TelefonoModel>();

            if (result != null)
            {

                for (int i = 0; i < result.items.Count; i++)
                {

                    listaTelefono.Add(result.items[i]);
                }


            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

}

