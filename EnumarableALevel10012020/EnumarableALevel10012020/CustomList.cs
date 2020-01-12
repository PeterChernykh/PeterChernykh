using System;
using System.Collections;

namespace EnumarableALevel10012020
{
    public class CustomList: IEnumerable, ICustomLink
    {//мне нужен стек или очередь
        public Node Head { get; private set; }// хранение первого индекса
        public Node Tail { get; private set; } //хранение последнего элемента

        int position;

        public Notebook this[int index] =>/*READONLY*/ throw new NotImplementedException();//считаем кол-во элементов. //проверить что бы был хоть один элемент or index out of range exception 

        public void Add(Notebook value)// добавлять надо в конец//если некст элемент = нал, то это последний элемент. В функцию добавления сделать переприсваивание?????????????
        { //Проверки при добавлении. Проверить, что теил не ноль, что список не пустой. 
            Node node = new Node(value);

            if (Head == null)
                Head = node;
            else
                Tail.NextElement = node;
                Tail = node;
            position++;
        }
        public void Delete(Notebook value)// Переприсваиваем некст элемент, спросить у Игоря или Юли что сделать?????
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;//возврат кастомного энумератора
        }
        public object Current => throw new NotImplementedException();

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
    }
}
