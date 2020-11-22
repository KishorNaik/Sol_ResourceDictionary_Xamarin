using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StylesLib.MyStyles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyOuterResourceDictionary : ResourceDictionary
    {
        public MyOuterResourceDictionary()
        {
            InitializeComponent();
        }
    }
}