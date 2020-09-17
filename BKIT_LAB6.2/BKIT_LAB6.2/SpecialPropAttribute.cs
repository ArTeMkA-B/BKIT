using System;

namespace BKIT_LAB6._2
{
    class SpecialPropAttribute: Attribute
    {
        public int Id { get; private set; }
        private static int counter = 0;

        public SpecialPropAttribute()
        {
            Id = counter++;
        }
    }
}
