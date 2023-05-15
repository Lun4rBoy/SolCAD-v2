using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using System.Diagnostics;
using System.Globalization;

namespace SolCAD_v2.Csv_manager
{
    public class Controller
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="fileName">Nombre del archivo CSV que se utilizara.</param>
        /// <param name="modelo">El modelo que se utilizara para la creacion de los objetos de la lista.</param>
        /// <param name="info">if set to <c>true</c> [Culture info cambiara a es-CL y el separador decimal sera un punto].</param>
        /// <param name="fixer">Si es falso el separador de los decimales sera una coma.</param>
        /// <returns></returns>
        public static List<object?> GetData(string fileName, string modelo, bool info,bool? fixer)
        {
            string route = "../Files/" + fileName+".csv";
            var type = Type.GetType(modelo);
            CsvReader csv = null;

            CultureInfo culture = CultureInfo.CurrentCulture;
            if (info == true)
            {
                culture = new CultureInfo("es-CL");
                string separator = ".";
                if (fixer == false)
                {
                    separator = ",";
                }
                culture.NumberFormat.NumberDecimalSeparator = separator;
            }

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
