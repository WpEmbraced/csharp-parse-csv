using System;
using System.IO;

string csvFilePath = "/path/to/data.csv";

try
{
    // Read all lines from the CSV file
    string[] lines = File.ReadAllLines(csvFilePath);

    // Process each line
    foreach (string line in lines)
    {
        // Split the line into fields
        string[] fields = line.Split(',');

        // Check if the line has the expected number of fields
        if (fields.Length >= 3)
        {
            // Access the fields using meaningful variable names
            string field1 = fields[0];
            string field2 = fields[1];
            string field3 = fields[2];

            // Do something with the fields, e.g., print them
            Console.WriteLine($"{field1} - {field2} - {field3}");
        }
        else
        {
            // Handle lines with insufficient fields
            Console.WriteLine($"Invalid line: {line}");
        }
    }
}
catch (IOException e)
{
    // Handle file reading error
    Console.WriteLine($"Error reading the CSV file: {e.Message}");
}
