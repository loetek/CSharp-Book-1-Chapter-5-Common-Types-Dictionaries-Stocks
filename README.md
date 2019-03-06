# CSharp-Book-1-Chapter-5-Common-Types-Dictionaries-Stocks
Exercise to learn about common c # data types. Dictionaries.

Practice: Stock Purchase Dictionaries
Setup
mkdir -p ~/workspace/csharp/exercises/dictionaries && cd $_
dotnet new console
References
C# dictionaries
Dictionary in C#
Interactive C# Dictionaries
Instructions
A block of publicly traded stock has a variety of attributes, we'll look at a few of them. A stock has a ticker symbol and a company name. Create a simple dictionary with ticker symbols and company names in the Main method.

Example
Dictionary<string, string> stocks = new Dictionary<string, string>();
stocks.Add("GM", "General Motors");
stocks.Add("CAT", "Caterpillar");
// Add a few more of your favorite stocks
To find a value in a Dictionary, you can use square bracket notation much like JavaScript object key lookups.

string GM = stocks["GM"];   <--- "General Motors"
Next, create a list to hold stock purchases by an investor. The list will contain dictionaries.

List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
Then add some purchases.

Example
purchases.Add (new Dictionary<string, double>(){ {"GE", 230.21} });
purchases.Add (new Dictionary<string, double>(){ {"GE", 580.98} });
purchases.Add (new Dictionary<string, double>(){ {"GE", 406.34} });

// Add more purchases for each stock
Create a total ownership report that computes the total value of each stock that you have purchased. This is the basic relational database join algorithm between two tables.

Helpful Links: ContainsKey, Add

/*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the total valuation of each stock


    From the three purchases above, one of the entries
    in this new dictionary will be...
        {"General Electric", 1217.53}

    Replace the questions marks below with the correct types.
*/
Dictionary<?, ?> stockReport = new Dictionary<?, ?>();

/*
   Iterate over the purchases and record the valuation
   for each stock.
*/
foreach (Dictionary<string, double> purchase in purchases)
{
    foreach (KeyValuePair<string, double> stock in purchase)
    {
        // Does the full company name key already exist in the `stockReport`?

        // If it does, update the total valuation

        /*
            If not, add the new key and set its value.
            You have the value of "GE", so how can you look
            the value of "GE" in the `stocks` dictionary
            to get the value of "General Electric"?
        */
    }
}
Now that the report dictionary is populated, display the final results.

foreach(KeyValuePair<?, ?> item in stockReport)
{
    Console.WriteLine($"The position in {display the key} is worth {display the value}");
}
