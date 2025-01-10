using Comida.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Comida.VistaModelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set
            {
                platos = value;
                this.NotifyPropertyChanged("Platos");
            }
        }

        private ObservableCollection<String> tipos;

        public ObservableCollection<String> Tipos
        {
            get { return tipos; }
            set
            {
                tipos = value;
                this.NotifyPropertyChanged("Tipos");
            }
        }

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                this.NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public void LimpiarSeleccion()
        {
            PlatoSeleccionado = null;
        }

        public MainWindowVM()
        {
            Platos = Plato.GetSamples("C:/Users/alumno/Documents/Recursos-Platos-UT5-Actividad/Platos");
            Tipos = new ObservableCollection<string> { "China", "Americana", "Mexicana" };
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
