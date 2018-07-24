#! "netcoreapp2.1"
#r "nuget:Newtonsoft.Json,11.0.0"

using Newtonsoft.Json;

string Beautify() {
    var inputFile = "resource/Json.json";
    var json = File.ReadAllText(inputFile);
    var obj = JsonConvert.DeserializeObject<dynamic>(json);
    return JsonConvert.SerializeObject(obj, Formatting.Indented);
}


var result = Beautify();
Console.WriteLine(result);
