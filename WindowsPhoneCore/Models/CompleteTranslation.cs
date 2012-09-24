using Core.TranslationReference;
using Core.LanguageReference;

namespace Core.Models
{
    public class CompleteTranslation
    {
        public Translation Translation { get; set; }
        public Language Language { get; set; }
    }
}
