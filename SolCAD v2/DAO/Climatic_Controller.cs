﻿using Microsoft.VisualBasic.Logging;
using SolCAD_v2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolCAD_v2.DAO
{
    public class Climatic_Controller
    {
        public static List<AllSheets> dataList(string filename)
        {
            var tempList = new List<AllSheets>();
            var genericList = Csv_manager.Controller.GetData(filename, "SolCAD_v2.Models.AllSheets");

            foreach ( var g in genericList)
            {
                tempList.Add((AllSheets)g!);
            }
            return tempList;
        }

        public static AllSheets Temp_Calculos(double LAT, double LON, string fileName)
        {
            int x1 = (int)Math.Truncate(LAT-1);
            int x2 = x1+1;
            int y1 = (int)Math.Truncate(LON-1);
            int y2 = y1+1;

            var data = dataList(fileName);

            var fq11 = (from t in data where t.aux == x1.ToString() + y1.ToString() select t).FirstOrDefault();
            var fq21 = (from t in data where t.aux == x2.ToString() + y1.ToString() select t).FirstOrDefault();
            var fq12 = (from t in data where t.aux == x1.ToString() + y2.ToString() select t).FirstOrDefault();
            var fq22 = (from t in data where t.aux == x2.ToString() + y2.ToString() select t).FirstOrDefault();

            #region Formulas

            var f1 = ((x2 - LAT) * (y2 - LON));
            var f2 = ((LAT - x1) * (y2 - LON));
            var f3 = ((x2 - LAT) * (LON - y1));
            var f4 = ((LAT - x1) * (LON - y1));

            var aux = 1/((x2 - x1) * (y2 - y1));

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

        public static AllSheets blackHeader_table(AllSheets? fvar, double f)
        {
            
            AllSheets a = new AllSheets();
            a.aux = fvar.aux;
            a.ENE = Math.Round(fvar.ENE * f,2);
            a.FEB = Math.Round(fvar.FEB * f,2);
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

        public static AllSheets valor_Interpolado(List<AllSheets?> list, int aux)
        {
            AllSheets a = new AllSheets();
            a.aux = "interp";
            foreach(var l in list)
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

            a.ENE = Math.Round(a.ENE,2);
            a.FEB = Math.Round(a.FEB,2);
            a.MAR = Math.Round(a.MAR,2);
            a.ABR = Math.Round(a.ABR,2);
            a.MAY = Math.Round(a.MAY,2);
            a.JUN = Math.Round(a.JUN,2);
            a.JUL = Math.Round(a.JUL,2);
            a.AGO = Math.Round(a.AGO,2);
            a.SEP = Math.Round(a.SEP,2);
            a.OCT = Math.Round(a.OCT,2);
            a.NOV = Math.Round(a.NOV,2);
            a.DIC = Math.Round(a.DIC,2);
            return a;
        }
    }
}
