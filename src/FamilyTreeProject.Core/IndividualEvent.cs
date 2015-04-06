//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using FamilyTreeProject.Common;

namespace FamilyTreeProject
{
    public class IndividualEvent : Event
    {
        public IndividualEvent() : base(-1) { }

        public IndividualEvent(int treeId) : base(treeId) { }

        public IndividualEventType EventType { get; set; }
    }
}