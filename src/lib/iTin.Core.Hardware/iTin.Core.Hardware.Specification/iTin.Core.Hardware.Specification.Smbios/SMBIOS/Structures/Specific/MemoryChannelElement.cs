﻿
namespace iTin.Core.Hardware.Specification.Smbios
{
    using System.Diagnostics;

    using Property;

    // Type 037: Memory Channel. Contained Devices.
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | Offset       Name            Length      Value       Description                                           |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 00h          Memory          BYTE        Varies      The channel load provided by the first Memory Device  |
    // |              Device                                  associated with this channel.                         |
    // |              Load                                    Note: Ver Load                                        |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•
    // | 01h          Memory          WORD        Varies      The structure handle that identifies the first Memory |
    // |              Device                                  Device associated with this channel.                  |
    // |              Handle                                  Note: Ver Handle                                      |
    // •————————————————————————————————————————————————————————————————————————————————————————————————————————————•

    /// <summary>
    /// This class represents an element of the structure <see cref="SmbiosType037" />.
    /// </summary>
    public class MemoryChannelElement : SpecificSmbiosBaseType
    {
        #region constructor/s

        #region [internal] MemoryChannelElement(byte[]): Initialize a new instance of the class specifying the structure information
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryChannelElement" /> class specifying the structure information.
        /// </summary>
        /// <param name="memoryContainedElementsArray">Untreated information of the current structure.</param>
        internal MemoryChannelElement(byte[] memoryContainedElementsArray) : base(memoryContainedElementsArray)
        {
        }
        #endregion

        #endregion

        #region private properties

        #region [private] (byte) Load: Gets a value that represents the 'Load' field
        /// <summary>
        ///  Gets a value that represents the '<c>Load</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private byte Load => GetByte(0x00);
        #endregion

        #region [private] (int) Handle: Gets a value that represents the 'Handle' field
        /// <summary>
        ///  Gets a value that represents the '<c>Handle</c>' field.
        /// </summary>
        /// <value>
        /// Value of the property.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private int Handle => GetWord(0x01);
        #endregion

        #endregion

        #region public override methods

        #region [public] {override} (string) ToString(): Devuelve una clase string que representa al objeto actual.
        /// <summary>
        /// Returns a class <see cref="T: System.String" /> that represents the current object.
        /// </summary>
        /// <returns>
        /// Object <see cref="T:System.String" /> that represents the current <see cref = "T:iTin.Core.Hardware.Specification.Smbios.MemoryChannelElement"/> class.
        /// </returns>
        /// <remarks>
        /// This method returns a string that includes the property <see cref = "P:iTin.Core.Hardware.Specification.Smbios.MemoryChannelElement.Load" /> and
        /// <see cref = "P:iTin.Core.Hardware.Specification.Smbios.ChassisContainedElement.ItemType" />.
        /// </remarks>                                    
        public override string ToString() => $"Load = {Load}, Handle = {Handle}";
        #endregion

        #endregion

        #region private methods

        #region [protected] {override} (void) PopulateProperties(SmbiosPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(SmbiosPropertiesTable properties)
        {
            properties.Add(SmbiosProperty.MemoryChannel.MemoryDevices.Load, Load);
            properties.Add(SmbiosProperty.MemoryChannel.MemoryDevices.Handle, Handle);
        }
        #endregion
            
        #endregion
    }
}
