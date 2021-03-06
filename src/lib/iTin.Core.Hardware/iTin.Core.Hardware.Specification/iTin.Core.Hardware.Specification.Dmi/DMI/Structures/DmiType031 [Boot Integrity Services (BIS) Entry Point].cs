﻿
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Boot Integrity Services (BIS) Entry Point (Type 31) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType031" />.
    /// </summary>
    internal sealed class DmiType031 : DmiBaseType<SmbiosType031>
    {
        #region constructor/s

        #region [public] DmiType031(SmbiosType031, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType031" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType031(SmbiosType031 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
        {
        }
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) PopulateProperties(DmiClassPropertiesTable): Populates the property collection for this structure
        /// <inheritdoc />
        /// <summary>
        /// Populates the property collection for this structure.
        /// </summary>
        /// <param name="properties">Collection of properties of this structure.</param>
        protected override void PopulateProperties(DmiClassPropertiesTable properties)
        {
            object checksum = SmbiosStructure.GetPropertyValue(SmbiosProperty.BootIntegrityServicesEntryPoint.Checksum);
            if (checksum != null)
            {
                properties.Add(DmiProperty.BootIntegrityServicesEntryPoint.Checksum, checksum);
            }

            object bisEntryPointAddress16 = SmbiosStructure.GetPropertyValue(SmbiosProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress16);
            if (bisEntryPointAddress16 != null)
            {
                properties.Add(DmiProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress16, bisEntryPointAddress16);
            }

            object bisEntryPointAddress32 = SmbiosStructure.GetPropertyValue(SmbiosProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress32);
            if (bisEntryPointAddress32 != null)
            {
                properties.Add(DmiProperty.BootIntegrityServicesEntryPoint.BisEntryPointAddress32, bisEntryPointAddress32);
            }
        }
        #endregion

        #endregion
    }
}
