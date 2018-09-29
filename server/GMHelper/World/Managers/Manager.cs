﻿/*
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

using Essentials;

namespace GMHelper
{
    public class Manager
    {
        /// <summary>
        /// Handles WorldServer Instance
        /// </summary>
        public static WorldServer m_WorldServer;
        /// <summary>
        /// Initializes a new WorldServer
        /// Handled in Logon.cs
        /// </summary>
        /// <param name="username"></param>
        public static void Initialize(string username)
        {
            m_WorldServer = new WorldServer(username.ToUpper());
        }
    }
}
