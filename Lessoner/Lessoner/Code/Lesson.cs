﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lessoner
{
    public class Lesson
    {
        public string NameLong = "";
        public string NameShot = "";
        public int ID = -1;
        public int TagInfoID = -1;
        public string Information = "";
        public int FachModID = -1;
        public bool FindetStatt = false;
        public int StundeBeginn = -1;
        public int StundeEnde = -1;
        public int LehrerID  = -1;
        public int TagID = -1;
        public int FachID = -1;
        public string RoomName = "Kein Raum";
        public int RoomID = -1;
    }
}