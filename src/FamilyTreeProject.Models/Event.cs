//******************************************
//  Copyright (C) 2011-2013 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included License.txt file)        *
//                                         *
// *****************************************

using System.Runtime.Serialization;

namespace FamilyTreeProject
{
    public abstract class Event
    {
        #region Public Properties

        public string Date { get; set; }

        public string Place { get; set; }

        #endregion
    }
}