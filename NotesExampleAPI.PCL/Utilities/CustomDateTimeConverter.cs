using Newtonsoft.Json.Converters;

namespace NotesExampleAPI.PCL.Utilities
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter(string format)
        {
            DateTimeFormat = format;
        }
    }
}