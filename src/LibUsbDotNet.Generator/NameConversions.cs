﻿// <copyright file="NameConversions.cs" company="Quamotion">
// Copyright (c) Quamotion. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Text;

namespace LibUsbDotNet.Generator
{
    internal static class NameConversions
    {
        public static string ToClrName(string nativeName, NameConversion conversion)
        {
            return ToClrName(nativeName, string.Empty, conversion);
        }

        public static string ToClrName(string nativeName, string parentName, NameConversion conversion)
        {
            var patchedName = nativeName;

            if (!string.IsNullOrEmpty(parentName) && patchedName.StartsWith(parentName, StringComparison.OrdinalIgnoreCase))
            {
                patchedName = patchedName.Substring(parentName.Length);
            }

            List<string> parts = new List<string>(patchedName.Split('_', StringSplitOptions.RemoveEmptyEntries));

            StringBuilder nameBuilder = new StringBuilder();

            int i = 0;

            while (i < parts.Count)
            {
                if (i == 0 && string.Equals(parts[i], "libusb", StringComparison.OrdinalIgnoreCase))
                {
                    // Skip the libusb prefix
                }
                else if (i == parts.Count - 2
                    && string.Equals(parts[i], "cb", StringComparison.OrdinalIgnoreCase)
                    && string.Equals(parts[i + 1], "fn", StringComparison.OrdinalIgnoreCase))
                {
                    // Convert 'cb_fn' suffix to 'Delegate'
                    nameBuilder.Append("Delegate");

                    // We handle 2 parts at a time
                    i++;
                }
                else if (i == parts.Count - 1 && string.Equals(parts[i], "cb", StringComparison.OrdinalIgnoreCase))
                {
                    // Convert 'Cb' suffix to 'Delegate'
                    nameBuilder.Append("Delegate");
                }
                else if (conversion == NameConversion.Parameter && i == 0)
                {
                    nameBuilder.Append(char.ToLowerInvariant(parts[i][0]) + parts[i].Substring(1).ToLowerInvariant());
                }
                else
                {
                    nameBuilder.Append(char.ToUpperInvariant(parts[i][0]) + parts[i].Substring(1).ToLowerInvariant());
                }

                i++;
            }

            var name = nameBuilder.ToString();

            // Handle reserved keywords
            if (name == "event")
            {
                return "@event";
            }
            else
            {
                return name;
            }
        }
    }
}