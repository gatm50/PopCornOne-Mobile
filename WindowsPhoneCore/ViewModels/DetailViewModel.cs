using System;
using System.Collections.ObjectModel;
using Cirrious.MvvmCross.ViewModels;
using Core.PhraseReference;
using Core.TranslationReference;

namespace Core.ViewModels
{
    public class DetailViewModel : MvxViewModel
    {
        public string TranslationContent { get; set; }
        public ObservableCollection<Translation> Results { get; set; }
        private TranslationServiceClient _translationClient;
        private PhraseServiceClient _phraseClient;

        public DetailViewModel(string phraseId)
        {
            _translationClient = new TranslationServiceClient();
            _phraseClient = new PhraseServiceClient();

            _translationClient.DisplayTranslationsByPhraseIdCompleted += new EventHandler<DisplayTranslationsByPhraseIdCompletedEventArgs>(DisplayTranslationsByPhraseIdCompleted);

            _translationClient.DisplayTranslationsByPhraseIdAsync(Convert.ToInt32(phraseId));

            this.Results = new ObservableCollection<Translation>();
        }

        void DisplayTranslationsByPhraseIdCompleted(object sender, DisplayTranslationsByPhraseIdCompletedEventArgs e)
        {
            this.Results.Clear();
            foreach (var item in e.Result)
            {
                this.Results.Add(item);
            }
        }
    }
}
