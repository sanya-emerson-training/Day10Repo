

using DIPRefactoredApp.HighLevelModules;
using DIPRefactoredApp.LowLevelModules;

var calc = new TaxCalculator(new XmlLogger());
Console.WriteLine(calc.CalculateTax(10, 0)); ;