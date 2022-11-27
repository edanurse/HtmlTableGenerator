using Model.Movies;
using System.Text.Json;
using Lib;


string fileName = @"C:\Users\sengu\Desktop\HtmlTableGenerator\movies.json";
string jsonString = File.ReadAllText(fileName);
List<Movies> Movie = JsonSerializer.Deserialize<List<Movies>>(jsonString)!;
lib lb=new lib();
lb.FileWriter(lb.HtmlAsList(Movie));


