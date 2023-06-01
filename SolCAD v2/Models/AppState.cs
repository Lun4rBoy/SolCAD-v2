using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace SolCAD_v2.Models;

[Serializable]
public class AppState
{
    public DataTable ListaEquipos { get; set; }
    //las variables a rescatar

    /* Ejemplo de Constructor
     * public AppState()
    {
        DataGrid1Data = new DataTable();
        DataGrid2Data = new DataTable();
        TextBoxText = string.Empty;
        CheckBoxChecked = false;
        ComboBoxSelectedValue = null;
    }
     */
}