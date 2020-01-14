using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumarableALevel10012020
{
    public class CustomList: IEnumerable, ICustomLink
    {
        public Node Head { get; private set; }// хранение первого индекса
        public Node Tail { get; private set; } //хранение последнего элемент
        public int Count { get; internal set; }

        public Notebook this[int index]
        {
            get
            {
                Node current = Head;
                int i = 0;

                while (current != null && i!= index)
                {
                    current = current.NextElement;
                    i++;
                }
                return current.Element;
            }
        }//считаем кол-во элементов. //проверить что бы был хоть один элемент or index out of range exception 

        public void Add(Notebook value)// добавлять надо в конец//если некст элемент = нал, то это последний элемент. В функцию добавления сделать переприсваивание?????????????
        { //Проверки при добавлении. Проверить, что теил не ноль, что список не пустой. 
            Node node = new Node(value);

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }

            else
            {
                Tail.NextElement = node;
                Tail = node;
            }
            Count++;
        }
        public bool Delete(Notebook value)// Переприсваиваем некст элемент, спросить у Игоря или Юли что сделать?????
        {
            Node previous = null;//откуда взялся previous?
            Node current = Head;

            while (current != null)
            {
                if (current.Element.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.NextElement = current.NextElement;
                        {
                            if (current.NextElement == null)
                            {
                                Tail = previous;
                            }
                        }
                    }
                    else
                    {
                        Head = Head.NextElement;
                        if (Head == null)
                        {
                            Tail = null;
                        }
                    }

                    Count--;//зачем нам каунт?

                    return true;
                }
                previous = current;
                current = current.NextElement;
            }
            return false;
        }

        public IEnumerator<Notebook> GetEnumerator()//можно использовать только с дженериками
        {
            Node current = Head;
            while (current != null)
            {
                yield return current.Element;
                current = current.NextElement;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Notebook>)this).GetEnumerator();
        }

        public object Current()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
    }
}
