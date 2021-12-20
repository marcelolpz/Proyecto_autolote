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
    public class VMDetalle : INotifyPropertyChanged
    {
        public VMDetalle()
        {
            getListadoDetalleAsync();
        }

        ItemDetalle detalleSeleccionado;

        public ItemDetalle DetalleSeleccionado
        {
            get => detalleSeleccionado;
            set
            {

                detalleSeleccionado = value;
                var args = new PropertyChangedEventArgs(nameof(DetalleSeleccionado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<ItemDetalle> listaDetalle = new ObservableCollection<ItemDetalle>();

        public ObservableCollection<ItemDetalle> ListaDetalle { get => listaDetalle; }


        private async Task getListadoDetalleAsync()
        {

            RestClient cliente = new RestClient();

            var result = await cliente.ListaDetalle<DetalleModel>();

            if (result != null)
            {

                for (int i = 0; i < result.items.Count; i++)
                {

                    listaDetalle.Add(result.items[i]);
                }


            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }

}
