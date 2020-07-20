using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamvvm;
using ComicCollector.ViewModels;

namespace ComicCollector.Views
{
    public partial class AddComicPage : ContentPage, IBasePage<AddComicPageModel>
    {
        public AddComicPage()
        {
            InitializeComponent();
        }
    }
}
