using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Diagnostics;
using System.Globalization;

namespace SolCAD_v2.Csv_manager
{
    public class Controller
    {
        public static List<object?> GetData(string fileName, string c)
        {
            string route = "../Files/" + fileName+".csv";
            var type = Type.GetType(c);
            CsvReader csv = null;
            CultureInfo culture = new CultureInfo("es-CL");

            var cfg = new CsvConfiguration(culture)
            {
                Delimiter = ";"
            };

            try {
                var reader = new StreamReader(route);
                csv = new CsvReader(reader, cfg);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); return null; }
            
            var data = csv!.GetRecords(type).ToList();

            return data;
        }
    }
}
