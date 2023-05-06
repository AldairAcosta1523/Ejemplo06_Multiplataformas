using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejemplo06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<People> Peoples { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Peoples = new ObservableCollection<People>
        {
            new People("A")
            {
                new Datos { Title = "Armando", Subtitle = "Casas" , Date="34"},
                new Datos { Title = "Antonio", Subtitle = "De las Casas" , Date="30"},
                new Datos { Title = "Aldair", Subtitle = "Acosta", Date="38" },
                new Datos { Title = "Arturo", Subtitle = "Barrera", Date="42" }
            },
            new People("B")
            {
                new Datos { Title = "Bernardo", Subtitle = "Lumia" , Date="24" },
                new Datos { Title = "Benjamín", Subtitle = "Xperia" , Date="14"},
                new Datos { Title = "Bruno", Subtitle = "Desire" , Date="44"},
                new Datos { Title = "Ben", Subtitle = "Chocolate", Date="36" }
            },
            new People("C")
            {
                new Datos { Title = "Carmen", Subtitle = "Brighton" , Date="22"},
                new Datos { Title = "Catalina", Subtitle = "Hennietta" , Date="20"},
                new Datos { Title = "Cecilia", Subtitle = "Diego" , Date="19"},
                new Datos { Title = "Cristóbal", Subtitle = "Dallas", Date="56" }
            },
            new People("D")
            {
                new Datos { Title = "Daniel", Subtitle = "Brighton", Date="32" },
                new Datos { Title = "Diego", Subtitle = "Hennietta" , Date="30"},
                new Datos { Title = "David", Subtitle = "Diego" , Date="24"},
                new Datos { Title = "Dario", Subtitle = "Dallas", Date="22" }
            },
            new People("E")
            {
                new Datos { Title = "Eduardo", Subtitle = "Brighton", Date="34" },
                new Datos { Title = "Esteban", Subtitle = "Hennietta" , Date="39"},
                new Datos { Title = "Enrique", Subtitle = "Diego", Date="62" },
                new Datos { Title = "Esperanza", Subtitle = "Dallas", Date="45" }
            },
        };
            GroupedView.ItemsSource = Peoples;
        }
    }
}