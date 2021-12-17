using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace programm13_11
{

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfoAttribute:Attribute
    {
        private string developerName;
        private string dateOfRealise;
        public string DeveloperName 
        { 
            get
            { return developerName; } 
            set
            { developerName = value; } 
        }
       public string DateOfRealise 
        {
            get 
            { return dateOfRealise; }
            set
            { dateOfRealise = value; } 
        }
        public DeveloperInfoAttribute(string developerName, string dateOfRealise)
        {
            this.developerName = developerName;
            this.dateOfRealise = dateOfRealise;
        }
    }
}
