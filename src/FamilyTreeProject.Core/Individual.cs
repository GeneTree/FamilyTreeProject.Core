//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System;
using System.Collections.Generic;
using FamilyTreeProject.Common;

// ReSharper disable ConvertPropertyToExpressionBody

// ReSharper disable once CheckNamespace
namespace FamilyTreeProject
{
    /// <summary>
    ///   Represents an individual in a family tree
    /// </summary>
    public class Individual : AncestorEntity
    {
        public Individual() : this(string.Empty) { }

        public Individual(string treeId) : base(treeId)
        {
            ImageId = -1;
        }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this individual's father.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Father { get; set; }

        /// <summary>
        ///   Gets or sets the id of this individual's father
        /// </summary>
        public string FatherId { get; set; }

        /// <summary>
        ///   Gets or sets the first name of the individual
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Id of the image displayed on the main view
        /// </summary>
        public int ImageId { get; set; }

        /// <summary>
        ///   Gets or sets the last name of the individual
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this individual's mother.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Mother { get; set; }

        /// <summary>
        ///   Gets or sets the id of this individual's mother
        /// </summary>
        public string MotherId { get; set; }

        /// <summary>
        /// Gets or sets the name of this Individual
        /// </summary>
        public string Name
        {
            get { return String.Format("{0}, {1}", LastName, FirstName); }
        }

        /// <summary>
        ///   Gets or sets the Sex of this individual
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        ///   Gets or sets the Spouses of the Individual.
        /// </summary>
        public IList<Individual> Spouses { get; set; }

        /// <summary>
        /// Create a shallow copy of this individual
        /// </summary>
        /// <returns>An Individual</returns>
        public Individual Clone()
        {
            return new Individual
                        {
                            FatherId = FatherId,
                            FirstName = FirstName,
                            Id = Id,
                            ImageId = ImageId,
                            LastName = LastName,
                            MotherId = MotherId,
                            Sex = Sex,
                            TreeId = TreeId
                        }; 
        }
    }
}