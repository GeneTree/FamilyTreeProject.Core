//******************************************
//  Copyright (C) 2011-2013 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included License.txt file)        *
//                                         *
// *****************************************

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FamilyTreeProject
{
    public class Family
    {
        #region Constructors

        /// <summary>
        ///   Constructs an Family object
        /// </summary>
        public Family()
        {
            Children = new List<Individual>();
        }

        /// <summary>
        /// Constructs an Family object that is part of a specific Tree
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        public Family(int treeId)
            : this()
        {
            TreeId = treeId;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///   Gets or sets the Children of the Family.
        /// </summary>
        public IList<Individual> Children { get; set; }

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
        /// Gets or sets the Id of the Tree to which this family belongs
        /// </summary>
        public int TreeId { get; set; }

        /// <summary>
        ///   Gets or sets a reference to the <see cref = "Individual" /> object representing
        ///   this family's wife.
        ///   <seealso cref = "Individual" />
        /// </summary>
        public Individual Wife { get; set; }

        /// <summary>
        ///   Gets or sets the id of this family's wife
        /// </summary>
        [DataMember]
        public int? WifeId { get; set; }

        #endregion

        #region IIdentifiable Members

        /// <summary>
        ///   Gets or sets the id of the family
        /// </summary>
        public int Id { get; set; }

        public bool IsNew
        {
            get { return Id == 0; }
        }

        #endregion

    }
}