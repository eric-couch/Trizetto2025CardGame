using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trizetto2025CardGame;

public class Card
{
    public string suit { get; set; }    // ♠, ♣, ♥, ♦
    // enum is good here
    public string rank { get; set; }   // 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A
    public int value { get; set; }  // 2, 3, 4... 11, 12, 13, 14

    public Card()
    {
        
    }

    // sinle line comment.  everything after the // is a comment
    /* 
     * multiline comment
     */
    /// <summary>
    /// This is a standard card from a 52 card deck
    /// </summary>
    /// <param name="suit">♠, ♣, ♥, ♦</param>
    /// <param name="rank">2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A</param>
    /// <param name="value">2, 3, 4... 11, 12, 13, 14</param>
    public Card(string suit, string rank, int value)
    {
        this.suit = suit;
        this.rank = rank;
        this.value = value;
    }

    // one of the members (methods) of the base Object class, which everything inherits from
    // is a thing called toString()
    // we can override this
    public override string? ToString()
    {
        return $"{rank}{suit}";
    }

}
