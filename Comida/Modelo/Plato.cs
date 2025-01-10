﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida.Modelo
{
    class Plato : INotifyPropertyChanged
    {
        private string nombre;
        private string imagen;
        private string tipo;
        private bool gluten;
        private bool soja;
        private bool leche;
        private bool sulfitos;

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                this.NotifyPropertyChanged("Nombre");
            }
        }
        public string Imagen
        {
            get => imagen;
            set
            {
                imagen = value;
                this.NotifyPropertyChanged("Imagen");
            }
        }
        public string Tipo
        {
            get => tipo;
            set
            {
                tipo = value;
                this.NotifyPropertyChanged("Tipo");
            }
        }
        public bool Gluten
        {
            get => gluten;
            set
            {
                gluten = value;
                this.NotifyPropertyChanged("Gluten");
            }
        }
        public bool Soja
        {
            get => soja;
            set
            {
                soja = value;
                this.NotifyPropertyChanged("Soja");
            }
        }
        public bool Leche
        {
            get => leche;
            set
            {
                leche = value;
                this.NotifyPropertyChanged("Leche");
            }
        }
        public bool Sulfitos
        {
            get => sulfitos; 
            set
            {
                sulfitos = value;
                this.NotifyPropertyChanged("Sulfitos");
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
