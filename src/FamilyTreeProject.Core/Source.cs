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
    /// Represents a Source in a Family Tree
    /// </summary>
    public class Source : Entity
    {
        public Source() : base(-1) { }

        public Source(int treeId) : base(treeId) { }

        /// <summary>
        /// Gets and sets the Author of the Source
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets and sets the Publisher of the Source
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Gets and sets the Id of the Repository where the Source can be found
        /// </summary>
        public int? RepositoryId { get; set; }

        /// <summary>
        /// Gets and sets the Repository where the Source can be found
        /// </summary>
        public Repository Repository { get; set; }

        /// <summary>
        /// Gets and sets the Title of the Source
        /// </summary>
        public string Title { get; set; }
    }
}
