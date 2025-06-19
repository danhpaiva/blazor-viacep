using System.Text.Json.Serialization;

namespace BlazzorWasmViaCep.Models;

public class Endereco
{
    [JsonPropertyName("cep")]
    public string Cep { get; set; }
    [JsonPropertyName("logradouro")]
    public string Rua { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    [JsonPropertyName("localidade")]
    public string Cidade { get; set; }
    public string Uf { get; set; }
    public string Ibge { get; set; }
    public string Gia { get; set; }
    public string Ddd { get; set; }
    public string Siafi { get; set; }
}
