using Dz6;
using System.Text.Json;


Console.OutputEncoding = System.Text.Encoding.Unicode;

const string path = "./JSON_info.json";

var jsonContent = File.ReadAllText(path);

var info = JsonSerializer.Deserialize<List<InJson>>(jsonContent);
