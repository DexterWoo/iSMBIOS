﻿
namespace iTin.Core.Hardware.Specification.Dmi.Property
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Defines available keys for the available devices of a system.
    /// </summary>
    public static partial class DmiProperty
    {
        #region [public] {static} (class) Bios: Contains the key definitions available for a type 000 [Bios Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 000 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.Bios" /> Information] structure.
        /// </summary>
        public static class Bios
        {
            #region [public] {static} (IPropertyKey) Vendor: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>BIOS Vendor’s Name.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.Vendor" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Vendor => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.Vendor);
            #endregion

            #region [public] {static} (IPropertyKey) BiosVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>BIOS Version.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.BiosVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BiosVersion => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosVersion);
            #endregion

            #region [public] {static} (IPropertyKey) BiosStartSegment: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Segment location of BIOS starting address.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.BiosStartSegment" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BiosStartSegment => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosStartSegment);
            #endregion

            #region [public] {static} (IPropertyKey) BiosReleaseDate: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>BIOS release date.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.BiosReleaseDate" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BiosReleaseDate => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosReleaseDate);
            #endregion

            #region [public] {static} (IPropertyKey) BiosRomSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the physical device containing the BIOS. For check measured unit, please see <see cref="BiosRomSizeUnit" />.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.BiosRomSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey BiosRomSize => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosRomSize, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Defines which functions the BIOS supports: <c>PCI</c>, <c>PCMCIA</c>, <c>Flash</c>, etc.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.Characteristics" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.Characteristics);
            #endregion

            #region [public] {static} (IPropertyKey) CharacteristicsExtensionByte1: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>BIOS characteristics byte 1 supports: <c>ACPI</c>, <c>USB</c>, <c>ATAPI ZIP</c>, etc.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.CharacteristicsExtensionByte1" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey CharacteristicsExtensionByte1 => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.CharacteristicsExtensionByte1);
            #endregion

            #region [public] {static} (IPropertyKey) CharacteristicsExtensionByte2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>BIOS characteristics byte 2 supports: <c>BIOS Boot Specification</c>, <c>UEFI</c>, etc.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.CharacteristicsExtensionByte2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey CharacteristicsExtensionByte2 => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.CharacteristicsExtensionByte2);
            #endregion

            #region [public] {static} (IPropertyKey) SystemBiosMajorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Major release of the System BIOS.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.SystemBiosMajorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            public static IPropertyKey SystemBiosMajorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.SystemBiosMajorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) SystemBiosMinorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Minor release of the System BIOS.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.SystemBiosMinorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            public static IPropertyKey SystemBiosMinorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.SystemBiosMinorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareMajorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Identifies the major release of the embedded controller firmware.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.FirmwareMajorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            public static IPropertyKey FirmwareMajorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.FirmwareMajorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareMinorRelease: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Identifies the minor release of the embedded controller firmware.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.FirmwareMinorRelease" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            public static IPropertyKey FirmwareMinorRelease => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.FirmwareMinorRelease);
            #endregion

            #region [public] {static} (IPropertyKey) BiosRomSizeUnit: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Size of the physical device(s) containing the BIOS.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Bios" /></para>
            /// <para>Property: <see cref="DmiType000Property.BiosRomSizeUnit" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="MemorySizeUnit" /></para>
            /// </summary>
            public static IPropertyKey BiosRomSizeUnit => new PropertyKey(DmiStructureClass.Bios, DmiType000Property.BiosRomSizeUnit);
            #endregion
        }
        #endregion

        #region [public] {static} (class) System: Contains the key definitions available for a type 001 [System Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 001 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.System" /> Information] structure.
        /// </summary>
        public static class System
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>System Manufacturer.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.System, DmiType001Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) ProductName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Product Name.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.ProductName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ProductName => new PropertyKey(DmiStructureClass.System, DmiType001Property.ProductName);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Product Version.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.Version" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(DmiStructureClass.System, DmiType001Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Product Serial Number.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.System, DmiType001Property.SerialNumber);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) UUID: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Universal unique ID number (UUID).</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.UUID" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey UUID => new PropertyKey(DmiStructureClass.System, DmiType001Property.UUID);
            #endregion

            #region [public] {static} (IPropertyKey) WakeUpType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Identifies the event that caused the system to power up.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.WakeUpType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey WakeUpType => new PropertyKey(DmiStructureClass.System, DmiType001Property.WakeUpType);
            #endregion

            #endregion

            #region version 2.4+

            #region [public] {static} (IPropertyKey) SkuNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>This text string identifies a particular computer configuration for sale.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.SkuNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SkuNumber => new PropertyKey(DmiStructureClass.System, DmiType001Property.SkuNumber);
            #endregion

            #region [public] {static} (IPropertyKey) Family: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>This text string identifies the family to which a particular computer belongs.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.System" /></para>
            /// <para>Property: <see cref="DmiType001Property.Family" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Family => new PropertyKey(DmiStructureClass.System, DmiType001Property.Family);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BaseBoard: Contains the key definitions available for a type 002 [Baseboard (or Module) Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 002 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.BaseBoard" /> (or Module) Information] structure.
        /// </summary>
        public static class BaseBoard
        {
            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Manufacturer.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) Product: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Name.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.Product" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Product => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.Product);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Version.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.Version" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Serial Number.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Asset Tag.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.AssetTag" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) LocationInChassis: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String that describes this board's location.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.LocationInChassis" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey LocationInChassis => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.LocationInChassis);
            #endregion

            #region [public] {static} (IPropertyKey) ChassisHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Handle, or instance number, associated with the chassis in which this board resides.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.ChassisHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ChassisHandle => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.ChassisHandle);
            #endregion

            #region [public] {static} (IPropertyKey) BoardType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Type.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.BoardType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BoardType => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.BoardType);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfContainedObjectHandles: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Number (0 to 255) of contained Object Handles that follow.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.NumberOfContainedObjectHandles" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey NumberOfContainedObjectHandles => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.NumberOfContainedObjectHandles);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>List of handles of other structures (for examples, Baseboard, Processor, Port, System Slots, Memory Device) that are contained by this baseboard.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
            /// <para>Property: <see cref="DmiType002Property.ContainedObjectHandles" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="BaseBoardContainedElementCollection" /></para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.ContainedObjectHandles);
            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Features' section
            /// <summary>
            /// Contains the key definition for the <b>Features</b> section.
            /// </summary>
            public static class Features
            {
                #region [public] {static} (IPropertyKey) IsHostingBoard: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Indicates if is hosting board.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
                /// <para>Property: <see cref="DmiType002Property.IsHostingBoard" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsHostingBoard => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.IsHostingBoard);
                #endregion

                #region [public] {static} (IPropertyKey) IsHotSwappable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Indicates if mainboard is hot swappable.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
                /// <para>Property: <see cref="DmiType002Property.IsHostingBoard" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsHotSwappable => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.HotSwappable);
                #endregion

                #region [public] {static} (IPropertyKey) IsRemovable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Indicates if mainboard is removable.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
                /// <para>Property: <see cref="DmiType002Property.IsRemovable" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsRemovable => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.IsRemovable);
                #endregion

                #region [public] {static} (IPropertyKey) IsReplaceable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Indicates if mainboard is replaceable.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
                /// <para>Property: <see cref="DmiType002Property.IsReplaceable" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsReplaceable => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.IsReplaceable);
                #endregion

                #region [public] {static} (IPropertyKey) RequiredDaughterBoard: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Indicates if mainboard required a daughter board.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.BaseBoard" /></para>
                /// <para>Property: <see cref="DmiType002Property.RequiredDaughterBoard" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey RequiredDaughterBoard => new PropertyKey(DmiStructureClass.BaseBoard, DmiType002Property.RequiredDaughterBoard);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Chassis: Contains the key definitions available for a type 003 [System Enclosure or Chassis] structure
        /// <summary>
        /// Contains the key definitions available for a type 003 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemEnclosure" /> Information] structure.
        /// </summary>
        public static class Chassis
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Mainboard Manufacturer.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) Locked: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Indicates if chassis lock is present.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.Locked" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Locked => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Locked);
            #endregion

            #region [public] {static} (IPropertyKey) ChassisType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Chassis Type.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.ChassisType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ChassisType => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ChassisType);
            #endregion

            #region [public] {static} (IPropertyKey) Version: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Chassis Version.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.Version" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Version => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Version);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Chassis Serial Number.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Asset Tag Number.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.AssetTagNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey AssetTagNumber => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.AssetTagNumber);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) BootUpState: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>State of the enclosure when it was last booted.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.BootUpState" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BootUpState => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.BootUpState);
            #endregion

            #region [public] {static} (IPropertyKey) PowerSupplyState: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>State of the enclosure’s power supply (or supplies) when last booted.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.PowerSupplyState" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey PowerSupplyState => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.PowerSupplyState);
            #endregion

            #region [public] {static} (IPropertyKey) ThermalState: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Thermal state of the enclosure when last booted.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.ThermalState" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ThermalState => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ThermalState);
            #endregion

            #region [public] {static} (IPropertyKey) SecurityStatus: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Physical security status of the enclosure when last booted.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.SecurityStatus" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SecurityStatus => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.SecurityStatus);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>OEM or BIOS vendor-specific information.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" />?</para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) Height: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Height of the enclosure, in 'U's  A U is a standard unit of measure for the height of a rack or rack-mountable 
            /// component and is equal to 1.75 inches or 4.445 cm. A value of 00h indicates that the enclosure height is unspecified.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.Height" /></para>
            /// <para>Unit: <see cref="PropertyUnit.U" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            public static IPropertyKey Height => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.Height, PropertyUnit.U);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfPowerCords: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Number of power cords associated with the enclosure or chassis.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.NumberOfPowerCords" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" />?</para>
            /// </summary>
            public static IPropertyKey NumberOfPowerCords => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.NumberOfPowerCords);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>Number of contained Element records that follow, in the range 0 to 255.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.ContainedElements" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="DmiChassisContainedElementCollection" /></para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedElements);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) SkuNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>String describing the chassis or enclosure SKU number.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
            /// <para>Property: <see cref="DmiType003Property.SkuNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SkuNumber => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.SkuNumber);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Elements: Contains the key definition for the 'Elements' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Elements
            {
                #region [public] {static} (IPropertyKey) ItemType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Type of element associated.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
                /// <para>Property: <see cref="DmiType003Property.ChassisType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey ItemType => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedType);
                #endregion

                #region [public] {static} (IPropertyKey) Min: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Specifies the minimum number of the element type that can be installed in the chassis for the chassis to properly operate, in the range 0 to 254.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
                /// <para>Property: <see cref="DmiType003Property.ContainedElementMinimum" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey Min => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedElementMinimum);
                #endregion

                #region [public] {static} (IPropertyKey) Max: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Specifies the maximum number of the element type that can be installed in the chassis, in the range 1 to 255.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
                /// <para>Property: <see cref="DmiType003Property.ContainedElementMaximun" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey Max => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedElementMaximun);
                #endregion

                #region [public] {static} (IPropertyKey) TypeSelect: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>Type of select element associated.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemEnclosure" /></para>
                /// <para>Property: <see cref="DmiType003Property.ContainedTypeSelect" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="ChassisContainedElementType" /></para>
                /// </summary>
                public static IPropertyKey TypeSelect => new PropertyKey(DmiStructureClass.SystemEnclosure, DmiType003Property.ContainedTypeSelect);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) Processor: Contains the key definitions available for a type 004 [Processor Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 004 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.Processor" /> Information] structure.
        /// </summary>
        public static class Processor
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.SocketDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ProcessorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ProcessorType => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorType);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorFamily: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ProcessorFamily" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Family => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorFamily);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorManufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ProcessorManufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ProcessorManufacturer => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorManufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ProcessorId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ProcessorId => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorId);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ProcessorVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ProcessorVersion => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorVersion);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalClock: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ExternalClock" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            public static IPropertyKey ExternalClock => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ExternalClock, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.MaximunSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey MaximunSpeed => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.MaximunSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.CurrentSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey CurrentSpeed => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CurrentSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) ProcessorUpgrade: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ProcessorUpgrade" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey UpgradeMethod => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ProcessorUpgrade);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) L1CacheHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.L1CacheHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey L1CacheHandle => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.L1CacheHandle);
            #endregion

            #region [public] {static} (IPropertyKey) L2CacheHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.L2CacheHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey L2CacheHandle => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.L2CacheHandle);
            #endregion

            #region [public] {static} (IPropertyKey) L3CacheHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.L3CacheHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey L3CacheHandle => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.L3CacheHandle);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.AssetTag" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) PartNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.PartNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey PartNumber => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.PartNumber);
            #endregion

            #endregion

            #region version 2.5+

            #region [public] {static} (IPropertyKey) CoreCount: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.CoreCount" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey CoreCount => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreCount);
            #endregion

            #region [public] {static} (IPropertyKey) CoreEnabled: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.CoreEnabled" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey CoreEnabled => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreEnabled);
            #endregion

            #region [public] {static} (IPropertyKey) ThreadCount: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ThreadCount" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.Int32" />?</para>
            /// </summary>
            public static IPropertyKey ThreadCount => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ThreadCount);
            #endregion

            #endregion

            #region version 3.0+

            #region [public] {static} (IPropertyKey) CoreCount2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.CoreCount2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt32" />?</para>
            /// </summary>
            public static IPropertyKey CoreCount2 => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreCount2);
            #endregion

            #region [public] {static} (IPropertyKey) CoreEnabled2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.CoreEnabled2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt32" />?</para>
            /// </summary>
            public static IPropertyKey CoreEnabled2 => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CoreEnabled2);
            #endregion

            #region [public] {static} (IPropertyKey) ThreadCount2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition ——————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
            /// <para>Property: <see cref="DmiType004Property.ThreadCount2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.UInt32" />?</para>
            /// </summary>
            public static IPropertyKey ThreadCount2 => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ThreadCount2);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) Features: Contains the key definition for the 'Characteristics' section
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
                #region [public] {static} (IPropertyKey) Capable64Bits: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.Capable64Bits" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" />?</para>
                /// </summary>
                public static IPropertyKey Capable64Bits => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.Capable64Bits);
                #endregion

                #region [public] {static} (IPropertyKey) EnhancedVirtualizationInstructions: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.EnhancedVirtualizationInstructions" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" />?</para>
                /// </summary>
                public static IPropertyKey EnhancedVirtualizationInstructions => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.EnhancedVirtualizationInstructions);
                #endregion

                #region [public] {static} (IPropertyKey) ExecuteProtectionSupport: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.ExecuteProtectionSupport" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" />?</para>
                /// </summary>
                public static IPropertyKey ExecuteProtectionSupport => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.ExecuteProtectionSupport);
                #endregion

                #region [public] {static} (IPropertyKey) MultiCore: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.MultiCore" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" />?</para>
                /// </summary>
                public static IPropertyKey MultiCore => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.MultiCore);
                #endregion

                #region [public] {static} (IPropertyKey) HardwareThreadPerCore: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.HardwareThreadPerCore" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" />?</para>
                /// </summary>
                public static IPropertyKey HardwareThreadPerCore => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.HardwareThreadPerCore);
                #endregion

                #region [public] {static} (IPropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.PowerPerformanceControlSupport" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" />?</para>
                /// </summary>
                public static IPropertyKey PowerPerformanceControlSupport => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.PowerPerformanceControlSupport);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Status: Contains the key definition for the 'Status' section
            /// <summary>
            /// Contains the key definition for the <b>Status</b> section.
            /// </summary>
            public static class Status
            {
                #region [public] {static} (IPropertyKey) PowerPerformanceControlSupport: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.CpuStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey CpuStatus => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.CpuStatus);
                #endregion

                #region [public] {static} (IPropertyKey) SocketPopulated: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.SocketPopulated" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey SocketPopulated => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.SocketPopulated);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Voltage: Contains the key definition for the 'Voltage' section
            /// <summary>
            /// Contains the key definition for the <b>Voltage</b> section.
            /// </summary>
            public static class Voltage
            {
                #region [public] {static} (IPropertyKey) SocketPopulated: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.IsLegacyMode" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsLegacyMode => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.IsLegacyMode);
                #endregion

                #region [public] {static} (IPropertyKey) VoltageCapability: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition ——————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Processor" /></para>
                /// <para>Property: <see cref="DmiType004Property.VoltageCapability" /></para>
                /// <para>Unit: <see cref="PropertyUnit.V" /></para>
                /// <para>— Return Value ———————————————— </para>
                /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
                /// </summary>
                public static IPropertyKey SupportedVoltages => new PropertyKey(DmiStructureClass.Processor, DmiType004Property.VoltageCapability, PropertyUnit.V);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryController: Contains the key definitions available for a type 005, obsolete [Memory Controller Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 005, obsolete [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.MemoryController" /> Information] structure.
        /// </summary>
        public static class MemoryController
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) ErrorDetectingMethod: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.ErrorDetectingMethod" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorDetectingMethod => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.ErrorDetectingMethod);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorDetectingMethod: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.ErrorCorrectingCapabilities" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorCorrectingCapabilities => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.ErrorCorrectingCapabilities);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedInterleave: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.SupportedInterleave" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SupportedInterleave => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.SupportedInterleave);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentInterleave: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.CurrentInterleave" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey CurrentInterleave => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.CurrentInterleave);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumMemoryModuleSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.MaximumMemoryModuleSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximumMemoryModuleSize => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.MaximumMemoryModuleSize);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedSpeeds: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.SupportedSpeeds" /></para>
            /// <para>Unit: <see cref="PropertyUnit.ns" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey SupportedSpeeds => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.SupportedSpeeds, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedMemoryTypes: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.SupportedMemoryTypes" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey SupportedMemoryTypes => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.SupportedMemoryTypes);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryModuleVoltages: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.MemoryModuleVoltages" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey MemoryModuleVoltages => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.MemoryModuleVoltages, PropertyUnit.V);
            #endregion

            #region [public] {static} (IPropertyKey) NumberMemorySlots: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.NumberMemorySlots" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey NumberMemorySlots => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.NumberMemorySlots);
            #endregion

            #region [public] {static} (IPropertyKey) ContainedMemoryModules: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.ContainedMemoryModules" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="DmiMemoryControllerContainedElementCollection" /></para>
            /// </summary>
            public static IPropertyKey ContainedMemoryModules => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.ContainedMemoryModules, PropertyUnit.None);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) EnabledErrorCorrectingCapabilities: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryController" /></para>
            /// <para>Property: <see cref="DmiType005Property.EnabledErrorCorrectingCapabilities" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Return Value ———————————————— </para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey EnabledErrorCorrectingCapabilities => new PropertyKey(DmiStructureClass.MemoryController, DmiType005Property.EnabledErrorCorrectingCapabilities);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryModule: Contains the key definitions available for a type 006, obsolete [Memory Module Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 006, obsolete [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.MemoryModule" /> Information] structure.
        /// </summary>
        public static class MemoryModule
        {
            #region [public] {static} (IPropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.SocketDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) BankConnections: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.BankConnections" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey BankConnections => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.BankConnections);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.CurrentSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey CurrentSpeed => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.CurrentSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentMemoryType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.CurrentMemoryType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey CurrentMemoryType => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.CurrentMemoryType);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.InstalledSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey InstalledSize => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.InstalledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (IPropertyKey) EnabledSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.EnabledSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{String}" /></para>
            /// </summary>
            public static IPropertyKey EnabledSize => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.EnabledSize, PropertyUnit.MB);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorStatus: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryModule" /></para>
            /// <para>Property: <see cref="DmiType006Property.ErrorStatus" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorStatus => new PropertyKey(DmiStructureClass.MemoryModule, DmiType006Property.ErrorStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Cache: Contains the key definitions available for a type 007 [Cache Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 007 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.Cache" /> Information] structure.
        /// </summary>
        public static class Cache
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) SocketDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.SocketDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SocketDesignation => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.SocketDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumCacheSize2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.MaximumCacheSize2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt32" /></para>
            /// </summary>
            public static IPropertyKey MaximumCacheSize2 => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.MaximumCacheSize2, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledCacheSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.InstalledCacheSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey InstalledCacheSize => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.InstalledCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) SupportedSramTypes: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.SupportedSramTypes" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey SupportedSramTypes => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.SupportedSramTypes);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentSramType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.CurrentSramType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey CurrentSramType => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CurrentSramType);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) CacheSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.CacheSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.ns" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey CacheSpeed => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheSpeed, PropertyUnit.ns);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorCorrectionType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.ErrorCorrectionType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorCorrectionType => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.ErrorCorrectionType);
            #endregion

            #region [public] {static} (IPropertyKey) SystemCacheType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.SystemCacheType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SystemCacheType => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.SystemCacheType);
            #endregion

            #region [public] {static} (IPropertyKey) Associativity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.Associativity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            public static IPropertyKey Associativity => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.Associativity);
            #endregion

            #endregion

            #region version 3.1+

            #region [public] {static} (IPropertyKey) MaximumCacheSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.MaximumCacheSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximumCacheSize => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.MaximumCacheSize, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) InstalledCacheSize2: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
            /// <para>Property: <see cref="DmiType007Property.InstalledCacheSize2" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt32" /></para>
            /// </summary>
            public static IPropertyKey InstalledCacheSize2 => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.InstalledCacheSize2, PropertyUnit.KB);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) CacheConfiguration: Contains the key definition for the 'CacheConfiguration' section
            /// <summary>
            /// Contains the key definition for the <b>CacheConfiguration</b> section.
            /// </summary>
            public static class CacheConfiguration
            {
                #region [public] {static} (IPropertyKey) CacheEnabled: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
                /// <para>Property: <see cref="DmiType007Property.CacheEnabled" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey CacheEnabled => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheEnabled);
                #endregion

                #region [public] {static} (IPropertyKey) CacheLevel: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
                /// <para>Property: <see cref="DmiType007Property.CacheLevel" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Level => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheLevel);
                #endregion

                #region [public] {static} (IPropertyKey) CacheLocation: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>
                /// Gets a value representing the key to retrieve the property.
                /// </para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
                /// <para>Property: <see cref="DmiType007Property.CacheLocation" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheLocation);
                #endregion

                #region [public] {static} (IPropertyKey) OperationalMode: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
                /// <para>Property: <see cref="DmiType007Property.OperationalMode" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey OperationalMode => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.OperationalMode);
                #endregion

                #region [public] {static} (IPropertyKey) CacheSocketed: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.Cache" /></para>
                /// <para>Property: <see cref="DmiType007Property.CacheSocketed" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey CacheSocketed => new PropertyKey(DmiStructureClass.Cache, DmiType007Property.CacheSocketed);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortConnector: Contains the key definitions available for a type 008 [Port Connector Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 008 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.PortConnector" /> Information] structure.
        /// </summary>
        public static class PortConnector
        {
            #region [public] {static} (IPropertyKey) InternalReferenceDesignator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortConnector" /></para>
            /// <para>Property: <see cref="DmiType008Property.InternalReferenceDesignator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey InternalReferenceDesignator => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.InternalReferenceDesignator);
            #endregion

            #region [public] {static} (IPropertyKey) InternalConnectorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortConnector" /></para>
            /// <para>Property: <see cref="DmiType008Property.InternalConnectorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey InternalConnectorType => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.InternalConnectorType);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalReferenceDesignator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortConnector" /></para>
            /// <para>Property: <see cref="DmiType008Property.ExternalReferenceDesignator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ExternalReferenceDesignator => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.ExternalReferenceDesignator);
            #endregion

            #region [public] {static} (IPropertyKey) ExternalConnectorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortConnector" /></para>
            /// <para>Property: <see cref="DmiType008Property.ExternalConnectorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ExternalConnectorType => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.ExternalConnectorType);
            #endregion

            #region [public] {static} (IPropertyKey) PortType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortConnector" /></para>
            /// <para>Property: <see cref="DmiType008Property.PortType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey PortType => new PropertyKey(DmiStructureClass.PortConnector, DmiType008Property.PortType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemSlots: Contains the key definitions available for a type 009 [System Slots] structure
        /// <summary>
        /// Contains the key definitions available for a type 009 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemSlots" />] structure.
        /// </summary>
        public static class SystemSlots
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) SlotDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SlotDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SlotDesignation => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotDesignation);
            #endregion

            #region [public] {static} (IPropertyKey) SlotType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SlotType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SlotType => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotType);
            #endregion

            #region [public] {static} (IPropertyKey) SlotDataBusWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SlotDataBusWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SlotDataBusWidth => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotDataBusWidth, PropertyUnit.None);
            #endregion

            #region [public] {static} (IPropertyKey) CurrentUsage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.CurrentUsage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey CurrentUsage => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.CurrentUsage);
            #endregion

            #region [public] {static} (IPropertyKey) SlotLength: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SlotLength" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SlotLength => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotLength);
            #endregion

            #region [public] {static} (IPropertyKey) SlotId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SlotId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SlotId => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotId);
            #endregion

            #endregion

            #region version 2.0+ - 2.1+

            #region [public] {static} (IPropertyKey) SlotCharacteristics: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SlotCharacteristics" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SlotCharacteristics);
            #endregion

            #endregion

            #region version 2.6+

            #region [public] {static} (IPropertyKey) SegmentBusFunction: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.SegmentBusFunction" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SegmentBusFunction => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.SegmentBusFunction);
            #endregion

            #region [public] {static} (IPropertyKey) BusDeviceFunction: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemSlots" /></para>
            /// <para>Property: <see cref="DmiType009Property.BusDeviceFunction" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BusDeviceFunction => new PropertyKey(DmiStructureClass.SystemSlots, DmiType009Property.BusDeviceFunction);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OnBoardDevices: Contains the key definitions available for a type 010, obsolete [On Board Devices Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 010, obsolete [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.OnBoardDevices"/> Information] structure.
        /// </summary>
        public static class OnBoardDevices
        {
            #region [public] {static} (IPropertyKey) Enabled: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.OnBoardDevices" /></para>
            /// <para>Property: <see cref="DmiType010Property.Enabled" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            public static IPropertyKey Enabled => new PropertyKey(DmiStructureClass.OnBoardDevices, DmiType010Property.Enabled);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.OnBoardDevices" /></para>
            /// <para>Property: <see cref="DmiType010Property.DeviceType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey DeviceType => new PropertyKey(DmiStructureClass.OnBoardDevices, DmiType010Property.DeviceType);
            #endregion

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.OnBoardDevices" /></para>
            /// <para>Property: <see cref="DmiType010Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.OnBoardDevices, DmiType010Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) OemStrings: Contains the key definitions available for a type 011 [OEM Strings] structure
        /// <summary>
        /// Contains the key definitions available for a type 011 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.OemStrings" />] structure.
        /// </summary>
        public static class OemStrings
        {
            #region [public] {static} (IPropertyKey) Values: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.OemStrings" /></para>
            /// <para>Property: <see cref="DmiType011Property.Values" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey Values => new PropertyKey(DmiStructureClass.OemStrings, DmiType011Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemConfigurationOptions: Contains the key definitions available for a type 012 [System Configuration Options] structure
        /// <summary>
        /// Contains the key definitions available for a type 012 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemConfigurationOptions" />] structure.
        /// </summary>
        public static class SystemConfigurationOptions
        {
            #region [public] {static} (IPropertyKey) Values: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemConfigurationOptions" /></para>
            /// <para>Property: <see cref="DmiType012Property.Values" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey Values => new PropertyKey(DmiStructureClass.SystemConfigurationOptions, DmiType012Property.Values);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BiosLanguage: Contains the key definitions available for a type 013 [BIOS Language Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 013 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.BiosLanguage" /> Information] structure.
        /// </summary>
        public static class BiosLanguage
        {
            #region version 2.0+

            #region [public] {static} (IPropertyKey) InstallableLanguages: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BiosLanguage" /></para>
            /// <para>Property: <see cref="DmiType013Property.InstallableLanguages" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey InstallableLanguages => new PropertyKey(DmiStructureClass.BiosLanguage, DmiType013Property.InstallableLanguages);
            #endregion

            #region [public] {static} (IPropertyKey) Current: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BiosLanguage" /></para>
            /// <para>Property: <see cref="DmiType013Property.Current" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Current => new PropertyKey(DmiStructureClass.BiosLanguage, DmiType013Property.Current);
            #endregion

            #endregion

            #region version 2.1+

            #region [public] {static} (IPropertyKey) IsCurrentAbbreviated: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BiosLanguage" /></para>
            /// <para>Property: <see cref="DmiType013Property.IsCurrentAbbreviated" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            public static IPropertyKey IsCurrentAbbreviated => new PropertyKey(DmiStructureClass.BiosLanguage, DmiType013Property.IsCurrentAbbreviated);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) GroupAssociations: Contains the key definitions available for a type 014 [Group Associations] structure
        /// <summary>
        /// Contains the key definitions available for a type 014 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.GroupAssociations" />] structure.
        /// </summary>
        public static class GroupAssociations
        {
            #region [public] {static} (IPropertyKey) ContainedElements: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>
            /// Gets a value representing the key to retrieve the property.
            /// </para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.GroupAssociations" /></para>
            /// <para>Property: <see cref="DmiType014Property.ContainedElements" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="DmiGroupAssociationElementCollection" /></para>
            /// </summary>
            public static IPropertyKey ContainedElements => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.ContainedElements);
            #endregion

            #region [public] {static} (IPropertyKey) GroupName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.GroupAssociations" /></para>
            /// <para>Property: <see cref="DmiType014Property.GroupName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey GroupName => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.GroupName);
            #endregion


            #region nested classes

            #region [public] {static} (class) Items: Contains the key definition for the 'Items' section
            /// <summary>
            /// Contains the key definition for the <b>Items</b> section.
            /// </summary>
            public static class Items  
            {
                #region [public] {static} (IPropertyKey) Handle: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.GroupAssociations" /></para>
                /// <para>Property: <see cref="DmiType014Property.Handle" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Int32" /></para>
                /// </summary>
                public static IPropertyKey Handle => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.Handle);
                #endregion

                #region [public] {static} (IPropertyKey) Structure: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.GroupAssociations" /></para>
                /// <para>Property: <see cref="DmiType014Property.Structure" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:iTin.Core.Hardware.Specification.Dmi.SmbiosStructure" /></para>
                /// </summary>
                public static IPropertyKey Structure => new PropertyKey(DmiStructureClass.GroupAssociations, DmiType014Property.Structure);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemEventLog: Contains the key definitions available for a type 015 [System Event Log] structure
        /// <summary>
        /// Contains the key definitions available for a type 015 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemEventLog" />] structure.
        /// </summary>
        public static class SystemEventLog
        {
            #region [public] {static} (IPropertyKey) SystemEventLogs: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemEventLog" /></para>
            /// <para>Property: <see cref="DmiType015Property.SystemEventLog" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SystemEventLogs => new PropertyKey(DmiStructureClass.SystemEventLog, DmiType015Property.SystemEventLog);
            #endregion
        }
        #endregion

        #region [public] {static} (class) PhysicalMemoryArray: Contains the key definitions available for a type 016 [Physical Memory Array] structure
        /// <summary>
        /// Contains the key definitions available for a type 016 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.PhysicalMemoryArray" />] structure.
        /// </summary>
        public static class PhysicalMemoryArray
        {
            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="DmiType016Property.Location" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) Use: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="DmiType016Property.Use" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Use => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.Use);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorCorrection: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="DmiType016Property.MemoryErrorCorrection" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey MemoryErrorCorrection => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.MemoryErrorCorrection);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumCapacity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="DmiType016Property.MaximumCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey MaximumCapacity => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.MaximumCapacity, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="DmiType016Property.MemoryErrorInformationHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey MemoryErrorInformationHandle => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfMemoryDevices: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PhysicalMemoryArray" /></para>
            /// <para>Property: <see cref="DmiType016Property.NumberOfMemoryDevices" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey NumberOfMemoryDevices => new PropertyKey(DmiStructureClass.PhysicalMemoryArray, DmiType016Property.NumberOfMemoryDevices);
            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryDevice: Contains the key definitions available for a type 017 [Memory Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 016 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.MemoryDevice" />] structure.
        /// </summary>
        public static class MemoryDevice
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) PhysicalMemoryArrayHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.PhysicalMemoryArrayHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey PhysicalMemoryArrayHandle => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.PhysicalMemoryArrayHandle);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryErrorInformationHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MemoryErrorInformationHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MemoryErrorInformationHandle => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryErrorInformationHandle);
            #endregion

            #region [public] {static} (IPropertyKey) TotalWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.TotalWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bits" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey TotalWidth => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.TotalWidth, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) DataWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.DataWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bits" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey DataWidth => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.DataWidth, PropertyUnit.Bits);
            #endregion

            #region [public] {static} (IPropertyKey) Size: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.Size" /></para>
            /// <para>Unit: <see cref="PropertyUnit.KB" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Size => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Size, PropertyUnit.KB);
            #endregion

            #region [public] {static} (IPropertyKey) FormFactor: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.FormFactor" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey FormFactor => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.FormFactor);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceSet: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.DeviceSet" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{Byte}" /></para>
            /// </summary>
            public static IPropertyKey DeviceSet => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.DeviceSet);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceLocator: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.DeviceLocator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey DeviceLocator => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.DeviceLocator);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MemoryType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey MemoryType => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryType);
            #endregion

            #region [public] {static} (IPropertyKey) TypeDetail: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.TypeDetail" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey TypeDetail => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.TypeDetail);
            #endregion

            #endregion

            #region version 2.3+

            #region [public] {static} (IPropertyKey) MaximunSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MaximunSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximunSpeed => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MaximunSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTag: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.AssetTag" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey AssetTag => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.AssetTag);
            #endregion

            #region [public] {static} (IPropertyKey) PartNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.PartNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey PartNumber => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.PartNumber);
            #endregion

            #region [public] {static} (IPropertyKey) Rank: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.Rank" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Rank => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.Rank);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) ConfiguredMemoryClockSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.ConfiguredMemoryClockSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.MHz" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32"/></para>
            /// </summary>
            public static IPropertyKey ConfiguredMemoryClockSpeed => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ConfiguredMemoryClockSpeed, PropertyUnit.MHz);
            #endregion

            #region [public] {static} (IPropertyKey) BankLabel: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.BankLocator" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BankLabel => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.BankLocator);
            #endregion

            #endregion

            #region version 2.8+

            #region [public] {static} (IPropertyKey) MinimunVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MinimunVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MinimunVoltage => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MinimunVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MaximumVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MaximumVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximumVoltage => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MaximumVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) ConfiguredVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.ConfiguredVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ConfiguredVoltage => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ConfiguredVoltage, PropertyUnit.mV);
            #endregion

            #endregion

            #region version 3.2+

            #region [public] {static} (IPropertyKey) MemoryTechnology: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MemoryTechnology" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey MemoryTechnology => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MinimunVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryOperatingModeCapability: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MemoryOperatingModeCapability" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection&lt;String&gt;" /></para>
            /// </summary>
            public static IPropertyKey MemoryOperatingModeCapability => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemoryOperatingModeCapability);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.FirmwareVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey FirmwareVersion => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) ModuleManufacturerId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.ModuleManufacturerId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            public static IPropertyKey ModuleManufacturerId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ModuleManufacturerId);
            #endregion

            #region [public] {static} (IPropertyKey) ModuleProductId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.ModuleProductId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            public static IPropertyKey ModuleProductId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.ModuleProductId);
            #endregion

            #region [public] {static} (IPropertyKey) MemorySubSystemControllerManufacturerId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MemorySubSystemControllerManufacturerId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            public static IPropertyKey MemorySubsystemControllerManufacturerId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemorySubSystemControllerManufacturerId);
            #endregion

            #region [public] {static} (IPropertyKey) MemorySubSystemControllerProductId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.MemorySubSystemControllerProductId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{Int32}" /></para>
            /// </summary>
            public static IPropertyKey MemorySubsystemControllerProductId => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.MemorySubSystemControllerProductId);
            #endregion

            #region [public] {static} (IPropertyKey) NonVolatileSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.NonVolatileSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            public static IPropertyKey NonVolatileSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.NonVolatileSize);
            #endregion

            #region [public] {static} (IPropertyKey) VolatileSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.VolatileSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            public static IPropertyKey VolatileSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.VolatileSize);
            #endregion

            #region [public] {static} (IPropertyKey) CacheSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.CacheSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            public static IPropertyKey CacheSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.CacheSize);
            #endregion

            #region [public] {static} (IPropertyKey) LogicalSize: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDevice" /></para>
            /// <para>Property: <see cref="DmiType017Property.LogicalSize" /></para>
            /// <para>Unit: <see cref="PropertyUnit.Bytes" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            public static IPropertyKey LogicalSize => new PropertyKey(DmiStructureClass.MemoryDevice, DmiType017Property.LogicalSize);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryError32: Contains the key definitions available for a type 018 [32-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 018 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.BitMemoryError32" /> Information] structure.
        /// </summary>
        public static class BitMemoryError32
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) ErrorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.ErrorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorType => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorType);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.ErrorGranularity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorGranularity => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorGranularity);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorOperation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.ErrorOperation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorOperation => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorOperation);
            #endregion

            #region [public] {static} (IPropertyKey) VendorSyndrome: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.VendorSyndrome" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey VendorSyndrome => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.VendorSyndrome);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.MemoryArrayErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey MemoryArrayErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.DeviceErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey DeviceErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.DeviceErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError32" /></para>
            /// <para>Property: <see cref="DmiType018Property.ErrorResolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey ErrorResolution => new PropertyKey(DmiStructureClass.BitMemoryError32, DmiType018Property.ErrorResolution);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryArrayMappedAddress: Contains the key definitions available for a type 019 [Memory Array Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 019 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.MemoryArrayMappedAddress" />] structure.
        /// </summary>
        public static class MemoryArrayMappedAddress
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) MemoryArrayHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType019Property.MemoryArrayHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MemoryArrayHandle => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.MemoryArrayHandle);
            #endregion

            #region [public] {static} (IPropertyKey) PartitionWidth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType019Property.PartitionWidth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey PartitionWidth => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.PartitionWidth);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) StartAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType019Property.StartAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey StartAddress => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.StartAddress);
            #endregion

            #region [public] {static} (IPropertyKey) EndAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryArrayMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType019Property.EndAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey EndAddress => new PropertyKey(DmiStructureClass.MemoryArrayMappedAddress, DmiType019Property.EndAddress);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryDeviceMappedAddress: Contains the key definitions available for a type 020 [Memory Device Mapped Address] structure
        /// <summary>
        /// Contains the key definitions available for a type 020 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.MemoryDeviceMappedAddress" />] structure.
        /// </summary>
        public static class MemoryDeviceMappedAddress
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) StartAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.StartAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey StartAddress => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.StartAddress);
            #endregion

            #region [public] {static} (IPropertyKey) EndAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.EndAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey EndAddress => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.EndAddress);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryDeviceHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.MemoryDeviceHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MemoryDeviceHandle => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.MemoryDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayMappedAddressHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.MemoryArrayMappedAddressHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MemoryArrayMappedAddressHandle => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.MemoryArrayMappedAddressHandle);
            #endregion

            #region [public] {static} (IPropertyKey) PartitionRowPosition: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.PartitionRowPosition" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey PartitionRowPosition => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.PartitionRowPosition);
            #endregion

            #region [public] {static} (IPropertyKey) InterleavePosition: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.InterleavePosition" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="MemoryDeviceMappedAddressInterleavedPosition" /></para>
            /// </summary>
            public static IPropertyKey InterleavePosition => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.InterleavePosition);
            #endregion

            #region [public] {static} (IPropertyKey) InterleavedDataDepth: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.InterleavedDataDepth" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey InterleavedDataDepth => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.InterleavedDataDepth);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) ExtendedStartingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.ExtendedStartingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            public static IPropertyKey ExtendedStartingAddress => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.ExtendedStartingAddress);
            #endregion

            #region [public] {static} (IPropertyKey) ExtendedEndingAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryDeviceMappedAddress" /></para>
            /// <para>Property: <see cref="DmiType020Property.ExtendedEndingAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable{UInt64}" /></para>
            /// </summary>
            public static IPropertyKey ExtendedEndingAddress => new PropertyKey(DmiStructureClass.MemoryDeviceMappedAddress, DmiType020Property.ExtendedEndingAddress);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BuiltInPointingDevice: Contains the key definitions available for a type 021 [Built-in Pointing Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 021 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.BuiltInPointingDevice" />] structure.
        /// </summary>
        public static class BuiltInPointingDevice
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) Type: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BuiltInPointingDevice" /></para>
            /// <para>Property: <see cref="DmiType021Property.Type" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Type => new PropertyKey(DmiStructureClass.BuiltInPointingDevice, DmiType021Property.Type);
            #endregion

            #region [public] {static} (IPropertyKey) Interface: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BuiltInPointingDevice" /></para>
            /// <para>Property: <see cref="DmiType021Property.Interface" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Interface => new PropertyKey(DmiStructureClass.BuiltInPointingDevice, DmiType021Property.Interface);
            #endregion

            #region [public] {static} (IPropertyKey) NumberOfButtons: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BuiltInPointingDevice" /></para>
            /// <para>Property: <see cref="DmiType021Property.NumberOfButtons" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey NumberOfButtons => new PropertyKey(DmiStructureClass.BuiltInPointingDevice, DmiType021Property.NumberOfButtons);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) PortableBattery: Contains the key definitions available for a type 022 [Portable Battery] structure
        /// <summary>
        /// Contains the key definitions available for a type 022 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.PortableBattery" />] structure.
        /// </summary>
        public static class PortableBattery
        {
            #region version 2.1+

            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.Location" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) ManufactureDate: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.ManufactureDate" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ManufactureDate => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.ManufactureDate);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.DeviceName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey DeviceName => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DeviceName);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceChemistry: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.DeviceChemistry" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey DeviceChemistry => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DeviceChemistry);
            #endregion

            #region [public] {static} (IPropertyKey) DesignCapacity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.DesignCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mWh" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey DesignCapacity => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DesignCapacity, PropertyUnit.mWh);
            #endregion

            #region [public] {static} (IPropertyKey) DesignVoltage: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.DesignVoltage" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey DesignVoltage => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DesignVoltage, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) SBDSVersionNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.SbdsVersionNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SBDSVersionNumber => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SbdsVersionNumber);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunErrorInBatteryData: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.MaximunErrorInBatteryData" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey MaximunErrorInBatteryData => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.MaximunErrorInBatteryData);
            #endregion

            #endregion

            #region version 2.2+

            #region [public] {static} (IPropertyKey) SBDSSerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.SbdsSerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SBDSSerialNumber => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SbdsSerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) SBDSManufactureDate: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.SbdsManufactureDate" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SBDSManufactureDate => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SbdsManufactureDate);
            #endregion

            #region [public] {static} (IPropertyKey) SBDSDeviceChemistry: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.SbdsDeviceChemistry" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SBDSDeviceChemistry => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.SbdsDeviceChemistry);
            #endregion

            #region [public] {static} (IPropertyKey) DesignCapacityMultiplier: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.DesignCapacityMultiplier" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey DesignCapacityMultiplier => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.DesignCapacityMultiplier);
            #endregion

            #region [public] {static} (IPropertyKey) OemSpecific: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.PortableBattery" /></para>
            /// <para>Property: <see cref="DmiType022Property.OemSpecific" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey OemSpecific => new PropertyKey(DmiStructureClass.PortableBattery, DmiType022Property.OemSpecific);
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemReset: Contains the key definitions available for a type 023 [System Reset] structure
        /// <summary>
        /// Contains the key definitions available for a type 023 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemReset" />] structure.
        /// </summary>
        public static class SystemReset
        {
            #region [public] {static} (IPropertyKey) ResetCount: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
            /// <para>Property: <see cref="DmiType023Property.ResetCount" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ResetCount => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.ResetCount);
            #endregion

            #region [public] {static} (IPropertyKey) ResetLimit: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
            /// <para>Property: <see cref="DmiType023Property.ResetLimit" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ResetLimit => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.ResetLimit);
            #endregion

            #region [public] {static} (IPropertyKey) TimerInterval: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
            /// <para>Property: <see cref="DmiType023Property.TimerInterval" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey TimerInterval => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.TimerInterval);
            #endregion

            #region [public] {static} (IPropertyKey) Timeout: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
            /// <para>Property: <see cref="DmiType023Property.Timeout" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Timeout => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.Timeout);
            #endregion


            #region nested classes

            #region [public] {static} (class) Capabilities: Contains the key definition for the 'Capabilities' section.
            /// <summary>
            /// Contains the key definition for the <b>Capabilities</b> section.
            /// </summary>
            public static class Capabilities
            {
                #region [public] {static} (IPropertyKey) BootOption: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
                /// <para>Property: <see cref="DmiType023Property.BootOption" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey BootOption =>  new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.BootOption);
                #endregion

                #region [public] {static} (IPropertyKey) BootOptionOnLimit: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
                /// <para>Property: <see cref="DmiType023Property.BootOptionOnLimit" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey BootOptionOnLimit => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.BootOptionOnLimit);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
                /// <para>Property: <see cref="DmiType023Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.Status);
                #endregion

                #region [public] {static} (IPropertyKey) WatchdogTimer: Gets a value representing the key to retrieve the property.
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemReset" /></para>
                /// <para>Property: <see cref="DmiType023Property.WatchdogTimer" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey WatchdogTimer => new PropertyKey(DmiStructureClass.SystemReset, DmiType023Property.WatchdogTimer);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) HardwareSecurity: Contains the key definitions available for a type 024 [Hardware Security] structure
        /// <summary>
        /// Contains the key definitions available for a type 024 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.HardwareSecurity" />] structure.
        /// </summary>
        public static class HardwareSecurity
        {
            #region nested classes

            #region [public] {static} (class) HardwareSecuritySettings: Contains the key definition for the 'HardwareSecuritySettings' section
            /// <summary>
            /// Contains the key definition for the <b>HardwareSecuritySettings</b> section.
            /// </summary>
            public static class HardwareSecuritySettings
            {
                #region [public] {static} (IPropertyKey) AdministratorPasswordStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.HardwareSecurity" /></para>
                /// <para>Property: <see cref="DmiType024Property.AdministratorPasswordStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey AdministratorPasswordStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.AdministratorPasswordStatus);
                #endregion

                #region [public] {static} (IPropertyKey) FrontPanelResetStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.HardwareSecurity" /></para>
                /// <para>Property: <see cref="DmiType024Property.FrontPanelResetStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey FrontPanelResetStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.FrontPanelResetStatus);
                #endregion

                #region [public] {static} (IPropertyKey) KeyboardPasswordStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.HardwareSecurity" /></para>
                /// <para>Property: <see cref="DmiType024Property.KeyboardPasswordStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey KeyboardPasswordStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.KeyboardPasswordStatus);
                #endregion

                #region [public] {static} (IPropertyKey) PowerOnPasswordStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.HardwareSecurity" /></para>
                /// <para>Property: <see cref="DmiType024Property.PowerOnPasswordStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey PowerOnPasswordStatus => new PropertyKey(DmiStructureClass.HardwareSecurity, DmiType024Property.PowerOnPasswordStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemPowerControls: Contains the key definitions available for a type 025 [System Power Controls] structure
        /// <summary>
        /// Contains the key definitions available for a type 025 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemPowerControls" />] structure.
        /// </summary>
        public static class SystemPowerControls
        {
            #region [public] {static} (IPropertyKey) Month: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerControls" /></para>
            /// <para>Property: <see cref="DmiType025Property.Month" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Month => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Month);
            #endregion

            #region [public] {static} (IPropertyKey) Day: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerControls" /></para>
            /// <para>Property: <see cref="DmiType025Property.Day" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Day => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Day);
            #endregion

            #region [public] {static} (IPropertyKey) Hour: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerControls" /></para>
            /// <para>Property: <see cref="DmiType025Property.Hour" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Hour => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Hour);
            #endregion

            #region [public] {static} (IPropertyKey) Minute: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerControls" /></para>
            /// <para>Property: <see cref="DmiType025Property.Minute" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Minute => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Minute);
            #endregion

            #region [public] {static} (IPropertyKey) Second: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerControls" /></para>
            /// <para>Property: <see cref="DmiType025Property.Second" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Second => new PropertyKey(DmiStructureClass.SystemPowerControls, DmiType025Property.Second);
            #endregion
        }
        #endregion

        #region [public] {static} (class) VoltageProbe: Contains the key definitions available for a type 026 [Voltage Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 026 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.VoltageProbe" />] structure.
        /// </summary>
        public static class VoltageProbe
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.MaximunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximunValue => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.MaximunValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) MinimunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.MinimunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MinimunValue => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.MinimunValue, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.Resolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Resolution, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.Tolerance" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mV" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>

            public static IPropertyKey Tolerance => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Tolerance, PropertyUnit.mV);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.Accuracy" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Accuracy);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
            /// <para>Property: <see cref="DmiType026Property.NominalValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Nullable&lt;Int32&gt;" /></para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.NominalValue, PropertyUnit.mV);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
                /// <para>Property: <see cref="DmiType026Property.Location" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.VoltageProbe" /></para>
                /// <para>Property: <see cref="DmiType026Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.VoltageProbe, DmiType026Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) CoolingDevice: Contains the key definitions available for a type 027 [Cooling Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 027 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.CoolingDevice" />] structure.
        /// </summary>
        public static class CoolingDevice
        {
            #region version 2.2+

            #region [public] {static} (IPropertyKey) TemperatureProbeHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
            /// <para>Property: <see cref="DmiType027Property.TemperatureProbeHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey TemperatureProbeHandle => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.TemperatureProbeHandle);
            #endregion

            #region [public] {static} (IPropertyKey) CoolingUnitGroup: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
            /// <para>Property: <see cref="DmiType027Property.CoolingUnitGroup" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey CoolingUnitGroup => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.CoolingUnitGroup);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
            /// <para>Property: <see cref="DmiType027Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalSpeed: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
            /// <para>Property: <see cref="DmiType027Property.NominalSpeed" /></para>
            /// <para>Unit: <see cref="PropertyUnit.RPM" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey NominalSpeed => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.NominalSpeed, PropertyUnit.RPM);
            #endregion

            #endregion

            #region version 2.7+

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
            /// <para>Property: <see cref="DmiType027Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.Description);
            #endregion

            #endregion


            #region nested classes

            #region [public] {static} (class) DeviceTypeAndStatus: Contains the key definition for the 'Device Type And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Device Type And Status</b> section.
            /// </summary>
            public static class DeviceTypeAndStatus
            {
                #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
                /// <para>Property: <see cref="DmiType027Property.DeviceType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey DeviceType => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.DeviceType);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.CoolingDevice" /></para>
                /// <para>Property: <see cref="DmiType027Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.CoolingDevice, DmiType027Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TemperatureProbe: Contains the key definitions available for a type 028 [Temperature Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 028 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.TemperatureProbe" />] structure.
        /// </summary>
        public static class TemperatureProbe
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.MaximunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximunValue => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.MaximunValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) MinimunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.MinimunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MinimunValue => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.MinimunValue, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.Resolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Resolution, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.Tolerance" /></para>
            /// <para>Unit: <see cref="PropertyUnit.DegreeCentigrade" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Tolerance, PropertyUnit.DegreeCentigrade);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.Accuracy" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Accuracy);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property.
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.NominalValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.NominalValue, PropertyUnit.mV);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
                /// <para>Property: <see cref="DmiType028Property.Location" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.TemperatureProbe" /></para>
                /// <para>Property: <see cref="DmiType028Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.TemperatureProbe, DmiType028Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ElectricalCurrentProbe: Contains the key definitions available for a type 029 [Electrical Current Probe] structure
        /// <summary>
        /// Contains the key definitions available for a type 029 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.ElectricalCurrentProbe" />] structure.
        /// </summary>
        public static class ElectricalCurrentProbe
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType028Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType028Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.MaximunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaximunValue => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.MaximunValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) MinimunValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.MinimunValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MinimunValue => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.MinimunValue, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Resolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.Resolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Resolution => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Resolution, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Tolerance: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.Tolerance" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Tolerance => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Tolerance, PropertyUnit.mA);
            #endregion

            #region [public] {static} (IPropertyKey) Accuracy: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.Accuracy" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey Accuracy => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Accuracy);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.OemDefined);
            #endregion

            #region [public] {static} (IPropertyKey) NominalValue: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
            /// <para>Property: <see cref="DmiType029Property.NominalValue" /></para>
            /// <para>Unit: <see cref="PropertyUnit.mA" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey NominalValue => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.NominalValue, PropertyUnit.mA);
            #endregion


            #region nested classes

            #region [public] {static} (class) LocationAndStatus: Contains the key definition for the 'Location And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Location And Status</b> section.
            /// </summary>
            public static class LocationAndStatus
            {
                #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
                /// <para>Property: <see cref="DmiType029Property.Location" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Location => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Location);
                #endregion

                #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.ElectricalCurrentProbe" /></para>
                /// <para>Property: <see cref="DmiType029Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.ElectricalCurrentProbe, DmiType029Property.Status);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) OutOfBandRemote: Contains the key definitions available for a type 030 [Out-of-Band Remote Access] structure
        /// <summary>
        /// Contains the key definitions available for a type 030 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.ElectricalCurrentProbe" />] structure.
        /// </summary>
        public static class OutOfBandRemote
        {
            #region [public] {static} (IPropertyKey) ManufacturerName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.OutOfBandRemote" /></para>
            /// <para>Property: <see cref="DmiType030Property.ManufacturerName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.OutOfBandRemote, DmiType030Property.ManufacturerName);
            #endregion


            #region nested classes

            #region [public] {static} (class) Connections: Contains the key definition for the 'Connections And Status' section
            /// <summary>
            /// Contains the key definition for the <b>Connections And Status</b> section.
            /// </summary>
            public static class Connections
            {
                #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.OutOfBandRemote" /></para>
                /// <para>Property: <see cref="DmiType030Property.OutBoundConnection" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey OutBoundConnection => new PropertyKey(DmiStructureClass.OutOfBandRemote, DmiType030Property.OutBoundConnection);
                #endregion

                #region [public] {static} (IPropertyKey) InBoundConnection: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.OutOfBandRemote" /></para>
                /// <para>Property: <see cref="DmiType030Property.InBoundConnection" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey InBoundConnection => new PropertyKey(DmiStructureClass.OutOfBandRemote, DmiType030Property.InBoundConnection);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) BootIntegrityServicesEntryPoint: Contains the key definitions available for a type 031 [Boot Integrity 1621 Services (BIS) Entry Point] structure
        /// <summary>
        /// Contains the key definitions available for a type 031 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.BootIntegrityServicesEntryPoint" />] structure.
        /// </summary>
        public static class BootIntegrityServicesEntryPoint
        {
            #region [public] {static} (IPropertyKey) Checksum: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BootIntegrityServicesEntryPoint" /></para>
            /// <para>Property: <see cref="DmiType031Property.Checksum" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey Checksum => new PropertyKey(DmiStructureClass.BootIntegrityServicesEntryPoint, DmiType031Property.Checksum);
            #endregion

            #region [public] {static} (IPropertyKey) BisEntryPointAddress16: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BootIntegrityServicesEntryPoint" /></para>
            /// <para>Property: <see cref="DmiType031Property.BisEntryPointAddress16" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BisEntryPointAddress16 => new PropertyKey(DmiStructureClass.BootIntegrityServicesEntryPoint, DmiType031Property.BisEntryPointAddress16);
            #endregion

            #region [public] {static} (IPropertyKey) BisEntryPointAddress32: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BootIntegrityServicesEntryPoint" /></para>
            /// <para>Property: <see cref="DmiType031Property.BisEntryPointAddress32" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BisEntryPointAddress32 => new PropertyKey(DmiStructureClass.BootIntegrityServicesEntryPoint, DmiType031Property.BisEntryPointAddress32);
            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemBoot: Contains the key definitions available for a type 032 [System Boot Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 032 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemBoot" /> Information] structure.
        /// </summary>
        public static class SystemBoot
        {
            #region [public] {static} (IPropertyKey) Reserved: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemBoot" /></para>
            /// <para>Property: <see cref="DmiType032Property.Reserved" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Reserved => new PropertyKey(DmiStructureClass.SystemBoot, DmiType032Property.Reserved);
            #endregion

            #region [public] {static} (IPropertyKey) Checksum: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemBoot" /></para>
            /// <para>Property: <see cref="DmiType032Property.BootStatus" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey BootStatus => new PropertyKey(DmiStructureClass.SystemBoot, DmiType032Property.BootStatus);
            #endregion
        }
        #endregion

        #region [public] {static} (class) BitMemoryErrorInformation64: Contains the key definitions available for a type 033 [64-Bit Memory Error Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 033 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.BitMemoryErrorInformation64" />] structure.
        /// </summary>
        public static class BitMemoryErrorInformation64
        {
            #region [public] {static} (IPropertyKey) ErrorType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.ErrorType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorType => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorType);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.ErrorGranularity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorGranularity => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorGranularity);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.ErrorOperation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ErrorOperation => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorOperation);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorGranularity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.VendorSyndrome" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey VendorSyndrome => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.VendorSyndrome);
            #endregion

            #region [public] {static} (IPropertyKey) MemoryArrayErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.MemoryArrayErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey BusErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.MemoryArrayErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceErrorAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.DeviceErrorAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey DeviceErrorAddress => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.DeviceErrorAddress);
            #endregion

            #region [public] {static} (IPropertyKey) ErrorResolution: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.BitMemoryError64" /></para>
            /// <para>Property: <see cref="DmiType033Property.ErrorResolution" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int64" /></para>
            /// </summary>
            public static IPropertyKey ErrorResolution => new PropertyKey(DmiStructureClass.BitMemoryError64, DmiType033Property.ErrorResolution);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDevice: Contains the key definitions available for a type 034 [Management Device] structure
        /// <summary>
        /// Contains the key definitions available for a type 034 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.ManagementDevice" />] structure.
        /// </summary>
        public static class ManagementDevice
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDevice" /></para>
            /// <para>Property: <see cref="DmiType034Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) Type: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDevice" /></para>
            /// <para>Property: <see cref="DmiType034Property.Type" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Type => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.Type);
            #endregion

            #region [public] {static} (IPropertyKey) Address: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDevice" /></para>
            /// <para>Property: <see cref="DmiType034Property.Address" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Address => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.Address);
            #endregion

            #region [public] {static} (IPropertyKey) AddressType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDevice" /></para>
            /// <para>Property: <see cref="DmiType034Property.AddressType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey AddressType => new PropertyKey(DmiStructureClass.ManagementDevice, DmiType034Property.AddressType);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceComponent: Contains the key definitions available for a type 035 [Management Device Component] structure
        /// <summary>
        /// Contains the key definitions available for a type 035 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.ManagementDeviceComponent" />] structure.
        /// </summary>
        public static class ManagementDeviceComponent
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="DmiType035Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) ManagementDeviceHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="DmiType035Property.ManagementDeviceHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ManagementDeviceHandle => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.ManagementDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ComponentHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="DmiType035Property.ComponentHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ComponentHandle => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.ComponentHandle);
            #endregion

            #region [public] {static} (IPropertyKey) ThresholdHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceComponent" /></para>
            /// <para>Property: <see cref="DmiType035Property.ThresholdHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey ThresholdHandle => new PropertyKey(DmiStructureClass.ManagementDeviceComponent, DmiType035Property.ThresholdHandle);
            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementDeviceThresholdData: Contains the key definitions available for a type 036 [Management Device Threshold Data] structure
        /// <summary>
        /// Contains the key definitions available for a type 036 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.ManagementDeviceThresholdData" />] structure.
        /// </summary>
        public static class ManagementDeviceThresholdData
        {
            #region [public] {static} (IPropertyKey) LowerNonCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="DmiType036Property.LowerNonCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey LowerNonCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.LowerNonCritical);
            #endregion

            #region [public] {static} (IPropertyKey) UpperNonCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="DmiType036Property.UpperNonCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey UpperNonCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.UpperNonCritical);
            #endregion

            #region [public] {static} (IPropertyKey) LowerCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="DmiType036Property.LowerCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey LowerCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.LowerCritical);
            #endregion

            #region [public] {static} (IPropertyKey) UpperCritical: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="DmiType036Property.UpperCritical" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey UpperCritical => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.UpperCritical);
            #endregion

            #region [public] {static} (IPropertyKey) LowerNonRecoverable: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="DmiType036Property.LowerNonRecoverable" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey LowerNonRecoverable => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.LowerNonRecoverable);
            #endregion

            #region [public] {static} (IPropertyKey) UpperNonRecoverable: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementDeviceThresholdData" /></para>
            /// <para>Property: <see cref="DmiType036Property.UpperNonRecoverable" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey UpperNonRecoverable => new PropertyKey(DmiStructureClass.ManagementDeviceThresholdData, DmiType036Property.UpperNonRecoverable);
            #endregion
        }
        #endregion

        #region [public] {static} (class) MemoryChannel: Contains the key definitions available for a type 037 [Memory Channel] structure
        /// <summary>
        /// Contains the key definitions available for a type 037 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.MemoryChannel" />] structure.
        /// </summary>
        public static class MemoryChannel
        {
            #region [public] {static} (IPropertyKey) ChannelType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryChannel" /></para>
            /// <para>Property: <see cref="DmiType037Property.ChannelType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ChannelType => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.ChannelType);
            #endregion

            #region [public] {static} (IPropertyKey) MaximunChannelLoad: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryChannel" /></para>
            /// <para>Property: <see cref="DmiType037Property.MaximunChannelLoad" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey MaximunChannelLoad => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.MaximunChannelLoad);
            #endregion

            #region [public] {static} (IPropertyKey) Devices: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.MemoryChannel" /></para>
            /// <para>Property: <see cref="DmiType037Property.Devices" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="DmiMemoryChannelElementCollection" /></para>
            /// </summary>
            public static IPropertyKey Devices => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.Devices);
            #endregion


            #region nested classes

            #region [public] {static} (class) MemoryDevices: Contains the key definition for the 'Memory Devices' section
            /// <summary>
            /// Contains the key definition for the <b>Memory Devices</b> section.
            /// </summary>
            public static class MemoryDevices
            {
                #region [public] {static} (IPropertyKey) Handle: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.MemoryChannel" /></para>
                /// <para>Property: <see cref="DmiType037Property.Handle" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey Handle => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.Handle);
                #endregion

                #region [public] {static} (IPropertyKey) Load: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.MemoryChannel" /></para>
                /// <para>Property: <see cref="DmiType037Property.Load" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey Load => new PropertyKey(DmiStructureClass.MemoryChannel, DmiType037Property.Load);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) IpmiDevice: Contains the key definitions available for a type 038 [IPMI Device Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 038 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.IpmiDevice" /> Information] structure.
        /// </summary>
        public static class IpmiDevice
        {
            #region [public] {static} (IPropertyKey) BaseAdress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
            /// <para>Property: <see cref="DmiType038Property.BaseAdress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.UInt64" /></para>
            /// </summary>
            public static IPropertyKey BaseAdress => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.BaseAdress);
            #endregion

            #region [public] {static} (IPropertyKey) NVStorageDeviceAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
            /// <para>Property: <see cref="DmiType038Property.NvStorageDeviceAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey NVStorageDeviceAddress => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.NvStorageDeviceAddress);
            #endregion

            #region [public] {static} (IPropertyKey) I2CSlaveAddress: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
            /// <para>Property: <see cref="DmiType038Property.I2CSlaveAddress" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey I2CSlaveAddress => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.I2CSlaveAddress);
            #endregion

            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
            /// <para>Property: <see cref="DmiType038Property.InterfaceType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey InterfaceType => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.InterfaceType);
            #endregion

            #region [public] {static} (IPropertyKey) InterruptNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
            /// <para>Property: <see cref="DmiType038Property.InterruptNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey InterruptNumber => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.InterruptNumber);
            #endregion

            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
            /// <para>Property: <see cref="DmiType038Property.SpecificationRevision" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SpecificationRevision => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.SpecificationRevision);
            #endregion


            #region nested classes

            #region [public] {static} (class) BaseAdressModifier: Contains the key definition for the 'Base Adress Modifier' section
            /// <summary>
            /// Contains the key definition for the <b>Base Adress Modifier</b> section.
            /// </summary>
            public static class BaseAdressModifier
            {
                #region [public] {static} (IPropertyKey) ChannelType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
                /// <para>Property: <see cref="DmiType038Property.RegisterSpacing" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey RegisterSpacing => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.RegisterSpacing);
                #endregion

                #region [public] {static} (IPropertyKey) LsBit: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
                /// <para>Property: <see cref="DmiType038Property.LsBit" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey LsBit => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.LsBit);
                #endregion
            }
            #endregion

            #region [public] {static} (class) Interrupt: Definition of keys for the 'Interrupt' section
            /// <summary>
            /// Definition of keys for the '<b>Interrupt</b>' section.
            /// </summary>
            [SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public static class Interrupt
            {
                #region [public] {static} (IPropertyKey) Polarity: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
                /// <para>Property: <see cref="DmiType038Property.Polarity" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Polarity => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.Polarity);
                #endregion

                #region [public] {static} (IPropertyKey) SpecifiedInfo: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
                /// <para>Property: <see cref="DmiType038Property.SpecifiedInfo" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey SpecifiedInfo => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.SpecifiedInfo);
                #endregion

                #region [public] {static} (IPropertyKey) TriggerMode: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.IpmiDevice" /></para>
                /// <para>Property: <see cref="DmiType038Property.TriggerMode" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey TriggerMode => new PropertyKey(DmiStructureClass.IpmiDevice, DmiType038Property.TriggerMode);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) SystemPowerSupply: Contains the key definitions available for a type 039 [System Power Supply] structure
        /// <summary>
        /// Contains the key definitions available for a type 039 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.SystemPowerSupply" /> Information] structure.
        /// </summary>
        public static class SystemPowerSupply
        {
            #region [public] {static} (IPropertyKey) IsRedundant: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.IsRedundant" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Boolean" /></para>
            /// </summary>
            public static IPropertyKey IsRedundant => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsRedundant);
            #endregion

            #region [public] {static} (IPropertyKey) Location: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.Location" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Location => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.Location);
            #endregion

            #region [public] {static} (IPropertyKey) DeviceName: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.DeviceName" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey DeviceName => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.DeviceName);
            #endregion

            #region [public] {static} (IPropertyKey) Manufacturer: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.Manufacturer" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Manufacturer => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.Manufacturer);
            #endregion

            #region [public] {static} (IPropertyKey) SerialNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.SerialNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey SerialNumber => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.SerialNumber);
            #endregion

            #region [public] {static} (IPropertyKey) AssetTagNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.AssetTagNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey AssetTagNumber => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.AssetTagNumber);
            #endregion

            #region [public] {static} (IPropertyKey) ModelPartNumber: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.ModelPartNumber" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ModelPartNumber => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.ModelPartNumber);
            #endregion

            #region [public] {static} (IPropertyKey) RevisionLevel: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.RevisionLevel" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey RevisionLevel => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.RevisionLevel);
            #endregion

            #region [public] {static} (IPropertyKey) MaxPowerCapacity: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.MaxPowerCapacity" /></para>
            /// <para>Unit: <see cref="PropertyUnit.W" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey MaxPowerCapacity => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.MaxPowerCapacity, PropertyUnit.W);
            #endregion

            #region [public] {static} (IPropertyKey) InputVoltageProbeHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.InputVoltageProbeHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey InputVoltageProbeHandle => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.InputVoltageProbeHandle);
            #endregion

            #region [public] {static} (IPropertyKey) CoolingDeviceHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.CoolingDeviceHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey CoolingDeviceHandle => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.CoolingDeviceHandle);
            #endregion

            #region [public] {static} (IPropertyKey) InputCurrentProbeHandle: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
            /// <para>Property: <see cref="DmiType039Property.InputCurrentProbeHandle" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Int32" /></para>
            /// </summary>
            public static IPropertyKey InputCurrentProbeHandle => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.InputCurrentProbeHandle);
            #endregion


            #region nested classes

            #region [public] {static} (class) Characteristics: Contains the key definition for the 'Characteristics' section.
            /// <summary>
            /// Contains the key definition for the <b>Characteristics</b> section.
            /// </summary>
            public static class Characteristics
            {
                #region [public] {static} (IPropertyKey) InputVoltageRange: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="DmiType039Property.InputVoltageRange" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey InputVoltageRange => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.InputVoltageRange);
                #endregion

                #region [public] {static} (IPropertyKey) IsHotReplaceable: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="DmiType039Property.IsHotReplaceable" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsHotReplaceable => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsHotReplaceable);
                #endregion

                #region [public] {static} (IPropertyKey) IsPlugged: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="DmiType039Property.IsPlugged" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsPlugged => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsPlugged);
                #endregion

                #region [public] {static} (IPropertyKey) IsPlugged: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="DmiType039Property.IsPresent" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Boolean" /></para>
                /// </summary>
                public static IPropertyKey IsPresent => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.IsPresent);
                #endregion

                #region [public] {static} (IPropertyKey) IsPlugged: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="DmiType039Property.Status" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey Status => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.Status);
                #endregion

                #region [public] {static} (IPropertyKey) SupplyType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.SystemPowerSupply" /></para>
                /// <para>Property: <see cref="DmiType039Property.SupplyType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey SupplyType => new PropertyKey(DmiStructureClass.SystemPowerSupply, DmiType039Property.SupplyType);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) AdditionalInformation: Contains the key definitions available for a type 040 [Additional Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 040 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.AdditionalInformation" />] structure.
        /// </summary>
        public static class AdditionalInformation
        {
            #region [public] {static} (IPropertyKey) Entries: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.AdditionalInformation" /></para>
            /// <para>Property: <see cref="DmiType040Property.Entries" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="DmiAdditionalInformationEntryCollection" /></para>
            /// </summary>
            public static IPropertyKey Entries => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.Entries);
            #endregion


            #region nested classes

            #region [public] {static} (class) Characteristics: Contains the key definition for the 'Entry' section
            /// <summary>
            /// Contains the key definition for the <b>Entry</b> section.
            /// </summary>
            public static class Entry
            {
                #region [public] {static} (IPropertyKey) EntryLength: Obtiene un valor que representa la clave para recuperar la propiedad
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.AdditionalInformation" /></para>
                /// <para>Property: <see cref="DmiType040Property.EntryLength" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey EntryLength => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.EntryLength);
                #endregion

                #region [public] {static} (IPropertyKey) ReferencedHandle: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.AdditionalInformation" /></para>
                /// <para>Property: <see cref="DmiType040Property.ReferencedHandle" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Int32" /></para>
                /// </summary>
                public static IPropertyKey ReferencedHandle => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.ReferencedHandle);
                #endregion

                #region [public] {static} (IPropertyKey) ReferencedOffset: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.AdditionalInformation" /></para>
                /// <para>Property: <see cref="DmiType040Property.ReferencedOffset" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey ReferencedOffset => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.ReferencedOffset);
                #endregion

                #region [public] {static} (IPropertyKey) StringValue: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.AdditionalInformation" /></para>
                /// <para>Property: <see cref="DmiType040Property.StringValue" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey StringValue => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.StringValue);
                #endregion

                #region [public] {static} (IPropertyKey) Value: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.AdditionalInformation" /></para>
                /// <para>Property: <see cref="DmiType040Property.Value" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.Byte" /></para>
                /// </summary>
                public static IPropertyKey Value => new PropertyKey(DmiStructureClass.AdditionalInformation, DmiType040Property.Value);
                #endregion
            }
            #endregion

            #endregion            
        }
        #endregion

        #region [public] {static} (class) OnBoardDevicesExtended: Contains the key definitions available for a type 041 [OnBoard Devices Extended Information] structure
        /// <summary>
        /// Contains the key definitions available for a type 041 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.OnBoardDevicesExtended" /> Information] structure.
        /// </summary>
        public static class OnBoardDevicesExtended
        {
            #region [public] {static} (IPropertyKey) ReferenceDesignation: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.OnBoardDevicesExtended" /></para>
            /// <para>Property: <see cref="DmiType041Property.ReferenceDesignation" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey ReferenceDesignation => new PropertyKey(DmiStructureClass.OnBoardDevicesExtended, DmiType041Property.ReferenceDesignation);
            #endregion


            #region nested classes

            #region [public] {static} (class) Element: Contains the key definition for the 'Element' section
            /// <summary>
            /// Contains the key definition for the <b>Element</b> section.
            /// </summary>
            public static class Element
            {
                #region [public] {static} (IPropertyKey) DeviceType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.OnBoardDevicesExtended" /></para>
                /// <para>Property: <see cref="DmiType041Property.DeviceType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey DeviceType => new PropertyKey(DmiStructureClass.OnBoardDevicesExtended, DmiType041Property.DeviceType);
                #endregion

                #region [public] {static} (IPropertyKey) DeviceStatus: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.OnBoardDevicesExtended" /></para>
                /// <para>Property: <see cref="DmiType041Property.DeviceStatus" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey DeviceStatus => new PropertyKey(DmiStructureClass.OnBoardDevicesExtended, DmiType041Property.DeviceStatus);
                #endregion
            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) ManagementControllerHostInterface: Contains the key definitions available for a type 042 [Management Controller Host Interface] structure
        /// <summary>
        /// Contains the key definitions available for a type 042 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.ManagementControllerHostInterface" />] structure.
        /// </summary>
        public static class ManagementControllerHostInterface
        {
            #region [public] {static} (IPropertyKey) InterfaceType: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface" /></para>
            /// <para>Property: <see cref="DmiType042Property.InterfaceType" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey InterfaceType => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.InterfaceType);
            #endregion

            #region [public] {static} (IPropertyKey) InterfaceTypeSpecificData: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface" /></para>
            /// <para>Property: <see cref="DmiType042Property.InterfaceTypeSpecificData" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:ReadOnlyCollection{Byte}" /></para>
            /// </summary>
            public static IPropertyKey InterfaceTypeSpecificData => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.InterfaceTypeSpecificData);
            #endregion

            #region [public] {static} (IPropertyKey) Protocols: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface" /></para>
            /// <para>Property: <see cref="DmiType042Property.Protocols" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="DmiManagementControllerHostInterfaceProtocolRecordsCollection" /></para>
            /// </summary>
            public static IPropertyKey Protocols => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.Protocols);
            #endregion


            #region nested classes

            #region [public] {static} (class) Protocol: Contains the key definition for the 'Protocols' section
            /// <summary>
            /// Contains the key definition for the <b>Elements</b> section.
            /// </summary>
            public static class Protocol
            {
                #region [public] {static} (IPropertyKey) ProtocolType: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface" /></para>
                /// <para>Property: <see cref="DmiType042Property.ProtocolType" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:System.String" /></para>
                /// </summary>
                public static IPropertyKey ProtocolType => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.ProtocolType);
                #endregion

                #region [public] {static} (IPropertyKey) ProtocolTypeSpecificData: Gets a value representing the key to retrieve the property
                /// <summary>
                /// <para>Gets a value representing the key to retrieve the property.</para>
                /// <para>— Key Composition —————————————————</para>
                /// <para>Structure: <see cref="DmiStructureClass.ManagementControllerHostInterface" /></para>
                /// <para>Property: <see cref="DmiType042Property.ProtocolTypeSpecificData" /></para>
                /// <para>Unit: <see cref="PropertyUnit.None" /></para>
                /// <para>— Value ——————————————————————</para>
                /// <para>Type: <see cref="T:ReadOnlyCollection{Byte}" /></para>
                /// </summary>
                public static IPropertyKey ProtocolTypeSpecificData => new PropertyKey(DmiStructureClass.ManagementControllerHostInterface, DmiType042Property.ProtocolTypeSpecificData);
                #endregion

            }
            #endregion

            #endregion
        }
        #endregion

        #region [public] {static} (class) TpmDevice: Contains the key definitions available for a type 043 [TpmDevice] structure
        /// <summary>
        /// Contains the key definitions available for a type 043 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.TpmDevice" />] structure.
        /// </summary>
        public static class TpmDevice
        {
            #region [public] {static} (IPropertyKey) VendorId: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.VendorId" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey VendorId => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.VendorId);
            #endregion

            #region [public] {static} (IPropertyKey) VendorIdDescription: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.VendorIdDescription" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey VendorIdDescription => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.VendorIdDescription);
            #endregion

            #region [public] {static} (IPropertyKey) MajorSpecVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.MajorSpecVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey MajorSpecVersion => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.MajorSpecVersion);
            #endregion

            #region [public] {static} (IPropertyKey) MinorSpecVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.MinorSpecVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Byte" /></para>
            /// </summary>
            public static IPropertyKey MinorSpecVersion => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.MinorSpecVersion);
            #endregion

            #region [public] {static} (IPropertyKey) FirmwareVersion: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.FirmwareVersion" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:iTin.Core.Hardware.Specification.Tpm.TpmFirmwareVersion" /></para>
            /// </summary>
            public static IPropertyKey FirmwareVersion => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.FirmwareVersion);
            #endregion

            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.Description);
            #endregion

            #region [public] {static} (IPropertyKey) Characteristics: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.Characteristics" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.Collections.ObjectModel.ReadOnlyColletion{String}" /></para>
            /// </summary>
            public static IPropertyKey Characteristics => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.Characteristics);
            #endregion

            #region [public] {static} (IPropertyKey) OemDefined: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.TpmDevice" /></para>
            /// <para>Property: <see cref="DmiType043Property.OemDefined" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey OemDefined => new PropertyKey(DmiStructureClass.TpmDevice, DmiType043Property.OemDefined);
            #endregion
        }
        #endregion

        #region [public] {static} (class) Inactive: Contains the key definitions available for a type 126 [Inactive] structure
        /// <summary>
        /// Contains the key definitions available for a type 126 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.Inactive" />] structure.
        /// </summary>
        public static class Inactive
        {
            #region [public] {static} (IPropertyKey) Description: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para>Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.Inactive" /></para>
            /// <para>Property: <see cref="DmiType126Property.Description" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Description => new PropertyKey(DmiStructureClass.Inactive, DmiType126Property.Description);
            #endregion
        }
        #endregion

        #region [public] {static} (class) EndOfTable: Contains the key definitions available for a type 127 [End-Of-Table] structure
        /// <summary>
        /// Contains the key definitions available for a type 127 [<see cref="T:iTin.Core.Hardware.Specification.Dmi.DmiStructureClass.EndOfTable" />] structure.
        /// </summary>
        public static class EndOfTable
        {
            #region [public] {static} (IPropertyKey) Status: Gets a value representing the key to retrieve the property
            /// <summary>
            /// <para> Gets a value representing the key to retrieve the property.</para>
            /// <para>— Key Composition —————————————————</para>
            /// <para>Structure: <see cref="DmiStructureClass.EndOfTable" /></para>
            /// <para>Property: <see cref="DmiType127Property.Status" /></para>
            /// <para>Unit: <see cref="PropertyUnit.None" /></para>
            /// <para>— Value ——————————————————————</para>
            /// <para>Type: <see cref="T:System.String" /></para>
            /// </summary>
            public static IPropertyKey Status => new PropertyKey(DmiStructureClass.EndOfTable, DmiType127Property.Status);
            #endregion
        }
        #endregion
    }
}
