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
    public class VMMantenimiento : INotifyPropertyChanged
    {

        public VMMantenimiento()
        {
            getListadoMantenimientoAsync();
        }

        ItemMantenimiento mantenimientoSeleccionado;

        public ItemMantenimiento MantenimientoSeleccionado
        {
            get => mantenimientoSeleccionado;
            set
            {

                mantenimientoSeleccionado = value;
                var args = new PropertyChangedEventArgs(nameof(MantenimientoSeleccionado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<ItemMantenimiento> listaMantenimiento = new ObservableCollection<ItemMantenimiento>();

        public ObservableCollection<ItemMantenimiento> ListaMantenimiento { get => listaMantenimiento; }


        private async Task getListadoMantenimientoAsync()
        {

            RestClient cliente = new RestClient();

            var result = await cliente.ListaMantenimiento<MantenimientoModel>();

            if (result != null)
            {

                for (int i = 0; i < result.items.Count; i++)
                {

                    listaMantenimiento.Add(result.items[i]);
                }


            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
    
}
