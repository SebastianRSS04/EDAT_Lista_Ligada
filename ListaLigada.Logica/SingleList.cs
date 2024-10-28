
namespace ListaLigada.Logica
{
    public class SingleList <T>
    {
        private SingleNode<T>? _first;

        public SingleList()
        {
            _first = null;
        }

        public bool isEmmpy => _first == null;

        public void Add(T item) 
        {
            var node = new SingleNode<T>(item);
            if (isEmmpy)
            {
                _first = node;
            }
            else
            { 
                var pointer = _first;

                while (pointer!.Next != null)
                {
                    pointer= pointer.Next;  
                }

                pointer!.Next = node;
            }

        }

        public override string ToString()
        {
            var cadenaLista = string.Empty;
            var Pointer = _first;

            while (Pointer != null)
            {
                cadenaLista += $"{Pointer.Data}\n";  
                Pointer = Pointer.Next;
            }
            return cadenaLista; 
        }

   
    }
}
