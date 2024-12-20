using Newtonsoft.Json;
using NUnit.Framework;

public class DataProvider
{
    public static T GetTestData<T>(string fileName)
    {
        var jsonData = File.ReadAllText($"./TestData/{fileName}.json");
        return JsonConvert.DeserializeObject<T>(jsonData);
    }
}