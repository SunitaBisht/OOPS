using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Studentpartial
    {
        public string GetCompleteName()
        {
            return _FirstName + " " + _LastName;
        }
    }
}
