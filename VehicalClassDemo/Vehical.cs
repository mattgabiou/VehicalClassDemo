using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicalClassDemo
{
     public class Vehical
     {
          // Field 
          private string _make, _model, _year, _price;

          // Constructor that takes no arguments. 
          public Vehical()
          {
               _make = "unknown";
               _model = "unknown";
               _year = "unknown";
               _price = "unknown";
          }

          // Constructor that takes one argument. 
          public Vehical(string mod)
          {
               _model = mod;
          }

          // Properties
          //Longhand
          public string Make
          {
               get { return _make; }
               set { _make = value; }
          }
          // Shorthand Properties
          public string Model { get; set; }
          public string Year { get; set; }
          public string Price { get; set; } 

     }// end Class

     
     public class VehicalVan : Vehical
     {
          // Field
          private int _passengers;

          public VehicalVan()
          {
               Console.WriteLine("Child Constructor.");
               _passengers = 8;
          }

          public VehicalVan(int people)
          {
               Console.WriteLine("Explicit Constructor.");
               _passengers = people;  
          }

          // Properties
          public int Passengers { get; set; }

     }// end SuvVehical
     


}
