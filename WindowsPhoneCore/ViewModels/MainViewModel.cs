﻿using System;
using System.Collections.ObjectModel;
using Cirrious.MvvmCross.Commands;
using Cirrious.MvvmCross.Interfaces.Commands;
using Cirrious.MvvmCross.ViewModels;
using Core.TranslationReference;

namespace Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public IMvxCommand SearchCommand
        {
            get
            {
                return new MvxRelayCommand(() => RequestNavigate<ResultViewModel>(new { valueToQuery = this.SearchTerm, type = "ByLanguage" }));
            }
        }

        public string SearchTerm { get; set; }
        public ObservableCollection<string> AllLexicals { get; set; }
        private TranslationServiceClient _translationClient;

        public MainViewModel()
        {
            this.CharacterCommand = new MvxRelayCommand<string>(this.GoCharacter_Execute, GoCharacter_CanExecute);
            this.LexicalCommand = new MvxRelayCommand<string>(this.GoLexical_Execute, this.GoLexical_CanExecute);
            this.AllLexicals = new ObservableCollection<string>();

            _translationClient = new TranslationServiceClient();
            _translationClient.DisplayAllLexicalByLanguageCompleted += new EventHandler<DisplayAllLexicalByLanguageCompletedEventArgs>(DisplayAllLexicalByLanguageCompleted);
            _translationClient.DisplayAllLexicalByLanguageAsync(1);
        }

        void DisplayAllLexicalByLanguageCompleted(object sender, DisplayAllLexicalByLanguageCompletedEventArgs e)
        {
            this.AllLexicals.Clear();
            foreach (var item in e.Result)
                this.AllLexicals.Add(item);
        }

        #region Character Command
        public IMvxCommand CharacterCommand { get; set; }
        void GoCharacter_Execute(object parameters)
        {
            RequestNavigate<ResultViewModel>(new { valueToQuery = (parameters as string), type = "ByFirstCharacter" });
        }

        bool GoCharacter_CanExecute(object parameters)
        {
            return true;
        }
        #endregion

        #region Lexical Command
        public IMvxCommand LexicalCommand { get; set; }
        void GoLexical_Execute(object parameters)
        {
            RequestNavigate<ResultViewModel>(new { valueToQuery = (parameters as string), type = "ByLexicon" });
        }

        bool GoLexical_CanExecute(object parameters)
        {
            return true;
        }
        #endregion
    }
}
