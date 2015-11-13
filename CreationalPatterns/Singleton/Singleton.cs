using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD.CreationalPatterns.Singleton
{
    class Singleton
    {
        private static Singleton instance;

        public string Name { get; set; }
        
        private Singleton(string name) {
            this.Name = name;
        }
        
        public static Singleton getInstance(string name)
        {
            if (instance == null)
            {
                instance = new Singleton(name);
            }
            return instance;
        }
    }
}
