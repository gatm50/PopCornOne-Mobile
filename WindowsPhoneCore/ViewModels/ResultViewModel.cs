using System;
using System.Collections.ObjectModel;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.ViewModels;
using Core.TranslationReference;

namespace Core.ViewModels
{
    public class ResultViewModel : MvxViewModel
    {
        public ObservableCollection<Translation> Results { get; set; }
        public string Value { get; set; }
#if SILVERLIGHT
        private TranslationServiceClient _translationClient;
#else
        private TranslationService _translationClient;
#endif
        public ResultViewModel(string valueToQuery = "", string type = "")
        {
            this.Results = new ObservableCollection<Translation>();
#if SILVERLIGHT
            _translationClient = new TranslationServiceClient();

            _translationClient.DisplayTranslationByLexiconCompleted += new EventHandler<DisplayTranslationByLexiconCompletedEventArgs>(DisplayTranslationByLexiconCompleted);
            _translationClient.DisplayTranslationByFirstLetterCompleted += new EventHandler<DisplayTranslationByFirstLetterCompletedEventArgs>(DisplayTranslationByFirstLetterCompleted);
            _translationClient.DisplayTranslationByLanguageCompleted += new EventHandler<DisplayTranslationByLanguageCompletedEventArgs>(DisplayTranslationByLanguageCompleted);
#else
            _translationClient = new TranslationService();

            _translationClient.DisplayTranslationByLexiconCompleted += new DisplayTranslationByLexiconCompletedEventHandler(DisplayTranslationByLexiconCompleted);
            _translationClient.DisplayTranslationByFirstLetterCompleted += new DisplayTranslationByFirstLetterCompletedEventHandler(DisplayTranslationByFirstLetterCompleted);
            _translationClient.DisplayTranslationByLanguageCompleted += new DisplayTranslationByLanguageCompletedEventHandler(DisplayTranslationByLanguageCompleted);
#endif
            this.PhraseCommand = new MvxRelayCommand<Translation>(this.GoPhrase_Execute, this.GoPhrase_CanExecute);

            this.ExecuteQueryByType(type, valueToQuery);
        }

        private void ExecuteQueryByType(string type, string valueToQuery)
        {
            switch (type)
            {
                case "ByFirstCharacter":
#if SILVERLIGHT
                    _translationClient.DisplayTranslationByFirstLetterAsync(valueToQuery, 1);
#else
                    _translationClient.DisplayTranslationByFirstLetterAsync(valueToQuery, 1, true);
#endif
                    break;
                case "ByLexicon":
#if SILVERLIGHT
                    _translationClient.DisplayTranslationByLexiconAsync(valueToQuery, 1);
#else
                    _translationClient.DisplayTranslationByLexiconAsync(valueToQuery, 1, true);
#endif
                    break;
                case "ByLanguage":
#if SILVERLIGHT
                    _translationClient.DisplayTranslationByLanguageAsync(1);
#else
                    _translationClient.DisplayTranslationByLanguageAsync(1, true);
#endif
                    break;
                default:
#if SILVERLIGHT
                    _translationClient.DisplayTranslationByLanguageAsync(1);
#else
                    _translationClient.DisplayTranslationByLanguageAsync(1, true);
#endif
                    break;
            }
        }

        void DisplayTranslationByLanguageCompleted(object sender, DisplayTranslationByLanguageCompletedEventArgs e)
        {
            this.Results.Clear();
            foreach (var item in e.Result)
            {
                item.TranslationContent = this.TruncateTex(item.TranslationContent);
                this.Results.Add(item);
            }
        }

        void DisplayTranslationByFirstLetterCompleted(object sender, DisplayTranslationByFirstLetterCompletedEventArgs e)
        {
            this.Results.Clear();
            foreach (var item in e.Result)
            {
                item.TranslationContent = this.TruncateTex(item.TranslationContent);
                this.Results.Add(item);
            }
        }

        void DisplayTranslationByLexiconCompleted(object sender, DisplayTranslationByLexiconCompletedEventArgs e)
        {
            this.Results.Clear();
            foreach (var item in e.Result)
            {
                item.TranslationContent = this.TruncateTex(item.TranslationContent);
                this.Results.Add(item);
            }
        }

        private string TruncateTex(string phrase)
        {
            if (phrase.Length > 21)
            {
                string result = phrase.Substring(0, 20);
                int indexLastSpace = 0;
                for (int i = result.Length; i > 10; i--)
                {
                    if (result[i - 1] == ' ')
                    {
                        indexLastSpace = i;
                        break;
                    }
                }

                result = phrase.Substring(0, indexLastSpace) + "\n";

                if (phrase.Length > 42)
                    result += phrase.Substring(indexLastSpace, 20) + "...";
                return result;
            }

            return phrase;
        }

        #region Phrase Command
        public IMvxCommand PhraseCommand { get; set; }
        void GoPhrase_Execute(object parameters)
        {
            string phraseId = (parameters as Translation).PhraseId.ToString();
            RequestNavigate<DetailViewModel>(new { phraseId = phraseId });
        }

        bool GoPhrase_CanExecute(object parameters)
        {
            return true;
        }
        #endregion
    }
}
