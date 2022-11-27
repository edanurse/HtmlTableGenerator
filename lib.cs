using Model.Movies;
namespace Lib
{
    class lib
    {

        public string HtmlAsList(List<Movies> movie)
        {
            string list = @"<table><th><tr><td><strong>Id</strong></td><td><strong>Title</strong></td><td><strong>Rating</strong></td><td><strong>Genre</strong></td><td><strong>Duration</strong></td></tr></th><tbody>";

            foreach (var k in movie)
            {
                list += @"<tr>";
                list += @"<td>" + k.id.ToString() + @"</td>";
                list += @"<td>" + k.title + @"</td>";
                list += @"<td>" + k.rating + @"</td>";
                list += @"<td>" + k.genre + @"</td>";
                list += @"<td>" + k.duration.ToString() + @"</td>";
                list += @"</tr>";
            }
            list += @"</tbody></table>";
            return list;
        }
        public void FileWriter(string m)
        {
            StreamWriter Yaz = new StreamWriter(@"C:\Users\sengu\Desktop\HtmlTableGenerator\output.html");
            Yaz.WriteLine(m);
            

        }



    }
}