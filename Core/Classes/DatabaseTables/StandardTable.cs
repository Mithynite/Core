using System;
using System.Reflection;

namespace Core.Classes
{
    public class StandardTable
    {
        /*
         * Vzhledem k tomu, že (skoro) každá z mých tabulek obsahuje id, vytvořil jsem pro usnadnění psaní tuto třídu.
         * Slouží pouze pro oddědění id pro další tabulky.
         */
        
        protected int id;

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}