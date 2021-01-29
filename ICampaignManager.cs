using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework
{
    interface ICampaignManager
    {
        void BuywCampaign(Gamer gamer,Customer customer,Campaign campaign);
        void AddCampaign();
        void Update();
        void Del();
    }
}
