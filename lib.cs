using Model.Movies;
namespace Lib
{
    class lib
    {
       
        public string HtmlAsList(List<Movies> movie)
        {
            string list = @"<table><th><tr><td>id</td><td>title</td><td>rating</td><td>genre</td><td>duration</td></tr></th><tbody>";

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




    }
}