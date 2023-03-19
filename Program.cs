//////////////////یاسین منعم///////////
Using Digikala1;
using Digikala1.Model;
using Digikala1.process;
using System.Text.RegularExpressions;

string address = @"D:\orders.csv";

Console.WriteLine("Hello in here we give you information about digikala orders ");
      
Digikala_information information = new Digikala_information(address);
 Digikala_process pr = new Digikala_process(information.digikalas);
LockKeyboard lk = new LockKeyboard();

List<string> citys = new List<string>();
using(StreamReader srreader = new StreamReader(address))
{
    string line;
    while (!srreader.EndOfStream)
    {
      line = srreader.ReadLine();
        citys.Add(Regex.Replace(line, @"(\d|\.|,|:|-| )+", ""));
    }
}
var nonduplicatecitys = citys.Distinct();
foreach (string city in nonduplicatecitys)
{
    using (StreamWriter strwriter = new StreamWriter(@"D:\" + city + ".csv"))
    {
        strwriter.WriteLine(citys);
    }
}

