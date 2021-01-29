using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    class CampaingManager : ICampaignManager
    {
        public void AddCampaign()
        {
            Console.WriteLine("Kampanya başarıyla eklendi."); 
        }

        public void BuywCampaign(Gamer gamer, Customer customer, Campaign campaign)
        {
            Console.WriteLine(customer.FirstName + " "+ gamer.FirstName + " adlı oyunu " + campaign.CampaignName +" indirimi ile " + campaign.DiscountPrice + " Tl indirimle aldı." );
        }

        public void Del()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
