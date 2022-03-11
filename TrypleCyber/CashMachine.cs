using System;
using System.Collections.Generic;
using System.Linq;

namespace TrypleCyber
{
    public class CashMachine : CommonMethod
    {
        private List<int> listmoney = new List<int>();
        public CashMachine()
        {
            listmoney.AddRange(new int[] { 2000, 1000, 500, 200, 100, 50, 25, 10, 5, 1 });
        }

        public void  GenerateCash(int amount)
        {
            if (amount == 0) throw new Exception("The amount must be greater than 0");
            var moneyList = new List<int>();
            while (amount > 0)
            {
                var distribution = listmoney.First(x => x <= amount);
                moneyList.Add(distribution);
                amount -= distribution;
            }
            ShowResult(moneyList);            
        }

    }
}
