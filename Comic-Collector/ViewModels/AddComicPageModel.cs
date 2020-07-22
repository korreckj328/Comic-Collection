using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamvvm;
using ComicCollector.Models;
using Comic_Collector;

namespace ComicCollector.ViewModels
{
    class AddComicPageModel : BasePageModel
    {
        public string AddButtonText
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        public ICommand AddButtonCommand { private set; get; }
        private async Task addBookAsync()
        {
            Comics newComic = new Comics();
            newComic.Name = ComicName;
            newComic.Number = ComicNumber;
            newComic.Publisher = Publisher;
            App.Database.AddComic(newComic);
            await this.PopPageAsync();
        }

        public string ComicNameText
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string ComicNumberText
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string PublisherText
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string PubDateText
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string ComicName
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string ComicNumber
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string Publisher
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public string PubDate
        {
            get
            {
                return GetField<string>();
            }
            set
            {
                SetField(value);
            }
        }

        public AddComicPageModel()
        {
            AddButtonCommand = new Command(() => addBookAsync());
            AddButtonText = "Add New Comic";
            ComicNameText = "Comic Book Name";
            ComicNumberText = "Comic Book Number";
            PublisherText = "Publisher";
            PubDateText = "Publication Date";
        }
    }
}
