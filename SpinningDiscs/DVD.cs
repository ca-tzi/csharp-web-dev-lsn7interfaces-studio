using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : BaseDisc, IDisc
    {
        // TODO: Implement your custom interface.
        public void Spin()
        {

        }

        public void read()
        {
            throw new NotImplementedException();
        }

        public DVD(string name, int capacity,string type) : base(name, capacity, type)
        {

        }

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.
    }
}
