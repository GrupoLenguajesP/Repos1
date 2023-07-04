using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PantallaDetalle
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            //este va a ser el menu lateral el del lado izquierodo
            this.Master= new Master();

            //y el del lado derecho
            //este me va a almacenar cmo primera venbtana un new detalle
            this.Detail = new NavigationPage(new Detalle());

        }
    }
}
