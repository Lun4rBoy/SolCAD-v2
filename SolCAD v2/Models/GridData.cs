namespace SolCAD_v2.Models;

[Serializable]
public class GridData
{
    public List<List<object>> Rows { get; set; }
    public List<string> Headers { get; set; }
}