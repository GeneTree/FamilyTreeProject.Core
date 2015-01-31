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
    public class Note
    {
        #region Constructors

        public Note() { }

        public Note(int treeId)
            : this()
        {
            TreeId = treeId;
        }

        #endregion

        public string Text { get; set; }

        public int TreeId { get; set; }

        #region IIdentifiable Members

        /// <summary>
        ///   Gets or sets the id of the note
        /// </summary>
        public int Id { get; set; }

        public bool IsNew
        {
            get { return Id == 0; }
        }

        #endregion

    }
}