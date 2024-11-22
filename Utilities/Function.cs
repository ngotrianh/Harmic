using SlugGenerator;

namespace Harmic.Utilities
{
    public class Function
    {
        public static string TitleslugGenerationAlias(string title)
        {
            return SlugGenerator.SlugGenerator.GenerateSlug(title);
        }
    }
}
