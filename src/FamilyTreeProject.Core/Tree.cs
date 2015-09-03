//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System.Collections.Generic;

namespace FamilyTreeProject
{
    /// <summary>
    /// Represents a Family Tree
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// The Id of the Tree
        /// </summary>
        public int TreeId { get; set; }

        /// <summary>
        /// The Name of the Tree
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Id of the current home or root individual
        /// </summary>
        public int HomeIndividualId { get; set; }

        /// <summary>
        /// The owner of the tree (this Id can be used to associate trees with "users")
        /// An implementation system will manage the "owning" of a tree
        /// </summary>
        public int OwnerId { get; set; }
    }
}
