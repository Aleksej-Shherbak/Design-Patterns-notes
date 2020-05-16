using System.Collections;
using System.Collections.Generic;

namespace Iterator_16.BankExample
{
    public class Bank : IEnumerable
    {
        private List<Banknote> _banknotes = new List<Banknote>
        {
            new Banknote(),
            new Banknote(),
            new Banknote(),
            new Banknote()
        };

        public Banknote this[int index]
        {
            get => _banknotes[index];
            set => _banknotes.Insert(index, value);
        }

        public int Count => _banknotes.Count;


        /// <summary>
        /// Здесь наш банк предоставляет пользователям кассира для банковских операций.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return new Cashier(this);
        }
    }
}