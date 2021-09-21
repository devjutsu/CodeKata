using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataLib
{
    public static class TexasHoldemHands
    {
        public static (string type, string[] ranks) Hand(string[] holeCards, string[] communityCards)
        {
            var cards = holeCards.Concat(communityCards)
                            .Select(o => new Card { Rank = o.First().GetRank(), Suit = o.Last() })
                            .OrderBy(o => o.Rank)
                            .ToList();

            
            var straightFlush = cards.StraightFlush();
            if(straightFlush != null)
                return ("straight-flush", straightFlush.Select(o => o.RankChars()).ToArray());

            var four = cards.NofAKind(4);
            if (four != null)
                return ("four-of-a-kind", four.Select(o => o.RankChars()).ToArray());

            var fullhouse = cards.FullHouse();
            if(fullhouse != null)
                return ("full house", fullhouse.Select(o => o.RankChars()).ToArray());

            var flush = cards.Flush();
            if(flush != null)
                return ("flush", flush.Select(o => o.RankChars()).ToArray());

            var straight = cards.Select(o => o.Rank).ToList().Straight();
            if (straight != null)
                return ("straight", straight.Select(o => o.RankChars()).ToArray());

            var trips = cards.NofAKind(3);
            if (trips != null)
                return ("three-of-a-kind", trips.Select(o => o.RankChars()).ToArray());

            var twopair = cards.TwoPair();
            if (twopair != null)
                return ("two pair", twopair.Select(o => o.RankChars()).ToArray());

            var pair = cards.NofAKind(2);
            if (pair != null)
                return ("pair", pair.Select(o => o.RankChars()).ToArray());

            var nothing = cards.OrderByDescending(o => o.Rank).Select(o => o.Rank).Select(o => o.RankChars()).Take(5).ToArray();
            return ("nothing", nothing);
        }

        public static List<Rank> TwoPair(this List<Card> cards)
        {
            var grouped = cards.GroupBy(o => o.Rank);
            var pairs = grouped.Where(o => o.Count() == 2);

            if(pairs.Count() > 1)
            {
                var p = pairs.OrderByDescending(o => o.Key).Take(2).ToArray();
                var p1 = p[0].Key;
                var p2 = p[1].Key;

                var other = cards.Where(o => o.Rank != p1 && o.Rank != p2).OrderByDescending(o => o.Rank).First().Rank;

                return new List<Rank>() { p1, p2, other };
            }

            return null; 
        }

        public static List<Rank> NofAKind(this List<Card> cards, int n)
        {
            var grouped = cards.GroupBy(o => o.Rank);

            var four = grouped.Where(o => o.Count() == n);
            if (four.Count() > 0)
            {
                var quad = four.First().Key;
                var others = cards.Where(o => o.Rank != quad)
                                    .OrderByDescending(o => o.Rank)
                                    .Take(5-n)
                                    .Select(o => o.Rank).ToList();

                var result = new List<Rank>() { quad };
                result.AddRange(others);
                return result;
            }

            return null;
        }

        public static List<Rank> StraightFlush(this List<Card> cards)
        {
            var flush = cards.GroupBy(o => o.Suit)
                            .Where(o => o.Count() >= 5)
                            .FirstOrDefault();

            if(flush != null && flush.Count() > 0)
            {
                var straight = flush.Select(o => o.Rank).ToList().Straight();
                if(straight != null && straight.Count() > 0)
                {
                    return straight.ToList();
                }
            }

            return cards.Flush()?.Straight() ?? null;
        }


        public static List<Rank> FullHouse(this List<Card> cards)
        {
            var trips = cards.GroupBy(o => o.Rank).Where(o => o.Count() == 3).ToList();
            var pairs = cards.GroupBy(o => o.Rank).Where(o => o.Count() == 2).ToList();

            if((trips.Count() > 0 && pairs.Count() > 0) || trips.Count > 1)
            {
                if (trips.Count() > 1)
                {
                    var ttrips = trips.OrderByDescending(o => o.Key);
                    return new List<Rank>() { ttrips.First().Key, ttrips.Skip(1).First().Key };
                }
                else
                {
                    var pair = pairs.OrderByDescending(o => o.Key).First();
                    return new List<Rank>() { trips.First().Key, pair.Key };
                }
            }

            return null;
        }

        public static List<Rank> Flush(this List<Card> cards)
        {
            var result = cards.GroupBy(o => o.Suit)
                                    .Where(o => o.Count() >= 5)
                                    .FirstOrDefault()
                                    ?.OrderByDescending(o => o.Rank)
                                    ?.Take(5)
                                    ?.Select(o => o.Rank)
                                    ?.ToList();
            return result ?? null;
        } 

        public static List<Rank> Straight(this List<Rank> cards)
        {
            cards = cards.DistinctBy(o => o).OrderByDescending(o => o).ToList();
            if (cards.Count < 5)
                return null;
            
            var testing = cards.Take(5).ToList();
            if (testing.IsStraight())
                return testing;

            if(cards.Count > 5)
            {
                testing = cards.Skip(1).Take(5).ToList();
                if (testing.IsStraight())
                    return testing;
            }

            if(cards.Count > 6)
            {
                testing = cards.Skip(2).Take(5).ToList();
                if (testing.IsStraight())
                    return testing;
            }

            return null;
        }

        public static bool IsStraight(this List<Rank> cards)
            => cards.Zip(cards.Skip(4), (a, b) => (b + 4) == a).Any(o => o);

        public class Card
        {
            public Rank Rank { get; set; }
            public char Suit { get; set; }
        }

        public static string RankChars(this Rank r) => r switch
        {
            Rank.Deus => "2",
            Rank.Three => "3",
            Rank.Four => "4",
            Rank.Five => "5",
            Rank.Six => "6",
            Rank.Seven => "7",
            Rank.Eight => "8",
            Rank.Nine => "9",
            Rank.Ten => "10",
            Rank.Jack => "J",
            Rank.Queen => "Q",
            Rank.King => "K",
            Rank.Ace => "A",
            _ => throw new ArgumentException(nameof(r))
        };
        public static Rank GetRank(this char c) => c switch
        {
            '2' => Rank.Deus,
            '3' => Rank.Three,
            '4' => Rank.Four,
            '5' => Rank.Five,
            '6' => Rank.Six,
            '7' => Rank.Seven,
            '8' => Rank.Eight,
            '9' => Rank.Nine,
            '1' => Rank.Ten,
            'J' => Rank.Jack,
            'Q' => Rank.Queen,
            'K' => Rank.King,
            'A' => Rank.Ace,
            _ => throw new ArgumentException(nameof(c))
        };
        public static Suit GetSuit(this char c) => c switch
        {
            '♠' => Suit.Spades,
            '♦' => Suit.Diamonds,
            '♥' => Suit.Hearts,
            '♣' => Suit.Clubs,
            _ => throw new ArgumentException(nameof(c)),
        };
        public enum Suit
        {
            Hearts = 0,
            Spades = 1,
            Clubs = 2,
            Diamonds = 3
        }
        public enum Rank
        {
            Deus = 0,
            Three = 1,
            Four = 2,
            Five = 3,
            Six = 4,
            Seven = 5,
            Eight = 6,
            Nine = 7,
            Ten = 8,
            Jack = 9,
            Queen = 10,
            King = 11,
            Ace = 12
        }
        public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
        {
            return items.GroupBy(property).Select(x => x.First());
        }
    }
}
