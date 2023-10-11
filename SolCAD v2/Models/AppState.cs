using System.Data;
using System.Runtime.Serialization.Formatters.Binary;

namespace SolCAD_v2.Models;

[Serializable]
public class AppState
{
    public List<AllSheets> InformacionClimatica { get; set; }
    public GridData GridData { get; set; }
    public Condicion C { get; set; }
    public bool Ahorro { get; set; }
    public bool Help { get; set; }
    public double ConsumoPromedio { get; set; }
    public double PerdidasConversion { get; set; }
    public string PorcentajePerdidas { get; set; }
    public double TotalCorregido { get; set; }
    public Bateria Bateria { get; set; }
    public Panel Panel { get; set; }
    public double Descarga { get; set; }
    public double RadPropose { get; set; }
    public double DesviationLost { get; set; }
    public int INC { get; set; }
    public string inclinacion { get; set; }
    public int ComunaSelectedIndex { get; set; }
    public int RegionSelectedIndex { get; set; }
    public double LAT { get; set; }
    public double LON { get; set; }
    public int PanelSelectedIndex { get; set; }
    public int DescargaMaxSelectedIndex { get; set; }
    public int BateriasSelectedIndex { get; set; }

    public string TxtEne { get; set; }
    public string TxtFeb { get; set; }
    public string TxtMar { get; set; }
    public string TxtAbr { get; set; }
    public string TxtMay { get; set; }
    public string TxtJun { get; set; }
    public string TxtJul { get; set; }
    public string TxtAgo { get; set; }
    public string TxtSep { get; set; }
    public string TxtOct { get; set; }
    public string TxtNov { get; set; }
    public string TxtDic { get; set; }
    public string TxtKwh { get; set; }
}