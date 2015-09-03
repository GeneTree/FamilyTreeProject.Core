//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

// ReSharper disable ConvertPropertyToExpressionBody
namespace FamilyTreeProject.Common
{
    /// <summary>
    /// The BaseEntity class provides a base class for Family Tree Entities
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Constructs a Base Entity
        /// </summary>
        /// <param name="treeId">The Id of the Tree</param>
        protected BaseEntity(int treeId)
        {
            Id = 0;
            TreeId = treeId;
        }

        /// <summary>
        ///   Gets or sets the id of the individual
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This property indicates whether the entity is New
        /// </summary>
        public bool IsNew
        {
            get { return Id == 0; }
        }

        /// <summary>
        /// The Id of the Tree to which this entity belongs
        /// </summary>
        public int TreeId { get; set; }
    }
}
