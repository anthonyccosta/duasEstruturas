
namespace duasEstruturas
{
    internal class FilaNumeros
    {
        Numero? head;
        Numero? tail;

        public FilaNumeros()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Numero n)
        {
            if (IsEmpty()) this.head = this.tail = n;
            else
            {
                this.tail.SetNext(n);
                this.tail = n;
            }
        }

        public void Print(bool repetidos) 
        {
            Numero? aux = this.head;
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

        bool IsEmpty() { return head == null && tail == null; }
    }
}
