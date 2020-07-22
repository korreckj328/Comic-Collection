using System;
using Xamvvm;
using ComicCollector.Models;


namespace ComicCollector.ViewModels
{
    public class ComicDetailPageModel: BasePageModel
    {
        private Comics comic;

        public ComicDetailPageModel()
        {
        }

        public string Test
        {
            get { return GetField<string>(); }
            set { SetField(value); }
        }

        public void Init(Comics _comic)
        {
            comic = _comic;
            Test = comic.Name;
        }
    }
}
