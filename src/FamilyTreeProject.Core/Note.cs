//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable ConvertPropertyToExpressionBody

using FamilyTreeProject.Common;

namespace FamilyTreeProject
{
    public class Note : BaseEntity
    {
        public Note() : base(-1) { }

        public Note(int treeId) : base(treeId) { }

        public string Text { get; set; }
    }
}