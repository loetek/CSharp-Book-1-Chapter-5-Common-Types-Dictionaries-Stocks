using System;
using System.Collections.Generic;

namespace dicitionaries
{
    class Program
    {


        static void PrintDictionary(Dictionary<string, string> dict){
            foreach(KeyValuePair<string, string> kvp in dict){
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
        static void PrintReport(Dictionary<string, double> dict){
            foreach(KeyValuePair<string, double> kvp in dict){
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GE", "General Electric");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("GOOG", "Google");
            stocks.Add("APPL", "Apple");
            stocks.Add("MICRO", "Microsoft");

            PrintDictionary(stocks);


            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();

            purchases.Add (new Dictionary<string, double>(){ {"GE", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GE", 406.34} });

            purchases.Add (new Dictionary<string, double>(){ {"CAT", 300.21} });
            purchases.Add (new Dictionary<string, double>(){ {"CAT", 345.98} });
            purchases.Add (new Dictionary<string, double>(){ {"CAT", 455.34} });

            purchases.Add (new Dictionary<string, double>(){ {"GOOG", 1000.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GOOG", 999.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GOOG", 1002.34} });

            purchases.Add (new Dictionary<string, double>(){ {"APPL", 983} });
            purchases.Add (new Dictionary<string, double>(){ {"APPL", 999.98} });
            purchases.Add (new Dictionary<string, double>(){ {"APPL", 1001.34} });

            purchases.Add (new Dictionary<string, double>(){ {"MICRO", 457.21} });
            purchases.Add (new Dictionary<string, double>(){ {"MICRO", 888.98} });
            purchases.Add (new Dictionary<string, double>(){ {"MICRO", 789.34} });



            purchases.ForEach (purchase => {
            PrintReport(purchase);
            });

        //PrintReport(purchases);
    /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the total valuation of each stock

    From the three purchases above, one of the entries
    in this new dictionary will be...
        {"General Electric", 1217.53}

    Replace the questions marks below with the correct types.
    */
Dictionary<string, double> stockReport = new Dictionary<string, double>();

    /*
   Iterate over the purchases and record the valuation
   for each stock.
    */
foreach (Dictionary<string, double> purchase in purchases) {
{
    foreach (KeyValuePair<string, double> stock in purchase)
    {
        // Does the full company name key already exist in the `stockReport`?
        Console.WriteLine(stock.Value);
        Console.WriteLine(stock.Key);

    foreach (KeyValuePair<string, string> ock in stocks){

       if(ock.Key == stock.Key){

        //!!If statement to check if it exists. How do I tell it to add all value items with the same key together?
        if(stockReport.ContainsKey(ock.Value)){

            stockReport[ock.Value]+=stock.Value;

        }else{

            stockReport.Add(ock.Value, stock.Value);

        }
       }
        // If it does, update the total valuation

        /*
            If not, add the new key and set its value.
            You have the value of "GE", so how can you look
            the value of "GE" in the `stocks` dictionary
            to get the value of "General Electric"?
        */
    }
    }
}


PrintReport(stockReport);


            }
        }
    }
}