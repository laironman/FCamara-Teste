using System;
using System.Collections.Generic;
using System.Text;

namespace Sinais
{
    public class Sinal
    {
        string charAbre = @"{[(";
        string charFecha = @"}])";
        public bool Valida(string sequencia)
        {

            var pilha = new Stack<string>();
            
            for (int x=0;x< sequencia.Length;x++)
            {
                var caractere = sequencia.Substring(x, 1);
                if (charAbre.IndexOf(caractere) > -1)
                {
                    pilha.Push(caractere);
                }
                else
                {
                    if(pilha.Count > 0 && charFecha.IndexOf(caractere) == charAbre.IndexOf(pilha.Peek()))
                    {
                        pilha.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
