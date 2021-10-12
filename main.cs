using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    // Arrays

    double[] celsius = new double[7];
    double[] farhrenheit = new double[7];
    double sum=0;
    
    

    for(int pos=0; pos < celsius.Length; pos++)
    {
      Console.WriteLine("Enter temperature in celsius");
      celsius[pos]=Convert.ToDouble(Console.ReadLine());
      farhrenheit[pos] = celsius[pos] * 9/5 + 32;
      sum+=farhrenheit[pos];

    }

    Console.WriteLine("Enter temperature in farhrenheit");
    Array.Reverse(farhrenheit);
    foreach(double item in farhrenheit)
    {
     
      Console.WriteLine(item);
    }

    
    double avg = sum/7;
    Console.WriteLine("Average weekly temperature is " + avg + " degrees farhrenheit ");

    
    


    
      
      

    
  }
}