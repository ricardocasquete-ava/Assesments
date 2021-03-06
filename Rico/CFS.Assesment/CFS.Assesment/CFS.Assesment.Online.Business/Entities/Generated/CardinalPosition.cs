/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable
#pragma warning disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = CFS.Assesment.Online.Business.Entities;

namespace CFS.Assesment.Online.Business.Entities
{
    /// <summary>
    /// Represents the Cardinal Position entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [ReferenceDataInterface(typeof(IReferenceData))]
    public partial class CardinalPosition : ReferenceDataBaseInt32
    {
        #region Operator

        /// <summary>
        /// An implicit cast from an <b>Id</b> to a <see cref="CardinalPosition"/>.
        /// </summary>
        /// <param name="id">The <b>Id</b>.</param>
        /// <returns>The corresponding <see cref="CardinalPosition"/>.</returns>
        public static implicit operator CardinalPosition(int id) => ConvertFromId<CardinalPosition>(id);

        /// <summary>
        /// An implicit cast from a <b>Code</b> to a <see cref="CardinalPosition"/>.
        /// </summary>
        /// <param name="code">The <b>Code</b>.</param>
        /// <returns>The corresponding <see cref="CardinalPosition"/>.</returns>
        public static implicit operator CardinalPosition(string? code) => ConvertFromCode<CardinalPosition>(code);

        #endregion
    
        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="CardinalPosition"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="CardinalPosition"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<CardinalPosition>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="CardinalPosition"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="CardinalPosition"/> to copy from.</param>
        public void CopyFrom(CardinalPosition from)
        {
            if (from == null)
                throw new ArgumentNullException(nameof(from));

            CopyFrom((ReferenceDataBaseInt32)from);

            OnAfterCopyFrom(from);
        }

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="CardinalPosition"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="CardinalPosition"/>.</returns>
        public override object Clone()
        {
            var clone = new CardinalPosition();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="CardinalPosition"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();

            OnAfterCleanUp();
        }

        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                if (!base.IsInitial)
                    return false;

                return true;
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(CardinalPosition from);

        #endregion
    }

    #region Collection

    /// <summary>
    /// Represents the <see cref="CardinalPosition"/> collection.
    /// </summary>
    public partial class CardinalPositionCollection : ReferenceDataCollectionBase<CardinalPosition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalPositionCollection"/> class.
        /// </summary>
        public CardinalPositionCollection() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardinalPositionCollection"/> class with an entities range.
        /// </summary>
        /// <param name="entities">The <see cref="CardinalPosition"/> entities.</param>
        public CardinalPositionCollection(IEnumerable<CardinalPosition> entities) => AddRange(entities);
    }

    #endregion  
}

#pragma warning restore
#nullable restore