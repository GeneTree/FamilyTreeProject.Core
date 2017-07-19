//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable ConvertPropertyToExpressionBody

using FamilyTreeProject.Common;

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject
{
    /// <summary>
    /// Note is a class that represents a Note
    /// </summary>
    public class Note : OwnedEntity
    {
        public Note() : base(string.Empty) { }

        public Note(string treeId) : base(treeId) { }

        /// <summary>
        /// The text of the Note
        /// </summary>
        public string Text { get; set; }
    }
}