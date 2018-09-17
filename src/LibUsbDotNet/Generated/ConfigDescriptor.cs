//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2018 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//

using System;
using System.Runtime.InteropServices;

namespace LibUsbDotNet
{
    /// <summary>
    ///  A structure representing the standard USB configuration descriptor. This
    ///  descriptor is documented in section 9.6.3 of the USB 3.0 specification.
    ///  All multiple-byte fields are represented in host-endian format.
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential, Pack = 1)]
    public struct ConfigDescriptor
    {
        /// <summary>
        ///  Size of this descriptor (in bytes)
        /// </summary>
        public byte Length;

        /// <summary>
        ///  Descriptor type. Will have value
        ///  in this context.
        /// </summary>
        public byte DescriptorType;

        /// <summary>
        ///  Total length of data returned for this configuration
        /// </summary>
        public ushort TotalLength;

        /// <summary>
        ///  Number of interfaces supported by this configuration
        /// </summary>
        public byte NumInterfaces;

        /// <summary>
        ///  Identifier value for this configuration
        /// </summary>
        public byte ConfigurationValue;

        /// <summary>
        ///  Index of string descriptor describing this configuration
        /// </summary>
        public byte Configuration;

        /// <summary>
        ///  Configuration characteristics
        /// </summary>
        public byte Attributes;

        /// <summary>
        ///  Maximum power consumption of the USB device from this bus in this
        ///  configuration when the device is fully operation. Expressed in units
        ///  of 2 mA when the device is operating in high-speed mode and in units
        ///  of 8 mA when the device is operating in super-speed mode.
        /// </summary>
        public byte MaxPower;

        /// <summary>
        ///  Array of interfaces supported by this configuration. The length of
        ///  this array is determined by the bNumInterfaces field.
        /// </summary>
        public IntPtr Interface;

        /// <summary>
        ///  Extra descriptors. If libusb encounters unknown configuration
        ///  descriptors, it will store them here, should you wish to parse them.
        /// </summary>
        public IntPtr Extra;

        /// <summary>
        ///  Length of the extra descriptors, in bytes.
        /// </summary>
        public int ExtraLength;

    }
}
