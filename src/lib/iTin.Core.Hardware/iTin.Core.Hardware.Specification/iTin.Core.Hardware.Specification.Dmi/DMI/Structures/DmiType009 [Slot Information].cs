﻿
namespace iTin.Core.Hardware.Specification.Dmi
{
    using Property;

    using Smbios;
    using Smbios.Property;

    /// <inheritdoc />
    /// <summary>
    /// Specialization of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiBaseType{T}" /> class that contains the logic to decode the Slot Information (Type 9) structure.
    /// For more information, please see <see cref="T:iTin.Core.Hardware.Specification.Smbios.SmbiosType009" />.
    /// </summary>
    internal sealed class DmiType009 : DmiBaseType<SmbiosType009>
    {
        #region constructor/s

        #region [public] DmiType009(SmbiosType009, int): Initializes a new instance of the class by specifying the structure information and the SMBIOS version
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:iTin.Core.Hardware.Specification.Dmi.SmbiosType009" /> class by specifying the structure information and the <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.
        /// </summary>
        /// <param name="smbiosStructure">Formatted structure information.</param>
        /// <param name="smbiosVersion">Current <see cref="T:iTin.Core.Hardware.Specification.SMBIOS" /> version.</param>
        public DmiType009(SmbiosType009 smbiosStructure, int smbiosVersion) : base(smbiosStructure, smbiosVersion)
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
            #region 2.0+
            if (SmbiosStructure.StructureInfo.Length >= 0x0c)
            {
                object slotDesignation = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.SlotDesignation);
                if (slotDesignation != null)
                {
                    properties.Add(DmiProperty.SystemSlots.SlotDesignation, slotDesignation);
                }

                object slotType = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.SlotType);
                if (slotType != null)
                {
                    properties.Add(DmiProperty.SystemSlots.SlotType, slotType);
                }

                object slotDataBusWidth = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.SlotDataBusWidth);
                if (slotDataBusWidth != null)
                {
                    properties.Add(DmiProperty.SystemSlots.SlotDataBusWidth, slotDataBusWidth);
                }

                object currentUsage = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.CurrentUsage);
                if (currentUsage != null)
                {
                    properties.Add(DmiProperty.SystemSlots.CurrentUsage, currentUsage);
                }

                object slotLength = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.SlotLength);
                if (slotLength != null)
                {
                    properties.Add(DmiProperty.SystemSlots.SlotLength, slotLength);
                }

                object slotId = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.SlotId);
                if (slotId != null)
                {
                    properties.Add(DmiProperty.SystemSlots.SlotId, slotId);
                }
            }
            #endregion

            #region 2.1+
            object characteristics = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.Characteristics);
            if (characteristics != null)
            {
                properties.Add(DmiProperty.SystemSlots.Characteristics, characteristics);
            }
            #endregion

            #region 2.6+
            if (SmbiosStructure.StructureInfo.Length >= 0x11)
            {
                object segmentBusFunction = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.SegmentBusFunction);
                if (segmentBusFunction != null)
                {
                    properties.Add(DmiProperty.SystemSlots.SegmentBusFunction, segmentBusFunction);
                }

                object busDeviceFunction = SmbiosStructure.GetPropertyValue(SmbiosProperty.SystemSlots.BusDeviceFunction);
                if (busDeviceFunction != null)
                {
                    properties.Add(DmiProperty.SystemSlots.BusDeviceFunction, busDeviceFunction);
                }
            }
            #endregion
        }
        #endregion

        #endregion
    }
}
