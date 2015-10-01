using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Hamlet
{
    class RepeatedWord
    {
        public int WordUsedMost { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader myReader = new StreamReader()
            var myReader = File.ReadAllText("C:\\CoderCAMP_projects\\Hamlet\\Hamlet\\hamlet.txt").ToLower();
            myReader = myReader.Remove(',', ' ');
            myReader = myReader.Remove('?', ' ');
            var words = myReader.Split(' ');
            var hamlet = new Dictionary<string, int>();
            int value = 0;
            foreach (var word in words)
            {
                hamlet[word] = hamlet.TryGetValue(word, out value) ? ++value : 1;

            }
            hamlet.Remove("");
            hamlet.Remove(" ");

            foreach (KeyValuePair<string, int> item  in hamlet.OrderBy(key => key.Value))
            {
                Console.WriteLine("{0} {1} ", item.Key, item.Value);

            }
            Console.WriteLine(hamlet.Values);
            Console.ReadLine();
            

         



            

        }
    }
}
