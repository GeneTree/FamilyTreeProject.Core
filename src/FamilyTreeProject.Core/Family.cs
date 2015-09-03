//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System.Collections.Generic;
using FamilyTreeProject.Common;

// ReSharper disable ConvertPropertyToExpressionBody

namespace FamilyTreeProject
{
    /// <summary>
    /// Family is a class that represents a family of ancestors
    /// </summary>
    public class Family : AncestorEntity
    {
        public Family() : base(-1) { }

        public Family(int treeId) : base(treeId) { }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this family's husband.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Husband { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's husband
        /// </summary>
        public int? HusbandId { get; set; }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this family's wife.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Wife { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's wife
        /// </summary>
        public int? WifeId { get; set; }
    }
}