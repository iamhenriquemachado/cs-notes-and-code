using cs_notes_and_code.challenges;

double result1 = MathToolKit.Average(5, 10);
Console.WriteLine($"Test 1 (2-Params): Expected 7.5 | Got: {result1}");

double result2 = MathToolKit.Average(10, 20, 30);
Console.WriteLine($"Test 2 (3-Params): Expected 20.0 | Got: {result2}");

double[] prices = { 1.5, 2.5, 4.0, 6.0 };
double result3 = MathToolKit.Average(prices);
Console.WriteLine($"Test 3(Array): Expected 3.5 | Got: {result3}");
