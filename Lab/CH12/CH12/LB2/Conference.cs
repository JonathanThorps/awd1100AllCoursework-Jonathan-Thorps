using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2
{
    public class Conference
    {
        private string _groupName;
        private int _attendees;
        private DateTime _startingDate;
        private Room _room;

        public string Display()
        {
            return $"{Attendees} {StartingDate} {GroupName} {Room}";
        }
        public string GroupName
        { get => _groupName; set => _groupName = value; }

        public DateTime StartingDate
        { get => _startingDate; set => _startingDate = value; }

        public int Attendees
        { get => _attendees; set => _attendees = value; }

        public Room Room
        { get => Room; set => _room = value; }
    }
}
