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
#if SILVERLIGHT
        private TranslationServiceClient _translationClient;
        private PhraseServiceClient _phraseClient;
        private LanguageServiceClient _languageClient;
#else
        private TranslationService _translationClient;
        private PhraseService _phraseClient;
        private LanguageService _languageClient;
#endif
        private List<Translation> _temporalTranslations;

        public DetailViewModel(string phraseId)
        {
            this.Results = new ObservableCollection<CompleteTranslation>();
            _temporalTranslations = new List<Translation>();
#if SILVERLIGHT
            _translationClient = new TranslationServiceClient();
            _languageClient = new LanguageServiceClient();
            _phraseClient = new PhraseServiceClient();

            _translationClient.DisplayTranslationsByPhraseIdCompleted += new EventHandler<DisplayTranslationsByPhraseIdCompletedEventArgs>(DisplayTranslationsByPhraseIdCompleted);
            _languageClient.DisplayLanguagesCompleted += new EventHandler<DisplayLanguagesCompletedEventArgs>(DisplayLanguagesCompleted);

            _translationClient.DisplayTranslationsByPhraseIdAsync(Convert.ToInt32(phraseId));
#else
            _translationClient = new TranslationService();
            _languageClient = new LanguageService();
            _phraseClient = new PhraseService();

            _translationClient.DisplayTranslationsByPhraseIdCompleted += new DisplayTranslationsByPhraseIdCompletedEventHandler(DisplayTranslationsByPhraseIdCompleted);
            _languageClient.DisplayLanguagesCompleted += new DisplayLanguagesCompletedEventHandler(DisplayLanguagesCompleted);

            _translationClient.DisplayTranslationsByPhraseIdAsync(Convert.ToInt32(phraseId), true);
#endif
        }

        void DisplayLanguagesCompleted(object sender, DisplayLanguagesCompletedEventArgs e)
        {
            foreach (var translation in _temporalTranslations)
            {
                foreach (var language in e.Result)
                {
                    if (translation.LanguageId == language.LanguageId)
                    {
                        this.Results.Add(new CompleteTranslation(translation,language)); /*{ Translation = translation, Language = language }*/
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
