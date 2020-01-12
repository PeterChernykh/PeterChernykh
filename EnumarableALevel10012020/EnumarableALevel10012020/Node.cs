using System;
using System.Collections;

namespace EnumarableALevel10012020
{
    public class Node//это наша ячейка/узел листа. Это весь функционал которій должно быть. Наш узел односвязного списка.Хранит в себе ноутбук и ссылку на следующий нод.
    {
        public Node(Notebook element, Node nextElement = null)// = null если не передаем такой параметр, он по дефолту null
        {//зачем тут конструктор?
            Element = element;
            NextElement = nextElement;
        }

        public Notebook Element { get; set; } //по факту то что внутри себя содержит Ноде
        public Node NextElement { get; set; }// должен быть не обджект так как следубший элемент это тоже нода.

    }
}
