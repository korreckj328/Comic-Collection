using System;
using ComicCollector.Models;
using Xamvvm;
using System.Collections.ObjectModel;
using Comic_Collector;

namespace ComicCollector.ViewModels
{
    public class MainPageModel: BasePageModel
    {
        private ObservableCollection<Comics> _collection
        {
            get
            {
                return new ObservableCollection<Comics>(App.Database.GetComics());
            }
        }

        public ObservableCollection<Comics> Collection
        {
            get
            {
                return _collection;
            }
            set
            {
                SetField(value);
            }
        }

        public MainPageModel()
        {
        }
    }
}
