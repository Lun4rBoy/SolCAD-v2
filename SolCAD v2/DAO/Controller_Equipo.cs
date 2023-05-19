using SolCAD_v2.Models;
using System.Diagnostics;
using Panel = SolCAD_v2.Models.Panel;

namespace SolCAD_v2.DAO;

public class Controller_Equipo
{
    public static List<Bateria> ListaBaterias()
    {
        var list = new List<Bateria>();
        bool fixer = true;
        Again:
        try
        {
            var genericList = Csv_manager.Controller.GetData("Baterias", "SolCAD_v2.Models.Bateria", Controller_Comuna.test, fixer);
            foreach (var g in genericList)
            {
                list.Add((Bateria)g!);
            }
        }
        catch(Exception ex) { Debug.WriteLine(ex.Message); fixer = false; goto Again; }
        return list;
    }

    public static List<Panel> ListaPaneles()
    {
        var list = new List<Panel>();
        bool fixer = true;
        Again:
        try
        {
            var genericList = Csv_manager.Controller.GetData("Paneles", "SolCAD_v2.Models.Panel", Controller_Comuna.test, fixer);
            foreach (var g in genericList)
            {
                list.Add((Panel)g!);
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); fixer = false; goto Again; }
        return list;
    }

    public static List<Inversor> ListaInversores()
    {
        var list = new List<Inversor>();
        bool fixer = true;
        Again:
        try
        {
            var genericList = Csv_manager.Controller.GetData("Inversores", "SolCAD_v2.Models.Inversor", Controller_Comuna.test, fixer);
            foreach (var g in genericList)
            {
                list.Add((Inversor)g!);
            }
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); fixer = false; goto Again; }
        return list;
    }
}