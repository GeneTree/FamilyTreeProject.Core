//******************************************
//  Copyright (C) 2011-2013 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included License.txt file)        *
//                                         *
// *****************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using FamilyTreeProject.Common;

namespace FamilyTreeProject
{
    /// <summary>
    ///   Represents an individual in a family tree
    /// </summary>
    public class Individual
    {
        #region Private Members

        private const string BaptismFormatString = "Bapt: {0}";
        private const string BirthFormatString = "Born: {0}";
        private const string BuriedFormatString = "Bur: {0}";
        private const string DeathFormatString = "Died: {0}";

        #endregion

        #region Constructors

        public Individual()
        {
            Events = new List<Event>();
            Notes = new List<Note>();
        }

        public Individual(int treeId)
            : this()
        {
            TreeId = treeId;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///   Gets or sets the Children of the Individual.
        /// </summary>
        public IList<Individual> Children { get; set; }

        public IList<Event> Events { get; set; }

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

        public string Name
        {
            get { return String.Format("{0}, {1}", LastName, FirstName); }
        }

        public IList<Note> Notes { get; set; }

        /// <summary>
        ///   Gets or sets the Sex of this individual
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        ///   Gets or sets the Spouses of the Individual.
        /// </summary>
        public IList<Individual> Spouses { get; set; }

        public int TreeId { get; set; }

        #endregion

        public string BirthDate
        {
            get
            {
                string date = String.Empty;
                var birthdate = (from IndividualEvent e in Events
                                 where e.EventType == IndividualEventType.Birth
                                 select e).SingleOrDefault();
                if (birthdate == null)
                {
                    var baptdate = (from IndividualEvent e in Events
                                    where e.EventType == IndividualEventType.Baptism
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

        public string DeathDate
        {
            get
            {
                string date = String.Empty;
                var deathdate = (from IndividualEvent e in Events
                                 where e.EventType == IndividualEventType.Death
                                 select e).SingleOrDefault();
                if (deathdate == null)
                {
                    var burialdate = (from IndividualEvent e in Events
                                      where e.EventType == IndividualEventType.Burial
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

        #region IIdentifiable Members

        /// <summary>
        ///   Gets or sets the id of the individual
        /// </summary>
        public int Id { get; set; }

        public bool IsNew
        {
            get { return Id == 0; }
        }

        #endregion

    }
}