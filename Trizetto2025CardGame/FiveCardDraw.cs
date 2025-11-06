using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trizetto2025CardGame;

public class FiveCardDraw
{
    // each player is dealt five cards
    // each player then bets on their hand
    // each player then discards 0-5 cards
    // each player then bets again
    // best hand wins

    // determine hands
    // check to see if a hand has an ace
    public static bool HasAce(List<Card> cards)
    {
        //foreach (Card card in cards)
        //{
        //    if (card.rank == "A")
        //    {
        //        return true;
        //    }
        //}
        // query syntax
        //var results = (from card in cards
        //               where card.rank == "A"
        //               select card).Any();

        // method syntax
        //cards.Select(c => c.rank).Contains("A");
        return cards.Any(c => c.rank == "A");
    }

    // does hand have pair
    // exactly two cards with same value/rank
    public static bool HasPair(List<Card> cards)
    {
        // group by either rank or value and get a count
        return cards.GroupBy(c => c.value).Any(group => group.Count() == 2);
    }

    public static bool HasTrips(List<Card> cards)
    {
        // group by either rank or value and get a count
        return cards.GroupBy(c => c.value).Any(group => group.Count() == 3);
    }

}
