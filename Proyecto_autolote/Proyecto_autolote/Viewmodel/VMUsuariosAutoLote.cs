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
    public class VMUsuariosAutoLote : INotifyPropertyChanged
    {

        public VMUsuariosAutoLote()
        {

            getListadoUsuariosAsync();

        }

        ItemUsuario usuarioSeleccionado;

        public ItemUsuario UsuarioSeleccionado
        {
            get => usuarioSeleccionado;
            set
            {

                usuarioSeleccionado = value;
                var args = new PropertyChangedEventArgs(nameof(UsuarioSeleccionado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        ObservableCollection<ItemUsuario> listaUsuarios = new ObservableCollection<ItemUsuario>();

        public ObservableCollection<ItemUsuario> ListaUsuarios { get => listaUsuarios; }


        private async Task getListadoUsuariosAsync()
        {

            RestClient cliente = new RestClient();

            var result = await cliente.ListaUsuarios<UsuarioModel>();

            if (result != null)
            {

                for (int i = 0; i < result.items.Count; i++)
                {

                    listaUsuarios.Add(result.items[i]);
                }


            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
