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
    public class VMCliente : INotifyPropertyChanged
    {


        public VMCliente()
        {
            getListadoClienteAsync();
        }

        ItemCliente clienteSeleccionado;

        public ItemCliente ClienteSeleccionado
        {
            get => clienteSeleccionado;
            set
            {

                clienteSeleccionado = value;
                var args = new PropertyChangedEventArgs(nameof(ClienteSeleccionado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<ItemCliente> listaCliente = new ObservableCollection<ItemCliente>();

        public ObservableCollection<ItemCliente> ListaCliente { get => listaCliente; }


        private async Task getListadoClienteAsync()
        {

            RestClient cliente = new RestClient();

            var result = await cliente.ListaCliente<ClienteModel>();

            if (result != null)
            {

                for (int i = 0; i < result.items.Count; i++)
                {

                    listaCliente.Add(result.items[i]);
                }


            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

}
    

