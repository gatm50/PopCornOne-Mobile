using System;
using System.Collections.ObjectModel;
using Cirrious.MvvmCross.ViewModels;
using Core.PhraseReference;
using Core.TranslationReference;
using Core.Models;
using Core.LanguageReference;
using System.Collections.Generic;

namespace Core.ViewModels
{
    public class DetailViewModel : MvxViewModel
    {
        public ObservableCollection<CompleteTranslation> Results { get; set; }
        private TranslationServiceClient _translationClient;
        private PhraseServiceClient _phraseClient;
        private LanguageServiceClient _languageClient;
        private List<Translation> _temporalTranslations;

        public DetailViewModel(string phraseId)
        {
            _translationClient = new TranslationServiceClient();
            _languageClient = new LanguageServiceClient();
            _phraseClient = new PhraseServiceClient();
#if SILVERLIGHT
            _translationClient.DisplayTranslationsByPhraseIdCompleted += new EventHandler<DisplayTranslationsByPhraseIdCompletedEventArgs>(DisplayTranslationsByPhraseIdCompleted);
            _languageClient.DisplayLanguagesCompleted += new EventHandler<DisplayLanguagesCompletedEventArgs>(DisplayLanguagesCompleted);

            _translationClient.DisplayTranslationsByPhraseIdAsync(Convert.ToInt32(phraseId));
#else
#endif
            

            this.Results = new ObservableCollection<CompleteTranslation>();
            _temporalTranslations = new List<Translation>();
        }

        void DisplayLanguagesCompleted(object sender, DisplayLanguagesCompletedEventArgs e)
        {
            foreach (var translation in _temporalTranslations)
            {
                foreach (var language in e.Result)
                {
                    if (translation.LanguageId == language.LanguageId)
                    {
                        this.Results.Add(new CompleteTranslation() { Translation = translation, Language = language });
                        break;
                    }
                }
            }
        }

        void DisplayTranslationsByPhraseIdCompleted(object sender, DisplayTranslationsByPhraseIdCompletedEventArgs e)
        {
            this.Results.Clear();
            foreach (var item in e.Result)
                _temporalTranslations.Add(item);

            _languageClient.DisplayLanguagesAsync();
        }
    }
}
