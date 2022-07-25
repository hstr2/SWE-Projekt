using System;
using System.Data;
using System.Data.OleDb;

class Table
{
    public void ADONET_dynTabelle1(Calculation calc)
    {
        
    DataTable Table = new DataTable();
    //Spalten erzeugen
    Table.Columns.Add("year", System.Type.GetType("System.Int32"));
    Table.Columns.Add("students", System.Type.GetType("System.Int32"));
    Table.Columns.Add("teacher", System.Type.GetType("System.Int32"));
    Table.Columns.Add("needed teacher", System.Type.GetType("System.Int32"));
    Table.Columns.Add("schools", System.Type.GetType("System.Int32"));
    Table.Columns.Add("needed schools", System.Type.GetType("System.Int32"));

    //1. Zeile erzeugen
    DataRow row1 = Table.NewRow();
    //Wert fehlt
    row1 ["year"] = +5;
    row1 ["students"] = calc.students5;
    row1 ["teacher"] = calc.teachers5;
    row1 ["needed teacher"] = calc.teachersneeded5;
    row1 ["schools"] = calc.schools;
    row1 ["needed schools"] = calc.schoolsneeded5;
    //Anfügen an Tabelle
    Table.Rows.Add(row1);
    //weitere sind identisch
    //2.Zeile
    DataRow row2 = Table.NewRow();
    //Wert fehlt
    row2 ["year"] = +10;
    row2 ["students"] = calc.students10;
    row2 ["teacher"] = calc.teachers10;
    row2 ["needed teacher"] = calc.teachersneeded10;
    row2 ["schools"] = calc.schools;
    row2 ["needed schools"] = calc.schoolsneeded10;
    //Anfügen an Tabelle
    Table.Rows.Add(row2);
    //3.Zeile
    DataRow row3 = Table.NewRow();
    //Wert fehlt
    row3 ["year"] = +15;
    row3 ["students"] = calc.students15;
    row3 ["teacher"] = calc.teachers15;
    row3 ["needed teacher"] = calc.teachersneeded15;
    row3 ["schools"] = calc.schools;
    row3 ["needed schools"] = calc.schoolsneeded15;
    //Anfügen an Tabelle
    Table.Rows.Add(row3);
    //4.Zeile
    DataRow row4 = Table.NewRow();
    //Wert fehlt
    row4 ["year"] = +20;
    row4 ["students"] = calc.students20;
    row4 ["teacher"] = calc.teachers20;
    row4 ["needed teacher"] = calc.teachersneeded20;
    row4 ["schools"] = calc.schools;
    row4 ["needed schools"] = calc.schoolsneeded20;
    //Anfügen an Tabelle
    Table.Rows.Add(row4);
    }
}
