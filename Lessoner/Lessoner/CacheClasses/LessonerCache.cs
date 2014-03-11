﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lessoner
{
    public class LessonerCache
    {
        public struct ClassSelector
        {
            public int ClassID;
            public string ClassName;
            public int Week;
        }
        public int WeekIndex = 0;
        public List<DateTime> WeekBegins = new List<DateTime>();
        public ClassSelector SelectedTimeTable;
        public List<Lesson> Lessons = new List<Lesson>();
    }
}