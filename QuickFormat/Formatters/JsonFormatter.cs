using Newtonsoft.Json;

namespace QuickFormat.Formatters
{
    public class JsonFormatter : IJunkFormatter
    {
        public string FormatName => "JSON";

        public bool TryFormatJunk(string junk, out string result)
        {
            try
            {
                var obj = JsonConvert.DeserializeObject(junk);
                var json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                result = json;
                return true;
            }
            catch
            {
                result = null;
                return false;
            }
        }
    }
}