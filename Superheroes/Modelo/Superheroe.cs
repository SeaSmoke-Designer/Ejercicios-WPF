using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Superheroes.Modelo
{
    class Superheroe : ObservableObject
    {
        private string nombre;
        private string imagen;
        private bool vengador;
        private bool xmen;
        private bool heroe;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (this.nombre != value)
                {
                    this.nombre = value;

                }
            }
        }
        public string Imagen
        {
            get => imagen;
            set
            {
                if (this.imagen != value)
                {
                    this.imagen = value;
                }
            }
        }
        public bool Vengador
        {
            get => vengador;
            set
            {
                if (this.vengador != value)
                {
                    this.vengador = value;
                }
            }
        }
        public bool Xmen
        {
            get => xmen;
            set
            {
                if (this.xmen != value)
                {
                    this.xmen = value;
                }
            }
        }
        public bool Heroe
        {
            get => heroe;
            set
            {
                if (this.heroe != value)
                {
                    this.heroe = value;
                }
            }
        }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }



        public static ObservableCollection<Superheroe> GetSamples()
        {
            ObservableCollection<Superheroe> ejemplos = new ObservableCollection<Superheroe>();

            Superheroe ironman = new Superheroe("Ironman", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superheroe kingpin = new Superheroe("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superheroe spiderman = new Superheroe("Spiderman", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }

        public static implicit operator Superheroe(int v)
        {
            throw new NotImplementedException();
        }
    }
}
