﻿using System;
using System.Collections.Generic;

namespace Abc.NCrafts.Quizz.Questions._005
{
    public class Answer3
    {
        private static Dictionary<Key, int> _items
            = new Dictionary<Key, int>(100);

        public static void Run()
        {
            // begin
            for (var i = 0; i < 100; i++)
            {
                var key = new Key { Value = i };
                _items[key] = i;
            }
            // end
        }

        private struct Key : IEquatable<Key>
        {
            public int Value;

            public override bool Equals(object other)
            {
                return Value == ((Key)other).Value;
            }

            public bool Equals(Key other)
            {
                return Equals((object)other);
            }

            public override int GetHashCode() { return Value; }
        }
    }
}