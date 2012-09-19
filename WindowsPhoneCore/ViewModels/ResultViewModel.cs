using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.ViewModels;
using WindowsPhoneCore.TranslationReference;

namespace WindowsPhoneCore.ViewModels
{
    public class ResultViewModel : MvxViewModel
    {
        public ObservableCollection<Translation> Results { get; set; }
        public string Value { get; set; }
        private TranslationServiceClient _translationClient;

        public ResultViewModel(string valueToQuery = "", string type = "")
        {
            this.Results = new ObservableCollection<Translation>();
            _translationClient = new TranslationServiceClient();
            _translationClient.DisplayTranslationByLexiconCompleted += new EventHandler<DisplayTranslationByLexiconCompletedEventArgs>(DisplayTranslationByLexiconCompleted);
            _translationClient.DisplayTranslationByFirstLetterCompleted += new EventHandler<DisplayTranslationByFirstLetterCompletedEventArgs>(DisplayTranslationByFirstLetterCompleted);
            _translationClient.DisplayTranslationByLanguageCompleted += new EventHandler<DisplayTranslationByLanguageCompletedEventArgs>(DisplayTranslationByLanguageCompleted);

            this.PhraseCommand = new MvxRelayCommand<Translation>(this.GoPhrase_Execute, this.GoPhrase_CanExecute);

            this.ExecuteQueryByType(type, valueToQuery);
        }

        private void ExecuteQueryByType(string type, string valueToQuery)
        {
            switch (type)
            {
                case "ByFirstCharacter":
                    _translationClient.DisplayTranslationByFirstLetterAsync(valueToQuery, 1);
                    break;
                case "ByLexicon":
                    _translationClient.DisplayTranslationByLexiconAsync(valueToQuery, 1);
                    break;
                case "ByLanguage":
                    _translationClient.DisplayTranslationByLanguageAsync(1);
                    break;
                default:
                    _translationClient.DisplayTranslationByLanguageAsync(1);
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
