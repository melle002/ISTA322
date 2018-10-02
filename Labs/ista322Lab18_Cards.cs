/*-------------------------Hand.cs----------------------*/
using System;
using System.Collections.Generic;
namespace Cards
{
    class Hand
    {
        public const int HandSize = 13;
        private List<PlayingCard> cards = new List<PlayingCard>(HandSize);
       // private PlayingCard[] cards = new PlayingCard[HandSize];
        private int playingCardCount = 0;

        public void AddCardToHand(PlayingCard cardDealt)
        {
            if (this.cards.Count >= HandSize)
            {
                throw new ArgumentException("Too many cards");
            }
            this.cards.Add(cardDealt);

            //if (this.playingCardCount >= HandSize)
            //{
               // throw new ArgumentException("Too many cards");
            //}
            this.cards[this.playingCardCount] = cardDealt;
            this.playingCardCount++;
        }

        public override string ToString()
        {
            string result = "";
            foreach (PlayingCard card in this.cards)
            {
                result += card.ToString() + "\n";
            }

            return result;
        }
    }
}
/*----------------------------------------Packs.cs-------------------*/
using System;
using System.Collections.Generic;

namespace Cards
{
    class Pack
    {
        public const int NumSuits = 4;
        public const int CardsPerSuit = 13;
        //private PlayingCard[,] cardPack;
        private Random randomCardSelector = new Random();
        private Dictionary<Suit, List<PlayingCard>> cardPack;

        public Pack()
        {
            this.cardPack = new Dictionary<Suit, List<PlayingCard>>(NumSuits);
            //this.cardPack = new PlayingCard[NumSuits, CardsPerSuit];

            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                List<PlayingCard> cardsInSuit = new List<PlayingCard>(CardsPerSuit);
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    cardsInSuit.Add(new PlayingCard(suit, value));
                    //this.cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
                this.cardPack.Add(suit, cardsInSuit);
            }
        }

        public PlayingCard DealCardFromPack()
        {
            Suit suit = (Suit)randomCardSelector.Next(NumSuits);

            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)randomCardSelector.Next(NumSuits);
            }

            Value value = (Value)randomCardSelector.Next(CardsPerSuit);
            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)randomCardSelector.Next(CardsPerSuit);
            }
            List<PlayingCard> cardsInSuit = this.cardPack[suit];
            PlayingCard card = cardsInSuit.Find(c => c.CardValue == value);
            cardsInSuit.Remove(card);
            //PlayingCard card = this.cardPack[(int)suit, (int)value];
            //this.cardPack[(int)suit, (int)value] = null;
            return card;
        }

        private bool IsSuitEmpty(Suit suit)
        {
            bool result = true;
            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }

            return result;

        }

        private bool IsCardAlreadyDealt(Suit suit, Value value)
        {
            List<PlayingCard> cardsInSuit = this.cardPack[suit];
            return (!cardsInSuit.Exists(c => c.CardSuit == suit && c.CardValue == value));
            //return (this.cardPack[(int)suit, (int)value] == null);
        }
    }
}
/*-------------------------------------Suit.cs-------------------------------------------*/

namespace Cards
{
    enum Suit { Clubs, Diamonds, Hearts, Spades }
}
/*--------------------------------------Value.cs-----------------------------------------*/

namespace Cards
{
    enum Value { Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
}
/*----------------------------------------PlayingCard.cs--------------------------------*/
namespace Cards
{
    class PlayingCard
    {
        private readonly Suit suit;
        private readonly Value value;

        public PlayingCard(Suit s, Value v)
        {
            this.suit = s;
            this.value = v;
        }

        public override string ToString()
        {
            string result = string.Format("{0} of {1}", this.value, this.suit);
            return result;
        }

        public Suit CardSuit
        {
            get
            {
                return this.suit;
            }
        }

        public Value CardValue
        {
            get
            {
                return this.value;
            }
        }
    }
}
