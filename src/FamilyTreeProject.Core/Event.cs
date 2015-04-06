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
    public abstract class Event : BaseEntity
    {
        protected Event(int treeId) : base(treeId) { }

        public string Date { get; set; }

        public string Place { get; set; }
    }
}