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
namespace Essentials
{
    public class ConfigOptions
    {
        public static Config OptionConfig = new Config("Options.conf");

        public static int LogonPort = 3724;
        public static int WorldPort = 8085;
        public static int MySQLPort = 3306;
        public static string Host = "127.0.0.1";
        public static string CharDBHost = "127.0.0.1";
        public static string CharDBUser = "root";
        public static string CharDBPass = "ascent";
        public static string CharDBName = "characters";
    }
}
