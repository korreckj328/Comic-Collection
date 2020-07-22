using System;
using ComicCollector.Models;
using Xamvvm;
using System.Collections.ObjectModel;
using Comic_Collector;
using System.Windows.Input;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComicCollector.ViewModels
{
    public class MainPageModel: BasePageModel
    {
        public ICommand ComicTapped { private set; get; }

        private async Task comicTapped(Comics comic)
        {
            var pageToPush = this.GetPageFromCache<ComicDetailPageModel>();
            await this.PushPageAsync(pageToPush, (pm) => pm.Init(comic));
        }
        public ICommand AddComicCommand { private set; get; }

        private async Task addComicAsync()
        {
            var pageToPush = this.GetPageFromCache<AddComicPageModel>();
            await this.PushPageAsync(pageToPush);
        }

        public string AddButtonText
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
        
        public string Title
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }
        private ObservableCollection<Comics> _collection
        {
            get
            {
                return _collection;
            }
            set
            {
                _collection = value;
            }
        }

        public ObservableCollection<Comics> Collection
        {
            get { return GetField<ObservableCollection<Comics>>(); }
            set { SetField(value); }
        }

        public void UpdateProperties()
        {
            Collection = new ObservableCollection<Comics>(App.Database.GetComics());
        }

        public MainPageModel()
        {
            ComicTapped = new Command<Comics>((c) => comicTapped(c));
            AddComicCommand = new Command(() => addComicAsync());
            AddButtonText = "+";
            Title = "Comic Collector";
            Collection = new ObservableCollection<Comics>(App.Database.GetComics());
        }
    }
}
