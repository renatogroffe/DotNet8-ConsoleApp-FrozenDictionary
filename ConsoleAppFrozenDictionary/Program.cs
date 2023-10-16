using System.Collections.Frozen;
using System.Runtime.InteropServices;
using System.Text.Json;

Console.WriteLine("***** Testes com .NET 8 | Colecoes imutaveis com FrozenDictionary  *****");
Console.WriteLine($"Versao do .NET em uso: {RuntimeInformation
    .FrameworkDescription} - Ambiente: {Environment.MachineName} - Kernel: {Environment
    .OSVersion.VersionString}");

var estadosCapitais = new Dictionary<string, string>
{
    ["AC"] = "Rio Branco",
    ["AL"] = "Maceio",
    ["AP"] = "Macapa",
    ["AM"] = "Manaus",
    ["BA"] = "Salvador",
    ["CE"] = "Fortaleza",
    ["DF"] = "Brasilia",
    ["ES"] = "Vitoria",
    ["GO"] = "Goiania",
    ["MA"] = "Sao Luis",
    ["MT"] = "Cuiaba",
    ["MS"] = "Campo Grande",
    ["MG"] = "Belo Horizonte",
    ["PA"] = "Belem",
    ["PB"] = "Joao Pessoa",
    ["PR"] = "Curitiba",
    ["PE"] = "Recife",
    ["PI"] = "Teresina",
    ["RJ"] = "Rio de Janeiro",
    ["RN"] = "Natal",
    ["RS"] = "Porto Alegre",
    ["RO"] = "Porto Velho",
    ["RR"] = "Boa Vista",
    ["SC"] = "Florianopolis",
    ["SP"] = "Sao Paulo",
    ["SE"] = "Aracaju",
    ["TO"] = "Palmas"
}.ToFrozenDictionary();

Console.WriteLine("Capital de São Paulo: " + estadosCapitais["SP"]);
Console.WriteLine("Capital de Pernambuco: " + estadosCapitais["PE"]);
Console.WriteLine("Numero de estados do Brasil: " + estadosCapitais.Count);
Console.WriteLine();
Console.WriteLine("JSON com os Estados + Capitais: ");
Console.WriteLine(JsonSerializer.Serialize(estadosCapitais,
    new JsonSerializerOptions() { WriteIndented = true }));