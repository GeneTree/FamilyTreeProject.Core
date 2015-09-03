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
    /// <summary>
    /// Note is a class that represents a Note
    /// </summary>
    public class Note : OwnedEntity
    {
        public Note() : base(-1) { }

        public Note(int treeId) : base(treeId) { }

        /// <summary>
        /// The text of the Note
        /// </summary>
        public string Text { get; set; }
    }
}