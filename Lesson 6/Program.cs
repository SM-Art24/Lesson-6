using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Lesson_6
{
    class Program
    {            /*3. В массиве хранятся наименования некоторых объектов. Построить список C1, элементы которого содержат
                  *наименования и шифры данных объектов, причем элементы списка должны быть упорядочены по возрастанию шифров.
                  *Затем «сжать» список C1, удаляя дублирующие наименования объектов.
                 */
        class ListName
        {
            public SortedList<Guid, string> C1=new();
            public ListName(string[] element)
            {
                foreach (string item in element)
                {
                    Guid id = Guid.NewGuid();
                    C1.Add(id, item);
                }
            }

            public void Delete()
            {
                ICollection<Guid> keys = C1.Keys;
                List<string> box = new();
                foreach (Guid item in keys)
                {
                    box.Add(C1[item]);
                }
                
                for (int i =0;i< box.Count;i++)
                    for (int j = i+1; j < box.Count; j++)
                        if (box[i]== box[j])
                         C1.RemoveAt(j);        
            }
            public override string ToString()
            {
                string result= null;
                foreach (object item in C1)
                    result += "\n"+item;
                return result;
            }
        }
        
        static void Main(string[] args)
        {
            string [] element =new string[] { "Jack", "Harry", "Jack", "Jacob", "Charley", "Thomas" };
            ListName first_test = new(element);
           Console.WriteLine( first_test.ToString());
            first_test.Delete();
            Console.WriteLine(first_test.ToString());
        }
    }
}
