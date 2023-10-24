using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nuget_Serializar_atributos.models
{
    public class Venda
    {
        public int Id { get; set; }

        [JsonProperty("Nome_Produto")] // estou dizendo que meu atributo Produto vai vir com nome Nome_Produto
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; } // adicioando ao decimal a opção null e para fazer isso é necessario apenas colocar o ? no final
    }
}