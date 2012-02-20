using System.Windows.Media;

namespace FontListPicker
{
    public class FontBinding
    {
        /// <summary>
        /// Creates a FontBinding
        /// </summary>
        /// <param name="family">The font family name or full location if embedded</param>
        /// <param name="name">A friendly name</param>
        public FontBinding(string family, string name)
        {
            Family = new FontFamily(family);
            Name = name;
        }

        /// <summary>
        /// Creates a FontBinding
        /// </summary>
        /// <param name="family">The font family</param>
        /// <param name="name">A friendly name</param>
        public FontBinding(FontFamily family, string name)
        {
            Family = family;
            Name = name;
        }

        /// <summary>
        /// Creates a FontBinding, the name is taken from the font family name
        /// and trimmed if the name includes a location
        /// </summary>
        /// <param name="family">The font family name or full location if embedded</param>
        public FontBinding(string family)
        {
            Family = new FontFamily(family);
            Name = TrimFontName(family);
        }

        /// <summary>
        /// Creates a FontBinding, the name is taken from the font family name
        /// and trimmed if the name includes a location
        /// </summary>
        /// <param name="family">The font family</param>
        public FontBinding(FontFamily family)
        {
            Family = family;
            Name = TrimFontName(Family.ToString());
        }

        public FontBinding()
        {
        }

        public string Name { get; set; }
        public FontFamily Family { get; set; }
        
        /// <summary>
        /// If a font has been embedded this method chops off all
        /// of the boring location details to leave just the font name
        /// </summary>
        public string TrimFontName(string name)
        {
            return name.LastIndexOf('#') > 0 ? name.Substring(name.LastIndexOf('#') + 1) : name;
        }
    }
}