using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trizetto2025CardGame;

public class Deck
{
    // members (properties, methods, constructors)
    public List<Card> cards { get; set; } = new List<Card>();

    public Deck()
    {
        // initialize this in the constructor
        // build the cards in the deck
        // you already know the suits and values of a deck cards
        // ♠, ♣, ♥, ♦
        // repeat (loop) 13 times for each suit
        List<string> suits = new List<string>() { "♠", "♣", "♥", "♦" };
        // if we just do J, Q, K, A then we'll need some kind of way to identify
        // these as opposed to the number cards
        List<string> ranks = new List<string>() { "J", "Q", "K", "A"};
        
        for (int i = 2;i<=14; i++)
        {
            foreach (string s in suits)
            {
                Card newCard;
                // build the card
                if (i < 10)
                {
                    newCard = new Card(s, i.ToString(), i);
                } else if (i == 10)
                {
                    newCard = new Card(s, "10", 10);
                } else {
                    string rank = ranks[i % 11];
                    newCard = new Card(s, rank, i);
                }
                // add the new card to the deck
                cards.Add(newCard);
            }
        }
    }

    // Deal card function
    // select a random card, remove it from the deck, return it to the caller
    public Card DealCard()
    {
        Random random = new Random();
        int indexOfCardToDeal = random.Next(cards.Count);
        Card cardToDeal = cards[indexOfCardToDeal];
        cards.Remove(cardToDeal);
        return cardToDeal;
    }

    public List<Card> DealCards(int numOfCardToDeal)
    {
        List<Card> cardsToDeal = new List<Card>();
        int i = 0;
        while (i < numOfCardToDeal) {
            cardsToDeal.Add(DealCard());
        }
        return cardsToDeal;
    }
}
