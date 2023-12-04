// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
using Task.SerializingToJSON;

var obj = new Lad()
{
    firstName = "Ofsdaf",
    lastName = "sdfsdf",
    Id = Guid.NewGuid()
};
var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);

Console.WriteLine(jsonString);
var namesText = File.ReadAllText(@"/Users/bodeych/RiderProjects/Task.SerializingToJSON/Task.SerializingToJSON//Names.json");
var newObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Lad>(namesText);

Console.WriteLine(newObj.firstName);
Console.ReadLine();
