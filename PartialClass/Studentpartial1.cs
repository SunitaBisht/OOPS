using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class Studentpartial
    {
        private string _FirstName;
        private string _LastName;


        public string FirstName
        {
            set
            {
                _FirstName = value;
            }

            get
            {
                return _FirstName;
            }
        }
        public string LastName
        {
            set
            {
                _LastName = value;
            }

            get
            {
                return _LastName;
            }
        }
       
    }
}
