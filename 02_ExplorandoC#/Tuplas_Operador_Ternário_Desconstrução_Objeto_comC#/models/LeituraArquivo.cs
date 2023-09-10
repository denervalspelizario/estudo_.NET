using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas_Operador_Ternário_Desconstrução_Objeto_comNET.models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] linhas, int QuantidadeLinhas) LerArquivo(string caminho) // criando uma propriedade tipo tupla, que tem bool Sucesso , uma string Linhas e inteiro QuantidadeLinhas
        {
            try // deu certo
            {
            string[] linhas = File.ReadAllLines(caminho); // array de string recebe uam leitura de arquivo

            return (true, linhas, linhas.Count()); // deu certo retorna um true, o conteudo das linhas, e quantidade de linhas
            }
            catch(Exception) // deu erro
            {
                return(false, new string[0], 0); // retorna a tupla com dados zerados de acordo com seu tipo (bool, array de string, inteiro)
            }
        }   
    }
}