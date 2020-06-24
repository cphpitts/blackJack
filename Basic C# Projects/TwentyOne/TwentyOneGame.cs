using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { set; get; }
        
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (TwentyOnePlayer player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet.");
            foreach (TwentyOnePlayer player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfulBet = player.Bet(bet);
                if (!successfulBet)
                {
                    return;
                }
                Bets[player] = bet;
            }


        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
