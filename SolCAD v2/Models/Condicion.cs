namespace SolCAD_v2.Models;

public class Condicion
{
    public int Voltaje { get; set; }
    public int RespaldoArbitrario { get; set; }
    public int Paneles { get; set; }
    public int Ramas { get; set; }
    public double AlturaInferior { get; set; }
    public double EnergiaDiariaRequerida { get; set; }
    public int TotalPaneles => Paneles * Ramas;
    public int TotalPanelesArbitrario { get; set; }
    public int TotalBateriasArbitrario { get; set; }
    public int UnionesSerie => (Paneles - 1) * Ramas;
    public int UnionesParalelas => 2 * Ramas - 1;
    public double BateriasSerie => Voltaje / 12;
    public double NroRamas { get; set; }
    public double TotalBaterias => Math.Ceiling(NroRamas) * BateriasSerie;
    public double UnionesSerie2 => TotalBaterias / 2;
    public double UnionesParalelas2 => 2 * TotalBaterias - 1;
    public double PesoBanco { get; set; }
    public double VolumenBanco { get; set; }
    public double PesoArreglo { get; set; }
    public double AreaArreglo { get; set; }
    public double SombraPoryectada { get; set; }
    public double PotenciaTotalBruta { get; set; }
    public double PotenciaTotalCorregida { get; set; }
    public double EnergiaDiaria { get; set; }
    public int CapacidadBateria { get; set; }
    public double CapacidadCorregida => CapacidadBateria * 0.86;
    public double EnergiaRama => Voltaje * CapacidadCorregida;
}