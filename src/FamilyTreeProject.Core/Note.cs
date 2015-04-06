//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable ConvertPropertyToExpressionBody
namespace FamilyTreeProject
{
    public class Note
    {
        public Note() { }

        public Note(int treeId) : this()
        {
            TreeId = treeId;
        }

        /// <summary>
        ///   Gets or sets the id of the note
        /// </summary>
        public int Id { get; set; }

        public bool IsNew
        {
            get { return Id == 0; }
        }

        public string Text { get; set; }

        public int TreeId { get; set; }
    }
}