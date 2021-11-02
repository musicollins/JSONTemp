using System.IO;

namespace JSON.DataSource
{
    public class JSONDataSource
    {
        public string MoviesDataProvider()
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\rafae\source\repos\JSON\JSON.DataSource\movies.json");

            return jsonRepsonse;
        }
        public string MovieDataProvider()
        {
            var jsonRepsonse = File.ReadAllText(@"C:\Users\rafae\source\repos\JSON\JSON.DataSource\movie.json");

            return jsonRepsonse;
        }

    }
}
