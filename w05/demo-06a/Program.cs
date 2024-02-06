/*
 * CSE 212 Lesson 6a
 * Demonstrate how dictionaries (maps) work.
 */

// Create an empty dictionary
var student = new Dictionary<string, string>();
Console.WriteLine($"Empty dictionary: {{{string.Join(", ", student)}}}");

// Add name, credits, and the major to the student.
//student.Add("Joe", "13 credits, Major is: CIT");
student["name"] = "Joe";
student["credits"] = "14";
student["major"] = "Computer Science"; 
Console.WriteLine($"Populated student: {{{string.Join(", ", student)}}}");

// Display just the student credits
var credits = "";
Console.WriteLine($"Student credits: {student["credits"]}");

// Display just the keys.
Console.WriteLine($"Keys: {string.Join(", ",student.Keys)}");

// Display just the values
Console.WriteLine($"Values: {string.Join(", ", student.Values)}");

// Display all Key/Value pairs
foreach (var i in student) { Console.WriteLine($"{i}");}


// Remove major from the student
student.Remove("major");
Console.WriteLine($"After deleting the major: {{{string.Join(", ", student)}}}");
