using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Deck
    {
        public static void main()
        {

            String[] suit = { "Spades", "Hearts", "Diamond", "Clubs" };

            String[] rank = { "Ace", "1", "2", "3", "4",
                 "5", "6", "7", "8", "9",
                 "10", "Jack", "Queen", "King" };

            int rank1, rank2, rank3, rank4, suit1, suit2, suit3, suit4, count = 0;

            int[] deck = new int[52];

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i;
            }

            do
            {

                count++;
                for (int i = 0; i < deck.Length; i++)
                {
                    Random random = new Random();
                    int index = (int)(random.Next() * deck.Length);
                    int temp = deck[i];
                    deck[i] = deck[index];
                    deck[index] = temp;
                }

                suit1 = deck[0] / 13;
                suit2 = deck[1] / 13;
                suit3 = deck[2] / 13;
                suit4 = deck[3] / 13;

                rank1 = deck[0] % 13;
                rank2 = deck[1] % 13;
                rank3 = deck[2] % 13;
                rank4 = deck[3] % 13;

            } while (rank1 != rank2 || rank2 != rank3 || rank3 != rank4);

            Console.WriteLine(" Four-of-kind cards: " + suit[suit1] + " of "
                + rank[rank1] + ", " + suit[suit2] + " of " + rank[rank2]
                + ", " + suit[suit3] + " of " + rank[rank3] + ", "
                + suit[suit4] + " of " + rank[rank4]
                + "\n Number of shuffled times: " + count);

        }

    }
