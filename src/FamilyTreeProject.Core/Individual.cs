//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System;
using System.Collections.Generic;
using System.Linq;
using FamilyTreeProject.Common;
// ReSharper disable ConvertPropertyToExpressionBody

namespace FamilyTreeProject
{
    /// <summary>
    ///   Represents an individual in a family tree
    /// </summary>
    public class Individual : AncestorEntity
    {
        private const string BaptismFormatString = "Bapt: {0}";
        private const string BirthFormatString = "Born: {0}";
        private const string BuriedFormatString = "Bur: {0}";
        private const string DeathFormatString = "Died: {0}";

        public Individual() : base(-1) { }

        public Individual(int treeId) : base(treeId) { }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this individual's father.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Father { get; set; }

        /// <summary>
        ///   Gets or sets the id of this individual's father
        /// </summary>
        public int? FatherId { get; set; }

        /// <summary>
        ///   Gets or sets the first name of the individual
        /// </summary>
        public string FirstName { get; set; }

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
        public int? MotherId { get; set; }

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
        /// Gets the Birthdate of this individual
        /// </summary>
        public string BirthDate
        {
            get
            {
                string date = String.Empty;
                var birthdate = (from Fact e in Facts
                                 where e.FactType == FactType.Birth
                                 select e).SingleOrDefault();
                if (birthdate == null)
                {
                    var baptdate = (from Fact e in Facts
                                    where e.FactType == FactType.Baptism
                                    select e).SingleOrDefault();
                    if (baptdate != null)
                    {
                        date = String.Format(BaptismFormatString, baptdate.Date);
                    }
                }
                else
                {
                    date = String.Format(BirthFormatString, birthdate.Date);
                }

                return date;
            }
        }

        /// <summary>
        /// Gets the DeathDate of this individual
        /// </summary>
        public string DeathDate
        {
            get
            {
                string date = String.Empty;
                var deathdate = (from Fact e in Facts
                                 where e.FactType == FactType.Death
                                 select e).SingleOrDefault();
                if (deathdate == null)
                {
                    var burialdate = (from Fact e in Facts
                                      where e.FactType == FactType.Burial
                                      select e).SingleOrDefault();
                    if (burialdate != null)
                    {
                        date = String.Format(BuriedFormatString, burialdate.Date);
                    }
                }
                else
                {
                    date = String.Format(DeathFormatString, deathdate.Date);
                }

                return date;
            }
        }

        public Individual Clone()
        {
            return new Individual
                        {
                            FatherId = FatherId,
                            FirstName = FirstName,
                            Id = Id,
                            LastName = LastName,
                            MotherId = MotherId,
                            Sex = Sex,
                            TreeId = TreeId
                        }; 
        }
    }
}