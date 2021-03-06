﻿
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// Represents a collection of objects <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosStructure" /> available on a motherboard.
    /// </summary>
    public sealed class BaseBoardContainedElementCollection : ReadOnlyCollection<SmbiosStructure>
    {
        #region constructor/s

        #region [internal] BaseBoardContainedElementCollection(IEnumerable<SmbiosStructure>): Initialize a new instance of the class
        /// <inheritdoc />
        /// <summary>
        /// Initialize a new instance of the class <see cref="T:iTin.Core.Hardware.Specification.Smbios.BaseBoardContainedElementCollection" />.
        /// </summary>
        /// <param name="elements">Item list.</param>
        internal BaseBoardContainedElementCollection(IEnumerable<SmbiosStructure> elements) : base(elements.ToList())
        {
        }
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Returns a class String that represents the current object
        /// <summary>
        /// Returns a class <see cref="T: System.String" /> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.String" /> that represents the current <see cref = "T:iTin.Core.Hardware.Specification.Smbios.AdditionalInformationEntryCollection"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the number of available items.
        /// </remarks>                                    
        public override string ToString() => $"Elements = {Items.Count}";
        #endregion

        #endregion              
    }
}
