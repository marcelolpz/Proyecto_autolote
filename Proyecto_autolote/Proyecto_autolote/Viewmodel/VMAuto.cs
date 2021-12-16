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
    public class VMAuto : INotifyPropertyChanged
    {
        public VMAuto()
        {
            getListadoAutoAsync();
        }

        ItemAuto autoSeleccionado;

        public ItemAuto AutoSeleccionado
        {
            get => autoSeleccionado;
            set
            {

                autoSeleccionado = value;
                var args = new PropertyChangedEventArgs(nameof(AutoSeleccionado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<ItemAuto> listaAutos = new ObservableCollection<ItemAuto>();

        public ObservableCollection<ItemAuto> ListaAutos { get => listaAutos; }


        private async Task getListadoAutoAsync()
        {

            RestClient cliente = new RestClient();

            var result = await cliente.ListaAutos<AutoModel>();

            if (result != null)
            {

                for (int i = 0; i < result.items.Count; i++)
                {

                    listaAutos.Add(result.items[i]);
                }


            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
    
}
