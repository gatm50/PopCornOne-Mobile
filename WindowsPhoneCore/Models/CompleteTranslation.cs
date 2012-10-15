using Core.TranslationReference;
using Core.LanguageReference;
using System.ComponentModel;

namespace Core.Models
{
    public class CompleteTranslation
    {
        private Translation _translation;
        private Language _language;
        public Translation Translation { get { return _translation; } set { _translation = value; } }
        public Language Language { get { return _language; } set { _language = value;} }

        public CompleteTranslation(Translation translation, Language language)
        {
            this.Translation = translation;
            this.Language = language;
        }
    }
}
