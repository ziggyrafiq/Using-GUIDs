using System;

Guid testGuid;
testGuid = Guid.NewGuid();

string guidString = "b86f2096-237a-4059-8329-1bbcea72769b";

//convert string to Guid
testGuid = Guid.Parse(guidString);

Console.WriteLine(testGuid);

//Best way to convert string to Guid
if (Guid.TryParse(guidString, out testGuid))
{
    Console.WriteLine(testGuid);
}
else
{
    Console.WriteLine("Sorry Invalid GUID");
}

//Comparing two Guids 
Guid guid1 = Guid.NewGuid();
Guid guid2 = Guid.NewGuid();
if (guid1.Equals(guid2))
{
    Console.WriteLine("GUID Are Equal.");
}
else
{
    Console.WriteLine("Sorry GUID Not Equal.");
}

//Guid to string
string testGuidString = testGuid.ToString();
Console.WriteLine(testGuidString);


Console.ReadLine();