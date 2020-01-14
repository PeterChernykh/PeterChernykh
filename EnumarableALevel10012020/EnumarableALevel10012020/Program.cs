using System;

namespace EnumarableALevel10012020
{
    public class Program
    {
        static void Main(string[] args)
        {
            var igor = new Notebook(1, "Igor");
            var vasia = new Notebook(2, "Vasia");
            var KYPJIbik = new Notebook(3, "KYPJIbik");

            var notebookCollection = new CustomList();

            notebookCollection.Add(igor);
            notebookCollection.Add(vasia);
            notebookCollection.Add(KYPJIbik);

            foreach (Notebook notebook in notebookCollection)
            {
                Console.WriteLine(notebook.Name);
            }

            Console.WriteLine("======================================");

            var pupkin = notebookCollection[1];

            foreach (Notebook notebook in notebookCollection)
            {
                Console.WriteLine(notebook.Name);
            }

            notebookCollection.Delete(pupkin);

            Console.WriteLine("======================================");

            Console.ReadKey();
        }
    }
}


//var igor = new Notebook(1, "Igor");
//var vasia ...
//var kurlik
//
//var notebookCollection = new CustomList();
// notebookCollection = notebookCollection.Add(new Notebook(1, "Igor"))
//notebookCollection = notebookCollection.Add(new Notebook(2, "Vasia"))
//notebookCollection = notebookCollection.Add(new Notebook(3, "KYPJIbik"))
//1. foreach(var notebook in notebookCollection)
//Console.WriteLine (notebook.Name)
//
//2.var pupkin = notebookCollection[1];
//3. notebookCollection.Delete(puplin);