using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Server;

public class Car
{
    public int Id { get; set; }
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    public Car(int id, string? marka, string? model, int year)
    {
        Id = id;
        Marka = marka;
        Model = model;
        Year = year;
    }

    public Car()
    {
    }

    public override string ToString() => $"{Id}" +
        $"{Marka}" +
        $" {Model}" +
        $" {Year}";
}

public class Command
{
    public string? HttpMethod { get; set; }
    public Car? Value { get; set; }
}
