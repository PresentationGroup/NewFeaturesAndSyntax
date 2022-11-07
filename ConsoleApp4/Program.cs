// See https://aka.ms/new-console-template for more information
using ConsoleApp4;
using System.Collections.ObjectModel;

Console.WriteLine("Hello, World!");
Console.WriteLine(int.MaxValue);
Console.WriteLine(nint.MaxValue);
Console.WriteLine(uint.MaxValue);
Console.WriteLine($"nint.MinValue = {nint.MinValue}");
Console.WriteLine($"nint.MaxValue = {nint.MaxValue}");
Console.WriteLine($"nuint.MinValue = {nuint.MinValue}");
Console.WriteLine($"nuint.MaxValue = {nuint.MaxValue}");




var a = PresentNewFeatureClass.IsLetter(Convert.ToChar("j"));
var b = PresentNewFeatureClass.IsLetter(Convert.ToChar("5"));


var se = PresentNewFeatureClass.IsLetterOrSeparator(Convert.ToChar("l"));
var se2 = PresentNewFeatureClass.IsLetterOrSeparator(Convert.ToChar("."));


var bb = PresentNewFeatureClass.IsConferenceDay(DateTime.Now);



Console.WriteLine(PresentNewFeatureClass.Transform(new PresentNewFeatureClass.Point(1, 2)));  // output: Point { X = -1, Y = 2 }
Console.WriteLine(PresentNewFeatureClass.Transform(new PresentNewFeatureClass.Point(5, 2)));  // output: Point { X = 5, Y = -2 }

var ff = PresentNewFeatureClass.IsNullTest(new object());
var ff2 = PresentNewFeatureClass.IsNullTest(null);

ObservableCollection<string> collection = new();
Person person = new("Hermit", "Purple");

Console.ReadKey();
