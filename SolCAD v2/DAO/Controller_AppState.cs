using SolCAD_v2.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace SolCAD_v2.DAO;

public class Controller_AppState
{
    public static AppState DeserializeAppState(string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return (AppState)binaryFormatter.Deserialize(fileStream);
        }
    }
    public static void SerializeAppState(AppState state, string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, state);
        }
    }
}