﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Juego_de_preguntas.Servicios
{
    class ServicioDialogos
    {
        public void MostrarMensaje(string mensaje,string titulo,MessageBoxButton button, MessageBoxImage image)
        {
            MessageBox.Show(mensaje, titulo, button,image);
        }

        public string OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files |*.png;*.jpeg;*.jpg|" + "JSON files |*.json";
            openFileDialog.InitialDirectory = @"c:\temp\";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                   return openFileDialog.FileName;
            }
            return "";
        }

        public string SaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON files |*.json";
            saveFileDialog.InitialDirectory = @"c:\temp\";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (saveFileDialog.ShowDialog() == true)
                return saveFileDialog.FileName;

            return "";
        }
    }
}
