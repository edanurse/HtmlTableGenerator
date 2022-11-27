using Model.Movies;
using System.Text.Json;


string fileName = @"C:\Users\sengu\Desktop\HtmlTableGenerator\movies.json";
string jsonString = File.ReadAllText(fileName);
List<Movies> Movie = JsonSerializer.Deserialize<List<Movies>>(jsonString)!;

