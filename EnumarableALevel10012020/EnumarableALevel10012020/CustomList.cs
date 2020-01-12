using System;
using System.Collections;
using System.Collections.Generic;

namespace EnumarableALevel10012020
{
    public class CustomList : IEnumerable, ICustomLink
    {//мне нужен стек или очередь
        public Node Head { get; private set; }// хранение первого индекса
        public Node Tail { get; private set; } //хранение последнего элемента

        Stack<Notebook> notebookCollection = new Stack<Notebook>(3);

        public Notebook this[int index] =>/*READONLY*/ throw new NotImplementedException();//считаем кол-во элементов. //проверить что бы был хоть один элемент or index out of range exception 

        public void Add(int serialNumber, string name)// добавлять надо в конец//если некст элемент = нал, то это последний элемент. В функцию добавления сделать переприсваивание?????????????
        { //Проверки при добавлении. Проверить, что теил не ноль, что список не пустой. 
            notebookCollection.Push(new Notebook(serialNumber, name));
        }
        public void Delete(Notebook value)// Переприсваиваем некст элемент, спросить у Игоря или Юли что сделать?????
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return new CustomListEnumerator();//возврат кастомного энумератора
        }
    }
}
