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
    /// Represents the Mars Rover Controller entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RoverController : EntityBase, IEquatable<RoverController>
    {
        #region Privates

        private Plateau _plateau;
        private RoverPosition _position;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the The Plateu where the rover is located.
        /// </summary>
        [JsonProperty("plateau", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Plateau")]
        public Plateau Plateau
        {
            get => _plateau;
            set => SetValue(ref _plateau, value, false, true, nameof(Plateau));
        }

        /// <summary>
        /// Gets or sets the Position (see <see cref="Business.Entities.RoverPosition"/>).
        /// </summary>
        [JsonProperty("position", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Position")]
        public RoverPosition Position
        {
            get => _position;
            set => SetValue(ref _position, value, false, true, nameof(Position));
        }

        #endregion

        #region IChangeTracking

        /// <summary>
        /// Resets the entity state to unchanged by accepting the changes (resets <see cref="EntityBase.ChangeTracking"/>).
        /// </summary>
        /// <remarks>Ends and commits the entity changes (see <see cref="EntityBase.EndEdit"/>).</remarks>
        public override void AcceptChanges()
        {
            Plateau?.AcceptChanges();
            Position?.AcceptChanges();
            base.AcceptChanges();
        }

        /// <summary>
        /// Determines that until <see cref="AcceptChanges"/> is invoked property changes are to be logged (see <see cref="EntityBase.ChangeTracking"/>).
        /// </summary>
        public override void TrackChanges()
        {
            Plateau?.TrackChanges();
            Position?.TrackChanges();
            base.TrackChanges();
        }

        #endregion

        #region IEquatable

        /// <summary>
        /// Determines whether the specified object is equal to the current object by comparing the values of all the properties.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified object is equal to the current object; otherwise, <c>false</c>.</returns>
        public override bool Equals(object? obj) => obj is RoverController val && Equals(val);

        /// <summary>
        /// Determines whether the specified <see cref="RoverController"/> is equal to the current <see cref="RoverController"/> by comparing the values of all the properties.
        /// </summary>
        /// <param name="value">The <see cref="RoverController"/> to compare with the current <see cref="RoverController"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="RoverController"/> is equal to the current <see cref="RoverController"/>; otherwise, <c>false</c>.</returns>
        public bool Equals(RoverController? value)
        {
            if (value == null)
                return false;
            else if (ReferenceEquals(value, this))
                return true;

            return base.Equals((object)value)
                && Equals(Plateau, value.Plateau)
                && Equals(Position, value.Position);
        }

        /// <summary>
        /// Compares two <see cref="RoverController"/> types for equality.
        /// </summary>
        /// <param name="a"><see cref="RoverController"/> A.</param>
        /// <param name="b"><see cref="RoverController"/> B.</param>
        /// <returns><c>true</c> indicates equal; otherwise, <c>false</c> for not equal.</returns>
        public static bool operator == (RoverController? a, RoverController? b) => Equals(a, b);

        /// <summary>
        /// Compares two <see cref="RoverController"/> types for non-equality.
        /// </summary>
        /// <param name="a"><see cref="RoverController"/> A.</param>
        /// <param name="b"><see cref="RoverController"/> B.</param>
        /// <returns><c>true</c> indicates not equal; otherwise, <c>false</c> for equal.</returns>
        public static bool operator != (RoverController? a, RoverController? b) => !Equals(a, b);

        /// <summary>
        /// Returns the hash code for the <see cref="RoverController"/>.
        /// </summary>
        /// <returns>The hash code for the <see cref="RoverController"/>.</returns>
        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(Plateau);
            hash.Add(Position);
            return base.GetHashCode() ^ hash.ToHashCode();
        }
    
        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="RoverController"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="RoverController"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<RoverController>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="RoverController"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="RoverController"/> to copy from.</param>
        public void CopyFrom(RoverController from)
        {
            if (from == null)
                throw new ArgumentNullException(nameof(from));

            CopyFrom((EntityBase)from);
            Plateau = CopyOrClone(from.Plateau, Plateau);
            Position = CopyOrClone(from.Position, Position);

            OnAfterCopyFrom(from);
        }

        #endregion

        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="RoverController"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="RoverController"/>.</returns>
        public override object Clone()
        {
            var clone = new RoverController();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="RoverController"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            Plateau = Cleaner.Clean(Plateau);
            Position = Cleaner.Clean(Position);

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
                return Cleaner.IsInitial(Plateau)
                    && Cleaner.IsInitial(Position);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(RoverController from);

        #endregion
    }
}

#pragma warning restore
#nullable restore