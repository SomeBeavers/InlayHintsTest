using System.Text.Json.Nodes;

namespace CoreApp;

public class UseNuget
{
    public void Test()
    {
        var jsonArray      = (Method(), 1);
        var jsonArrayCount = jsonArray.Item1.Count;


        var ints = new List<int>();

        ints.Add(jsonArrayCount);


        //jsonArray = null;

        var a = jsonArray.Item1;
    }

    private static JsonArray Method()
    {
        return new JsonArray();
    }
}