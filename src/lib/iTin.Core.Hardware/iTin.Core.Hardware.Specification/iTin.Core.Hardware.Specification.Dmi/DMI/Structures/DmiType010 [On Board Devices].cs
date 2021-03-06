﻿
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the On Board Devices (Type 10, Obsolete) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType010" />.
    /// </summary>
    internal sealed class DmiType010 : DmiBaseType<SmbiosType010>
    {
        #region constructor/s

        #region [public] DmiType010(SmbiosType010, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiType010" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType010(SmbiosType010 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            object enabled = SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.Enabled);
            if (enabled != null)
            {
                properties.Add(DmiProperty.OnBoardDevices.Enabled, enabled);
            }

            object deviceType = SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.DeviceType);
            if (deviceType != null)
            {
                properties.Add(DmiProperty.OnBoardDevices.DeviceType, deviceType);
            }

            object description = SmbiosStructure.GetPropertyValue(SmbiosProperty.OnBoardDevices.Description);
            if (description != null)
            {
                properties.Add(DmiProperty.OnBoardDevices.Description, description);
            }
        }
        #endregion

        #endregion
    }
}
