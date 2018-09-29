using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMHelper
{
    public class ChatArgs : EventArgs
    {
        public ChatType Type;
        public string Name;
        public string ChannelName;
        public string Message;
    }


    public partial class WorldServer
    {
        public event EventHandler<ChatArgs> OnChatMessage;
        //public event EventHandler<ChatArgs> OnSystemChatMessage;
        //public event EventHandler<ChatArgs> OnWisperMessage;

    }
}
