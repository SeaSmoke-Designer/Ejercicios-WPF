﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Superheroes.Service
{
    class DialogosService
    {
        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
