using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Insert.Models;
using Xamarin.Forms;

namespace Ejercicio_Insert
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Alumno alum = new Alumno
                {
                    Nombre=txtNombre.Text,
                    Apellido1=txtApellido1.Text,
                    Apellido2=txtApellido2.Text,
                    Edad=int.Parse(txtEdad.Text),
                    Correo=txtCorreo.Text,
                };
                await App.SQLiteDB.GuardarAlumno(alum);
                txtNombre.Text = "";
                txtApellido1.Text = "";
                txtApellido2.Text = "";
                txtEdad.Text = "";
                txtCorreo.Text = "";

                await DisplayAlert("Registro Guardado", "Se ha guardado con éxito el alumno", "OK");
                var alumnoList = await App.SQLiteDB.GetAlumnos();
                if (alumnoList!=null)
                {
                    LstAlumnos.ItemsSource = alumnoList;
                }


            }
            else
            {
                await DisplayAlert("Advertencia!", "Ingresar todos los datos", "OK");
            }
        }


        public bool ValidarDatos()
        {
            bool respuesta;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtApellido1.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtApellido2.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtEdad.Text))
            {
                respuesta = false;
            }
            else if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                respuesta = false;
            }
            else
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
