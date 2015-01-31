//******************************************
//  Copyright (C) 2011-2013 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included License.txt file)        *
//                                         *
// *****************************************

using System.Runtime.Serialization;

using FamilyTreeProject.Common;

namespace FamilyTreeProject
{
    public class IndividualEvent : Event
    {
        public IndividualEventType EventType { get; set; }
    }
}