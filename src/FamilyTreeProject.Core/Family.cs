//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using FamilyTreeProject.Common;

// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable once CheckNamespace
namespace FamilyTreeProject
{
    /// <summary>
    /// Family is a class that represents a family of ancestors
    /// </summary>
    public class Family : AncestorEntity
    {
        public Family() : base(string.Empty) { }

        public Family(string treeId) : base(treeId) { }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this family's husband.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Husband { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's husband
        /// </summary>
        public string HusbandId { get; set; }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this family's wife.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Wife { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's wife
        /// </summary>
        public string WifeId { get; set; }

        /// <summary>
        /// Create a shallow copy of this individual
        /// </summary>
        /// <returns>An Individual</returns>
        public Family Clone()
        {
            return new Family
            {
                HusbandId = HusbandId,
                Id = Id,
                WifeId = WifeId,
                TreeId = TreeId
            };
        }

    }
}