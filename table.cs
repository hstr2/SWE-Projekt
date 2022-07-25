using System;
using System.Data;
using System.Data.OleDb;

class Table
{
    public void ADONET_dynTabelle1()
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
    row ["students"] = students5;
    row ["teacher"] = teachers5;
    row ["needed teacher"] = teachersneeded5;
    row ["schools"] = schools;
    row ["needed schools"] = schoolsneeded5;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    //weitere sind identisch
    //2.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +10;
    row ["students"] = students10;
    row ["teacher"] = teachers10;
    row ["needed teacher"] = teachersneeded10;
    row ["schools"] = schools;
    row ["needed schools"] = schoolsneeded10;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    //3.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +15;
    row ["students"] = students15;
    row ["teacher"] = teachers15;
    row ["needed teacher"] = teachersneeded15;
    row ["schools"] = schools;
    row ["needed schools"] = schoolsneeded15;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    //4.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +20;
    row ["students"] = students20;
    row ["teacher"] = teachers20;
    row ["needed teacher"] = teachersneeded20;
    row ["schools"] = schools;
    row ["needed schools"] = schoolsneeded20;
    //Anfügen an Tabelle
    Table.Rows.Add(row);
    }
}
