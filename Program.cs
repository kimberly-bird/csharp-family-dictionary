using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define a Dictionary that contains information about several members of your family. Use the following example as a template.

            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){
                {"name", "Melissa"},
                {"age", "31"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"name", "Blake"},
                {"age", "28"}
            });
            myFamily.Add("niece", new Dictionary<string, string>(){
                {"name", "Aspen"},
                {"age", "1"}
            });
            myFamily.Add("nephew", new Dictionary<string, string>(){
                {"name", "Jace"},
                {"age", "3"}
            });

            // Next, iterate over each item in myFamily and produce the following output. Remember that you can use square bracket notation to get to the value of a key, and that a dictionary has a Key and a Value property.

            // Krista is my sister and is 42 years old

            foreach(KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {
                Console.WriteLine($"{familyMember.Value["name"]} is my {familyMember.Key} and is {familyMember.Value["age"]} years old");
            }
        }
    }
}
