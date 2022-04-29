using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class DecoderRing
    {
        private int _shift;
        private string _innerRing;
        private string _outerRing;

        public DecoderRing(string innerRing, string outerRing, int shift)
        {
            _innerRing = innerRing;
            _outerRing = outerRing;
            _shift = 0;
        }
        public Decode(string text)
        {
            _innerRing = text;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (text == null)
                {
                    throw new InvalidCharacterException("Invalid Characters");
                }
            }
        }
            
        public Encoder(string text)
        {
            _outerRing = text;

            for (var i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (text == null)
                {
                    throw new InvalidCharacterException("Invalid Characters");
                }
            }
            
        }
        public int Shift(int shift)
        {

        }
    }
}
