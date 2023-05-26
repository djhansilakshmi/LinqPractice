// See https://aka.ms/new-console-template for more information
using LinqBasics;
// Call for LINQBasics 
LinqBasic linqBasics = new LinqBasic();
linqBasics.getLinq();
linqBasics.FindEvenNumbers();
linqBasics.linqMethodSyntaxWithoutLamda();
linqBasics.linqMethodSyntaxWithLamda();
linqBasics.squareNumberAss2();

// Call for LINQObjects 
LinqObjects linqObjects = new LinqObjects();
linqObjects.Initialize();
linqObjects.filterStudentQuery();
linqObjects.filterStudentMethod();


Console.WriteLine("Runtime polymorphism example");
// Prints Child Print and creates an object of ChildRuntimePoly 
RuntimePoly print = new ChildRuntimePoly();
print.Print();

//Prints ParentPrint.Print and creates an object of RuntimePoly
RuntimePoly printP = new RuntimePoly();
printP.Print();
Console.ReadKey();