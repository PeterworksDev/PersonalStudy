
namespace MyStudy;

public class Program {
    
    static Chapter1 chapter1 = new Chapter1();
    static Chapter2 chapter2 = new Chapter2();
    static DotnetWithPackage dotnetWithPackage = new DotnetWithPackage();

    public static void Main(string[] args)
    {

        //chapter1.ShowMessage();
        //chapter2.ShowMessage();

        Console.WriteLine("Humanize Quantities:");
        dotnetWithPackage.HumanizeQuantities();

        Console.WriteLine("Humanize Dates:");
        dotnetWithPackage.HumanizeDates();

    }
}


