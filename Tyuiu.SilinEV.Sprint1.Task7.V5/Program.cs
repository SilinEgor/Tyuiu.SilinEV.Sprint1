using Tyuiu.SilinEV.Sprint1.Task7.V5.Lib;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("      ln(|cos(x)|)");
Console.WriteLine("z = ----------------");
Console.WriteLine("               2");
Console.WriteLine("       ln(1 + x)");

Console.WriteLine("Введите значение X:");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(x));
Console.ReadKey();