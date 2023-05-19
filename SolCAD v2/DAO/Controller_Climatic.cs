using SolCAD_v2.Models;
using System.Diagnostics;

namespace SolCAD_v2.DAO
{
    public class Controller_Climatic
    {
        public static AllSheets decline = new AllSheets()
        {
            aux = "declinacion",
            ENE = -0.34906585,
            FEB = -0.226892803,
            MAR = -0.041887902,
            ABR = 0.16406095,
            MAY = 0.314159265,
            JUN = 0.403171057,
            JUL = 0.370009801,
            AGO = 0.235619449,
            SEP = 0.038397244,
            OCT = -0.167551608,
            NOV = -0.329867229,
            DIC = -0.401425728

        };
        public static AllSheets conditioning = new AllSheets();
        public static double latRadianes = 0;
        public static double elevRadianes = 0;

        /// <summary>
        /// Carga la lista de datos.
        /// </summary>
        /// <param name="filename">Nombre del CSV que se cargara.</param>
        /// <param name="fixer">Variable encargada de validar el simbolo de los decimales.</param>
        /// <returns></returns>
        public static List<AllSheets> dataList(string filename, bool? fixer)
        {
            var tempList = new List<AllSheets>();
            var genericList = Csv_manager.Controller.GetData(filename, "SolCAD_v2.Models.AllSheets", Controller_Comuna.test,fixer);

            foreach (var g in genericList)
            {
                tempList.Add((AllSheets)g!);
            }
            return tempList;
        }
        /// <summary>
        /// Carga la lista de Radiacion.
        /// </summary>
        /// <param name="fixer">Variable encargada de validar el simbolo de los decimales.</param>
        /// <returns></returns>
        public static List<Radiation> RdataList(bool? fixer)
        {
            var radList = new List<Radiation>();
            var genericList = Csv_manager.Controller.GetData("Radiacion", "SolCAD_v2.Models.Radiation", Controller_Comuna.test,fixer);

            foreach (var g in genericList)
            {
                radList.Add((Radiation)g!);
            }
            return radList;
        }
        /// <summary>
        /// Calculos de temperatura segun datos cargados en CSV.
        /// </summary>
        /// <param name="LAT">La lattitud.</param>
        /// <param name="LON">La longitud.</param>
        /// <param name="INC">La inclinacion de los paneles.</param>
        /// <returns></returns>
        public static AllSheets Temp_Calculos(double LAT, double LON, List<AllSheets> data)
        {
            int x1 = (int)Math.Truncate(LAT - 1);
            int x2 = x1 + 1;
            int y1 = (int)Math.Truncate(LON - 1);
            int y2 = y1 + 1;

            var fq11 = (from t in data where t.aux == x1.ToString() + y1.ToString() select t).FirstOrDefault();
            var fq21 = (from t in data where t.aux == x2.ToString() + y1.ToString() select t).FirstOrDefault();
            var fq12 = (from t in data where t.aux == x1.ToString() + y2.ToString() select t).FirstOrDefault();
            var fq22 = (from t in data where t.aux == x2.ToString() + y2.ToString() select t).FirstOrDefault();

            #region Formulas

            var f1 = ((x2 - LAT) * (y2 - LON));
            var f2 = ((LAT - x1) * (y2 - LON));
            var f3 = ((x2 - LAT) * (LON - y1));
            var f4 = ((LAT - x1) * (LON - y1));

            var aux = 1 / ((x2 - x1) * (y2 - y1));

            #endregion Formulas

            List<AllSheets?> blackList = new List<AllSheets?>
            {
                blackHeader_table(fq11, f1),
                blackHeader_table(fq21, f2),
                blackHeader_table(fq12, f3),
                blackHeader_table(fq22, f4)
            };



            return valor_Interpolado(blackList, aux);
        }
        /// <summary>
        /// Calculos de radiacion H y I.
        /// </summary>
        /// <param name="LAT">La lattitud.</param>
        /// <param name="LON">La longitud.</param>
        /// <param name="inclination">La inclinacion de los paneles.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static Tuple<AllSheets, AllSheets> RadTemp_Calculos(double LAT, double LON, int inclination, List<Radiation> data)
        {
            #region Variables
            int x1 = (int)Math.Truncate(LAT - 1);
            int x2 = x1 + 1;
            int y1 = (int)Math.Truncate(LON - 1);
            int y2 = y1 + 1;
            latRadianes = LAT * (Math.PI / 180);
            elevRadianes = inclination * (Math.PI / 180);
            #endregion Variables

            conditioning = new AllSheets()
            {
                aux = "acondicionamiento",
                ENE = formula_Acondicionamiento(decline.ENE),
                FEB = formula_Acondicionamiento(decline.FEB),
                MAR = formula_Acondicionamiento(decline.MAR),
                ABR = formula_Acondicionamiento(decline.ABR),
                MAY = formula_Acondicionamiento(decline.MAY),
                JUN = formula_Acondicionamiento(decline.JUN),
                JUL = formula_Acondicionamiento(decline.JUL),
                AGO = formula_Acondicionamiento(decline.AGO),
                SEP = formula_Acondicionamiento(decline.SEP),
                OCT = formula_Acondicionamiento(decline.OCT),
                NOV = formula_Acondicionamiento(decline.NOV),
                DIC = formula_Acondicionamiento(decline.DIC)
            };

            var fq11 = (from t in data where t.aux == x1.ToString() + y1.ToString() select t).FirstOrDefault();
            var fq21 = (from t in data where t.aux == x2.ToString() + y1.ToString() select t).FirstOrDefault();
            var fq12 = (from t in data where t.aux == x1.ToString() + y2.ToString() select t).FirstOrDefault();
            var fq22 = (from t in data where t.aux == x2.ToString() + y2.ToString() select t).FirstOrDefault();

            #region Formulas

            var f1 = ((x2 - LAT) * (y2 - LON));
            var f2 = ((LAT - x1) * (y2 - LON));
            var f3 = ((x2 - LAT) * (LON - y1));
            var f4 = ((LAT - x1) * (LON - y1));

            var aux = 1 / ((x2 - x1) * (y2 - y1));

            #endregion Formulas

            List<AllSheets?> blackList = new List<AllSheets?>
            {
                blackHeader_table(fq11, f1),
                blackHeader_table(fq21, f2),
                blackHeader_table(fq12, f3),
                blackHeader_table(fq22, f4)
            };

            var valInter = valor_Interpolado(blackList, aux);
            var valIncl = valor_inclinado(valInter, conditioning);

            return Tuple.Create(valInter, valIncl);
        }
        /// <summary>
        /// Generacion de Lista para la ayuda del calculo de las temperaturas.
        /// </summary>
        /// <param name="fvar">Variable fq correspondiente a la asignacion según tabla en prototipo funcional.</param>
        /// <param name="f">Formula encargada del calculo.</param>
        /// <returns></returns>
        public static AllSheets blackHeader_table(AllSheets? fvar, double f)
        {

            AllSheets a = new AllSheets();
            a.aux = fvar.aux;
            a.ENE = Math.Round(fvar.ENE * f, 2);
            a.FEB = Math.Round(fvar.FEB * f, 2);
            a.MAR = Math.Round(fvar.MAR * f, 2);
            a.ABR = Math.Round(fvar.ABR * f, 2);
            a.MAY = Math.Round(fvar.MAY * f, 2);
            a.JUN = Math.Round(fvar.JUN * f, 2);
            a.JUL = Math.Round(fvar.JUL * f, 2);
            a.AGO = Math.Round(fvar.AGO * f, 2);
            a.SEP = Math.Round(fvar.SEP * f, 2);
            a.OCT = Math.Round(fvar.OCT * f, 2);
            a.NOV = Math.Round(fvar.NOV * f, 2);
            a.DIC = Math.Round(fvar.DIC * f, 2);

            return a;
        }
        /// <summary>
        /// Valor interpolado.
        /// </summary>
        /// <param name="list">Lista que se va a interpolar.</param>
        /// <param name="aux">Formula auxiliar para el calculo.</param>
        /// <returns></returns>
        public static AllSheets valor_Interpolado(List<AllSheets?> list, int aux)
        {
            AllSheets a = new AllSheets();
            a.aux = "interp";
            foreach (var l in list)
            {
                a.ENE += l.ENE;
                a.FEB += l.FEB;
                a.MAR += l.MAR;
                a.ABR += l.ABR;
                a.MAY += l.MAY;
                a.JUN += l.JUN;
                a.JUL += l.JUL;
                a.AGO += l.AGO;
                a.SEP += l.SEP;
                a.OCT += l.OCT;
                a.NOV += l.NOV;
                a.DIC += l.DIC;
            }

            #region Xaux
            a.ENE *= aux;
            a.FEB *= aux;
            a.MAR *= aux;
            a.ABR *= aux;
            a.MAY *= aux;
            a.JUN *= aux;
            a.JUL *= aux;
            a.AGO *= aux;
            a.SEP *= aux;
            a.OCT *= aux;
            a.NOV *= aux;
            a.DIC *= aux;
            #endregion Xaux

            a.ENE = Math.Round(a.ENE, 2);
            a.FEB = Math.Round(a.FEB, 2);
            a.MAR = Math.Round(a.MAR, 2);
            a.ABR = Math.Round(a.ABR, 2);
            a.MAY = Math.Round(a.MAY, 2);
            a.JUN = Math.Round(a.JUN, 2);
            a.JUL = Math.Round(a.JUL, 2);
            a.AGO = Math.Round(a.AGO, 2);
            a.SEP = Math.Round(a.SEP, 2);
            a.OCT = Math.Round(a.OCT, 2);
            a.NOV = Math.Round(a.NOV, 2);
            a.DIC = Math.Round(a.DIC, 2);
            return a;
        }
        /// <summary>
        /// Valor inclinado.
        /// </summary>
        /// <param name="conditioning">Fila acondicionada según formula de acondicionamiento.</param>
        /// <param name="valInter">Fila con los valores interpolados.</param>
        /// <returns></returns>
        public static AllSheets valor_inclinado(AllSheets conditioning, AllSheets valInter)
        {
            AllSheets a = new AllSheets()
            {
                aux = "inlc",
                ENE = Math.Round(valInter.ENE * conditioning.ENE, 2),
                FEB = Math.Round(valInter.FEB * conditioning.FEB, 2),
                MAR = Math.Round(valInter.MAR * conditioning.MAR, 2),
                ABR = Math.Round(valInter.ABR * conditioning.ABR, 2),
                MAY = Math.Round(valInter.MAY * conditioning.MAY, 2),
                JUN = Math.Round(valInter.JUN * conditioning.JUN, 2),
                JUL = Math.Round(valInter.JUL * conditioning.JUL, 2),
                AGO = Math.Round(valInter.AGO * conditioning.AGO, 2),
                SEP = Math.Round(valInter.SEP * conditioning.SEP, 2),
                OCT = Math.Round(valInter.OCT * conditioning.OCT, 2),
                NOV = Math.Round(valInter.NOV * conditioning.NOV, 2),
                DIC = Math.Round(valInter.DIC * conditioning.DIC, 2)
            };

            return a;
        }
        /// <summary>
        /// Formula de acondicionamiento.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <returns></returns>
        public static double formula_Acondicionamiento(double v)
        {
            return Math.Cos(Math.Abs(-latRadianes + v - elevRadianes)) / Math.Cos(Math.Abs(-latRadianes + v));
        }
        /// <summary>
        /// Carga de datos finales segun cordenadas en una lista semejante a la tabla del prototipo funcional.
        /// </summary>
        /// <param name="LAT">La lattitud.</param>
        /// <param name="LON">La longitud.</param>
        /// <param name="INC">La inclinacion de los paneles.</param>
        /// <returns>Retorna una lista</returns>
        public static List<AllSheets> finalTable(double LAT, double LON, int INC)
        {

            List<AllSheets> list = new List<AllSheets>();
            bool fixer = true;
            Again:
            try
            {
                var rad = RdataList(fixer);
                list.Add(Temp_Calculos(LAT, LON, dataList("Temp",fixer)));
                list.Add(Temp_Calculos(LAT, LON, dataList("D_sol",fixer)));
                list.Add(Temp_Calculos(LAT, LON, dataList("Tminima", fixer)));
                list.Add(RadTemp_Calculos(LAT, LON, INC, rad).Item1);
                list.Add(RadTemp_Calculos(LAT, LON, INC, rad).Item2);

            }catch(Exception ex) { Debug.WriteLine(ex.Message); fixer = false; goto Again; }
            
            return list;
        }
        /// <summary>
        /// Carga los valores complementarios según tabla informacion climatica para
        /// resumen estadistico.
        /// </summary>
        /// <param name="radBruto">La radiacion bruta.</param>
        /// <param name="respaldo">Variable de respaldo.</param>
        /// <param name="dSol">Objeto dias sin sol.</param>
        /// <returns></returns>
        public static double effTable(double radBruto, double? respaldo, AllSheets dSol)
        {
            var arrayHora = new double[10];
            var arrayHora2 = new double[10];
            var arrayAngulo = new double[10];
            var arrayEff = new double[10];

            var IRR = (radBruto / 2) / 9;
            var maxDsol = new[] {dSol.ENE, dSol.FEB, dSol.MAR, dSol.ABR,
                    dSol.MAY, dSol.JUN, dSol.JUL, dSol.AGO, dSol.SEP, dSol.OCT,
                    dSol.NOV, dSol.DIC}.Max();
            int newRespaldo = 0;
            double r = IRR * 3600;
            int hora = 3600 * 12;

            if (respaldo == null)
            {
                newRespaldo = (int)Math.Round(maxDsol * 24, 0);
            }
            
            arrayHora[0]=hora; arrayHora[1]=Math.Round(hora + r);
            arrayHora2[0] =0; arrayHora2[1] = (arrayHora[1] - arrayHora[0]) / 3600;
            arrayAngulo[0] = 0;
            arrayEff[0] = Math.Cos(arrayAngulo[0] * (Math.PI / 180));


            for (int i = 1; i < 10; i++)
            {
                if (i >= 2)
                {
                    arrayHora[i] = Math.Round((arrayHora[i - 1] + r));
                }
                arrayHora2[i] = arrayHora2[1] * i;
                arrayAngulo[i] = 15 * arrayHora2[i];
                arrayEff[i] = Math.Cos(arrayAngulo[i] * (Math.PI / 180));
            } 
            

            return arrayEff.Average();
        }
    }
}
