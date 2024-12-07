using Assignment;

string input = "Hello, World!";

List<int> vowelPositions = Algorithms.GetVowelPositions(input);
Console.WriteLine("Vowel positions:");
foreach (int position in vowelPositions)
{
    Console.WriteLine(position); 
}

string shifted = Algorithms.TransformCase(input);
Console.WriteLine("Shifted string: " + shifted);

string swapped = Algorithms.ReplaceCharacter("Hello World", 'e', 'z');
Console.WriteLine("Swapped case string: " + swapped);

string result = Algorithms.SwapPairs(input);
Console.WriteLine(result);

// string swappedPairs = Algorithms.SwapPairs(input);
// Console.WriteLine("Swapped pairs characters string: " + SwapPairs);
