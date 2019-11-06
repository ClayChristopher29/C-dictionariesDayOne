using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Exercises");
            // Dictionary<string,double> groceryItems =new Dictionary<string, double>(){
            //     {"rice",2.00},
            //     {"sweet potato",0.99},
            //     {"squash",0.79}
            // };
            // groceryItems.Add("Frosted Flakes",3.99);
            // Console.WriteLine(groceryItems["sweet potato"]);


            // // 1. Create a dictionary to represent the menu at the taco shop. Each KeyValuePair in the dictionary should have a key of a string that represents the name of the menu item and a value that represents its price (double).
            // Dictionary<string,double> tacoTruck = new Dictionary<string,double>(){
            //     {"Ground Beef",1.99},
            //     {"Shredded Chicken",1.75},
            //     {"Carne Asada",2.99},
            // };
            // // 2. Create a dictionary to represent the employees at the taco shop. Each KeyValuePair should have a key of a string that represents the employee's name and a value of a string that represents their favorite menu item.
            // Dictionary<string,string> truckEmployee = new Dictionary<string, string>(){
            //     {"Carl","Ground Beef"},
            //     {"Emily","Shredded Chicken"},
            //     {"Maark","Carne Asada"}
            // };

            // foreach(KeyValuePair<string,string> employee in truckEmployee){
            //     Console.WriteLine($"{employee.Key} likes {employee.Value} and it cost {tacoTruck[employee.Value]}");
            // };
            Dictionary<string,string> wordsAndDefinitions = new Dictionary<string,string>();
            wordsAndDefinitions.Add("Awesome","The feeling of students when learning C#");
            wordsAndDefinitions.Add("Weak","When you feel powerless");
            wordsAndDefinitions.Add("Redemption","When you step back up");

            foreach (KeyValuePair<string,string> definition in wordsAndDefinitions){
                Console.WriteLine($"{definition.Value} is the definition of the word, {definition.Key}");
            };

            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            Dictionary<string,string> excitedWord = new Dictionary <string,string>();
            excitedWord.Add("word:","excited");
            excitedWord.Add("definition","having, showing, or characterized by heightened state of energy, enthusiasm,eagerness");
            excitedWord.Add("part of speech","adjective");
            excitedWord.Add("example sentence","I am excited to learn C#");

            dictionaryOfWords.Add(excitedWord);

            Dictionary<string,string> happyWord = new Dictionary <string,string>();
            happyWord.Add("word:","happy");
            happyWord.Add("definition","delighted, pleased, or glad, as over a particular thing:");
            happyWord.Add("part of speech","adjective");
            happyWord.Add("example sentence","I am happy");

            dictionaryOfWords.Add(happyWord);

            Dictionary<string,string> angryWord = new Dictionary <string,string>();
            angryWord.Add("word:","angry");
            angryWord.Add("definition","feeling or showing anger or strong resentment (usually followed by at, with, or about)");
            angryWord.Add("part of speech","adjective");
            angryWord.Add("example sentence","I am angry");

            dictionaryOfWords.Add(angryWord);

foreach(Dictionary<string,string> singleWord in dictionaryOfWords){
Console.WriteLine(singleWord);
foreach(KeyValuePair<string,string> wordData in singleWord){
    Console.WriteLine($"{wordData.Key} {wordData.Value}");
}
}


        }


            };








        }
