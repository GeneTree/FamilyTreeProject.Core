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
    /// <summary>
    /// Citation is a class that represents a source citation
    /// </summary>
    public class Citation : OwnedEntity
    {
        public Citation() : base(-1) { }

        public Citation(int treeId) : base(treeId) { }

        /// <summary>
        /// The Date of the Citation
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// The page number of the citation within the Source
        /// </summary>
        public string Page { get; set; }

        /// <summary>
        /// The Id of the Source to which the citation is a part
        /// </summary>
        public int? SourceId { get; set; }

        /// <summary>
        /// The Source to which the citation belongs
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The text of the citation
        /// </summary>
        public string Text { get; set; }
    }
}
