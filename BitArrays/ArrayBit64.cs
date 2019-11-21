using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays
{
    internal class ArrayBit64 : IEnumerable<int>
    {
        private const byte Bits = 64;
        private ulong number;  
        public ArrayBit64(ulong number)
        {
            this.Number = number;
        }

     
        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

      
        public byte this[int index]
        {
            get
            {
                if (index < 0 || index >= Bits)
                {
                    throw new ArgumentOutOfRangeException("The index is out ");
                }
                return (byte)((this.Number >> index) & 1);
            }
            set
            {
                if (index < 0 || index >= Bits)
                {
                    throw new ArgumentOutOfRangeException("The index is out ");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("It should be 1 or 0");
                }
                if (((int)(this.Number >> index) & 1) != value)
                {
                    this.Number ^= (1ul << index);
                }
            }
        }

       

        public static bool operator ==(ArrayBit64 first, ArrayBit64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(ArrayBit64 first, ArrayBit64 second)
        {
            return !first.Equals(second);
        }

      

        public override bool Equals(object obj)
        {
            var otherBitArray = obj as ArrayBit64;
            return this.Number.Equals(otherBitArray.Number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Bits; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.Number.GetHashCode();
        }

       
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int index = 0; index < 64; index++)
            {
                result.Insert(0, ((this.Number >> index) & 1));
            }

            return result.ToString();
        }

      
    }
}

