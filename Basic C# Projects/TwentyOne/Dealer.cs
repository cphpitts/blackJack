using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString());
            Console.WriteLine(card + "\n");
            using (StreamWriter file = new StreamWriter(@"C:\Users\cphpi\Documents\GitHub\cSharp_Projects\Basic C# Projects\TwentyOne\log\cardLog.txt", true))
            {
                file.WriteLine("{0}: {1}", DateTime.Now, card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
