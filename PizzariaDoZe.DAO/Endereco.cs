using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.IO;

namespace PizzariaDoZe.DAO;
public class Endereco
{
    public int Id { get; set; }
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Bairro { get; set; }
    //cidade_id
    public int IdCidade { get; set; }
    public string Cidade { get; set; }
    //uf_id
    public int IdUf { get; set; }
    public string Uf { get; set; }
    //pais_id
    public int IdPais { get; set; }
    public string Pais { get; set; }
    public Endereco(int id = 0, string cep = "", string logradouro = "", string bairro = "",
    int idCidade = 0, string cidade = "",
    int idUf = 0, string uf = "",
    int idPais = 0, string pais = "")
    {
        Id = id;
        Cep = cep;
        Logradouro = logradouro;
        Bairro = bairro;
        IdCidade = idCidade;
        Cidade = cidade;
        IdUf = idUf;
        Uf = uf;
        IdPais = idPais;
        Pais = pais;
    }
}