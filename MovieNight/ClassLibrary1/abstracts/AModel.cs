using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.abstracts
{
    public class AModel
    {
        public Guid Id
        {
            get;
        }

        public AModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
