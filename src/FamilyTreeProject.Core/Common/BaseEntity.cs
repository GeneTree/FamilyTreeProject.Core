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
    public abstract class BaseEntity
    {
        protected BaseEntity(int treeId)
        {
            Id = 0;
            TreeId = treeId;
        }

        /// <summary>
        ///   Gets or sets the id of the individual
        /// </summary>
        public int Id { get; set; }

        public bool IsNew
        {
            get { return Id == 0; }
        }

        public int TreeId { get; set; }
    }
}
