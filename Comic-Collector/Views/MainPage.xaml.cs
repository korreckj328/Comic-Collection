using System;
using System.Collections.Generic;
using Xamvvm;
using ComicCollector.ViewModels;

using Xamarin.Forms;

namespace ComicCollector.Views
{
    public partial class MainPage : ContentPage, IBasePage<MainPageModel>
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
