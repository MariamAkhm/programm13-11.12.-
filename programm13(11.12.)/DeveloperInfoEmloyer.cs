using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm13_11
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class DeveloperInfoEmloyer:Attribute
    {
        private string developer;
        private string company;
        public string Developer
        {
            get
            {
                return developer;
            }
            set
            {
                developer = value;
            }
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }
        public DeveloperInfoEmloyer(string developer, string company)
        {
            this.developer = developer;
            this.company = company;
        }
    }
}
