using System.Text.Json;

namespace MKnet.Landing.Strategy.Domain.Services
{
    public static class JsonHelper
    {
        public static async Task<List<T>> LoadList<T>(string filename)
        {
            try
            {
                string fileName = $"Data/{filename}.json";
                using FileStream openStream = File.OpenRead(fileName);
                List<T>? result = await JsonSerializer.DeserializeAsync<List<T>>(openStream);

                return result is null ? new List<T>() : result;
            }
            catch (Exception)
            {
                return new List<T>();
            }
        }

        public static async Task<T?> Load<T>(string filename)
        {
            try
            {
                string fileName = $"Data/{filename}.json";
                using FileStream openStream = File.OpenRead(fileName);
                T? result = await JsonSerializer.DeserializeAsync<T>(openStream);

                return result;
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
