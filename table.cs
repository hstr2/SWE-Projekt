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
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +5;
    row ["students"] = calc.students5;
    row ["teacher"] = calc.teachers5;
    row ["needed teacher"] = calc.teachersneeded5;
    row ["schools"] = calc.schools;
    row ["needed schools"] = calc.schoolsneeded5;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    //weitere sind identisch
    //2.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +10;
    row ["students"] = calc.students10;
    row ["teacher"] = calc.teachers10;
    row ["needed teacher"] = calc.teachersneeded10;
    row ["schools"] = calc.schools;
    row ["needed schools"] = calc.schoolsneeded10;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    //3.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +15;
    row ["students"] = calc.students15;
    row ["teacher"] = calc.teachers15;
    row ["needed teacher"] = calc.teachersneeded15;
    row ["schools"] = calc.schools;
    row ["needed schools"] = calc.schoolsneeded15;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    //4.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +20;
    row ["students"] = calc.students20;
    row ["teacher"] = calc.teachers20;
    row ["needed teacher"] = calc.teachersneeded20;
    row ["schools"] = calc.schools;
    row ["needed schools"] = calc.schoolsneeded20;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    }
}
