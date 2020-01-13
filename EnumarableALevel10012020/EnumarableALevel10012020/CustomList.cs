using System;
using System.Collections;

namespace EnumarableALevel10012020
{
    public class CustomList: IEnumerable, ICustomLink
    {//мне нужен стек или очередь
        public Node Head { get; private set; }// хранение первого индекса
        public Node Tail { get; private set; } //хранение последнего элемент

        public Notebook this[int index]
        {
            get
            {
                Notebook.Count = 0;
                for (int i = 0; i < index; i++)
                Notebook.Count++;
                return Notebook.Count;
            }
        }//считаем кол-во элементов. //проверить что бы был хоть один элемент or index out of range exception 

        public void Add(Notebook value)// добавлять надо в конец//если некст элемент = нал, то это последний элемент. В функцию добавления сделать переприсваивание?????????????
        { //Проверки при добавлении. Проверить, что теил не ноль, что список не пустой. 
            Node node = new Node(value);

            if (Head == null)
            {
                Head = node;
            }

            else
                Tail.NextElement = node;
                Tail = node;
        }
        public void Delete(Notebook value)// Переприсваиваем некст элемент, спросить у Игоря или Юли что сделать?????
        {
            Node ToBeDelete = Tail;
        }

        public IEnumerator GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public object Current()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            Head = null;
            Tail = null;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
    }
}
