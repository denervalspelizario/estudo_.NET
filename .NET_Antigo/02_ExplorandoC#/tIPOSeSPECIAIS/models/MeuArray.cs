using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tIPOSeSPECIAIS.models
{
    public class MeuArray<T> // esse T significa um tipo mas ele pode ser qualquer nome
    {
        private static int capacidade = 10;  // constante tipo int com valor 10
        private int contador = 0; // variavel tipo int valor 0
        private T[] array = new T[capacidade]; // array tipo indefinido( T )  de tamanho da const capacidade(10)

        public void AdicionarElementoArray(T elemento)   //metodo que recebe um parametro com tipo indefinido
        {
            if(contador + 1 < 11) 
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index];}
            set { array[index] = value;}
        }
    }
}