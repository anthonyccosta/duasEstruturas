﻿
namespace duasEstruturas
{
    internal class PilhaNumero
    {
        Numero? topo;

        public PilhaNumero()
        {
            this.topo = null;
        }

        public void Push(Numero n)
        {
            Numero? aux = this.topo;
            this.topo = n;
            n.SetNext(aux);
        }

        public void Print(bool repetidos) 
        {
            Numero? aux = this.topo;
            if (repetidos)
            {
                do
                {
                    if (aux.GetRepete()) Console.Write(aux.PrintNum() + " ");
                    aux = aux.GetNext();
                } while (aux != null);
            }
            else
            {
                do
                {
                    if (!aux.GetRepete()) Console.Write(aux.PrintNum() + " ");
                    aux = aux.GetNext();
                } while (aux != null);
            }
        }

        public int? GetNumByIndex(int index) 
        {
            int i = 10;
            Numero? aux = this.topo;
            do
            {
                if (i == index) return aux.GetNum();
                else return null;
                aux = aux.GetNext();
                i--;
            } while (index != i);
        }
    }
}
