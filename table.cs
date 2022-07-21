using System;
using System.Data;
using System.Data.OleDb;

class Table
{
    public void ADONET_dynTabelle1()
    {

    DataTable Table = new DataTable();
    //Spalten erzeugen
    Table.Columns.Add("year", System.Type.GetType(System.Int32));
    Table.Columns.Add("students", System.Type.GetType(System.Int32));
    Table.Columns.Add("teacher", System.Type.GetType(System.Int32));
    Table.Columns.Add("needed teacher", System.Type.GetType(System.Int32));
    Table.Columns.Add("schools", System.Type.GetType(System.Int32));
    Table.Columns.Add("needed schools", System.Type.GetType(System.Int32));

    //1. Zeile erzeugen
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"];
    row ["students"];
    row ["teacher"];
    row ["needed teacher"];
    row ["schools"];
    row ["needed schools"];
    //Anfügen an Tabelle
    Table.Row.Add(row);
    //weitere sind identisch
        //2.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +10;
    row ["students"];
    row ["teacher"];
    row ["needed teacher"];
    row ["schools"];
    row ["needed schools"];
    //Anfügen an Tabelle
    Table.Row.Add(row);
        //3.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +15;
    row ["students"];
    row ["teacher"];
    row ["needed teacher"];
    row ["schools"];
    row ["needed schools"];
    //Anfügen an Tabelle
    Table.Row.Add(row);
        //4.Zeile
    DataRow row = Table.NewRow();
    //Wert fehlt
    row ["year"] = +20;
    row ["students"];
    row ["teacher"];
    row ["needed teacher"];
    row ["schools"];
    row ["needed schools"];
    //Anfügen an Tabelle
    Table.Row.Add(row);
    }
}
