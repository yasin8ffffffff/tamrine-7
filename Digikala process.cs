
using Digikala1.Model;


internal class Digikala_process
{
    List<Digikala> digikalas;
    public Digikala_process(List<Digikala> digikalas)
    {
        this.digikalas = digikalas;
    }
    public List<Digikala> SearchByUser(int ID_Customer)
    {
        return digikalas
             .Where(x => x.ID_Customer == ID_Customer)
             .ToList();
    }
    public List<int> AllSalesByYear(int year)
    {
        return digikalas.
         Where(x => x.DateTime_CartFinalize.Year == year)
         .Select(x => x.Amount_Gross_Order)
         .ToList();
    }
    public long SumSalesByYear(int year)
    {
        List<int> sales = AllSalesByYear(year);
        long total = 0;

        foreach (int sale in sales)
        {
            total += sale;
        }

        return total;
    }
    public List<int> AllSalesbByItem(int item)
    {
        return digikalas.
     Where(x => x.ID_Item == item)
     .Select(x => x.Amount_Gross_Order)
     .ToList();
    }
    public long SumSalesByItem(int item)
    {
        List<int> sales = AllSalesbByItem(item);
        long total = 0;
        foreach (int sale in sales)
        {
            total += sale;
        }
        return total;
    }
    public List<int> AllSalesByMonth(int month)
    {
        return digikalas.
              Where(x => x.DateTime_CartFinalize.Month == month)
              .Select(x => x.Amount_Gross_Order).ToList();
    }
    public long SumSalesByMonth(int Month)
    {
        List<int> sales = AllSalesByMonth(Month);
        long total = 0;
        foreach (int sale in sales)
        {
            total += sale;
        }
        return total;
    }
}
 
