/*
          _______ _____  _______ _______ _______ 
         |    ___|     \|    ___|   |   |   |   |
         |    ___|  --  |    ___|       |   |   |
         |_______|_____/|_______|__|_|__|_______| 
     Copyright (C) 2014 EmuDevs <http://www.emudevs.com/>
 
  This program is free software; you can redistribute it and/or modify it
  under the terms of the GNU General Public License as published by the
  Free Software Foundation; either version 2 of the License, or (at your
  option) any later version.
 
  This program is distributed in the hope that it will be useful, but WITHOUT
  ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
  FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
  more details.
 
  You should have received a copy of the GNU General Public License along
  with this program. If not, see <http://www.gnu.org/licenses/>.

*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Essentials;

namespace GMHelper
{
    public partial class WorldServer
    {
        /// <summary>
        /// Command Syntax List
        /// Handled within CHAT_TYPE_SYSTEM
        /// </summary>
        public List<string> CmdList = new List<string>();

        [PacketHandler(Opcodes.SMSG_GM_MESSAGECHAT)]
        void HandleGamemasterServerChatMessage(PacketReader reader)
        {
            ChatType type = (ChatType)reader.ReadByte();
            Language language = (Language)reader.ReadUInt32();
            UInt64 senderGUID = reader.ReadUInt64();
            reader.ReadUInt32(); // Always 0

            UInt32 senderNameLenght = reader.ReadUInt32();
            string senderName = reader.ReadCString();

            UInt64 receiverGUID = reader.ReadUInt64();
            UInt32 messageLength = reader.ReadUInt32();

            string message = reader.ReadCString();

            OnChatMessage?.Invoke(this, new ChatArgs
            {
                Type = type,
                Message = message,
                Name = senderName,
                ChannelName = null
            });
        }

        [PacketHandler(Opcodes.SMSG_MESSAGECHAT)]
        void HandleServerChatMessage(PacketReader reader)
        {

            ChatType type = (ChatType)reader.ReadByte();
            Language language;
            UInt64 targetGUID;
            UInt64 targetGUIDOther;
            UInt32 messageLength;
            string channelName = null;
            string message;

            language = (Language)reader.ReadUInt32();

            targetGUID = reader.ReadUInt64();

            reader.ReadUInt32(); // Some flags

            channelName = type == ChatType.CHAT_TYPE_CHANNEL ? reader.ReadCString() : null;

            targetGUIDOther = reader.ReadUInt64();
            messageLength = reader.ReadUInt32();
            message = reader.ReadCString();
            reader.ReadByte(); // chattag

            PlayerName result = PlayerNameList.Find((PlayerName name) => { return name.GUID == targetGUID; });

            var args = new ChatArgs
            {
                Type = type,
                Message = message,
                ChannelName = channelName != null ? channelName : string.Empty,
                Name = result != null ? result.Name : string.Empty
            };
            OnChatMessage?.Invoke(null, args);

            if (targetGUID > 0)
            {
                PacketWriter writer = new PacketWriter(Opcodes.CMSG_NAME_QUERY);
                writer.Write(targetGUID);
                Send(writer);
            }
        }
        /// <summary>
        /// Receives a new message from another player
        /// </summary>
        public ChatMessage ReceiveMsg
        {
            get { return QueryChatMessage; }
            set { QueryChatMessage = value; }
        }
        /// <summary>
        /// Handles commands & other System messages
        /// </summary>
        /// <returns></returns>
        public string ReceiveCMDSyntax()
        {
            string temp = null;
            foreach (string cmd in CmdList)
                temp += cmd + "\n";
            return temp;
        }

        [PacketHandler(Opcodes.SMSG_CHAT_PLAYER_NOT_FOUND)]
        void HandleChatPlayerNotFound(PacketReader reader)
        {
            WarningMessage = "Player " + reader.ReadCString() + " not found..";
        }
    }
}
