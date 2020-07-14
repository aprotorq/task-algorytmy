using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CountCharacters
{
    public class CharacterModel
    {
        private char charackter;
        private int count;

        public CharacterModel(char charackter, int count)
        {
            this.charackter = charackter;
            this.count = count;
        }

        public char Character
        {
            get => charackter;
            set => charackter = value;
        }
        public int Count
        {
            get => count;
            set => count = value;
        }
        public override string ToString()
        {
            return $"{Character}: {Count}";
        }
    }
}
