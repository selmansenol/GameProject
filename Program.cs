

using System;

namespace GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer() {FirstName= "Valorant",Price= 0,GameType= "FPS" };
            Customer customer1 = new Customer() {CustomerID= 1,FirstName="Selman",LastName="Şenol",TCNo="11111111111",EMoneyinWallet=true };
            Campaign campaign = new Campaign() {CampaignName= "Yılbaşı İndirimi",DiscountPrice= 29 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.SignIn(customer1);

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.BuywCampaign(gamer1,customer1,campaign);


            
        }
    }
}
