using System;
using System.Collections.Generic;
using Xamvvm;
using Xamarin.Forms;
using ComicCollector.ViewModels;

namespace ComicCollector.Views
{
    public partial class ComicDetailPage : ContentPage, IBasePage<ComicDetailPageModel>
    {
        public ComicDetailPage()
        {
            InitializeComponent();
        }
    }
}
