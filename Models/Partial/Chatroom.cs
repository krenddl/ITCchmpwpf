using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCChampionship.Models
{
    public partial class Chatroom
    {
        public ChatMessage LastChatMessage
        {
            get
            {
                if(ChatMessage.Count == 0)
                {
                    return null;
                }
                return ChatMessage.OrderBy(p => p.Date).Last();
            }
        }
    }
}
