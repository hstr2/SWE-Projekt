using System;
using System.Collections.Generic;

class Programm
{

    static void Main(string[] args)
    {
        //DataCoordinator Test = new DataCoordinator(5);
        //string filename = "bev-data.csv";
        //Test.ReadDataHuman(filename);
//



         
        Variables var = new Variables();
        var.NameVariables("variables.txt");

        //Console.WriteLine($"vars: {var.MaxAge}, {var.MinAge}, {var.rangeAgeGroups}");

        DataCoordinator human = new DataCoordinator(var.MinAge, var.MaxAge, var.rangeAgeGroups);
        human.DataToHumanClass("bev-data.csv");

        foreach (var group in human.AgeGroups)
        Console.WriteLine(group.ToString());


    }
}