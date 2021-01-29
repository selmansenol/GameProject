using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class GameManager : IGameManagerService
    {
        public void BuyGame(Customer customer, Gamer gamer)
        {
            Console.WriteLine(customer.FirstName +" " + gamer.FirstName + " adlı oyunu satın aldı.");
        }
    }
}
