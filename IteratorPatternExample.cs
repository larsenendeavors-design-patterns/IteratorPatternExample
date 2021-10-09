using System;
using IteratorPatternExample.Objects;

namespace IteratorPatternExample
{
    internal static class IteratorPatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Christopher Okhravi YouTube series in
         * an effort to teach myself and get familiar with these patterns.  None of this is meant to be
         * original content, and if you see this and wonder why it's in my repo, mostly it's for me, but
         * I'm happy that you're here and here's proof that I have at least heard of this particular
         * pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/09
         */

        
        private static void Main()
        {
            // While this pattern has been implemented for us and we take it for granted, this pattern can be useful
            // when one wants to iterate over certain objects or translate them to a foreach loop, something like a game
            // inventory would benefit from the pattern
            var stringArray = new[] { "one", "two", "three", "four" };
            var concreteIterable = new ConcreteIterable<string>(stringArray);
            var concreteIterator = concreteIterable.GetIterator();

            while (concreteIterator.HasNext())
            {
                Console.WriteLine(concreteIterator.Current());
                concreteIterator.Next();
            }
        }
    }
}