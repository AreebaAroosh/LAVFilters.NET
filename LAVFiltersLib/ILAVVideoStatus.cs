﻿using System.Runtime.InteropServices;

namespace LAVFiltersLib
{
    /// <summary>
    /// LAV Video status interface
    /// </summary>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("1CC2385F-36FA-41B1-9942-5024CE0235DC")]
    public interface ILAVVideoStatus
    {
        /// <summary>
        /// Get the name of the active decoder (can return NULL if none is active)
        /// </summary>
        /// <returns></returns>
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetActiveDecoderName();

        /// <summary>
        /// Get the name of the currently active hwaccel device
        /// </summary>
        /// <param name="pstrDeviceName"></param>
        /// <returns></returns>
        [PreserveSig]
        int GetHWAccelActiveDevice([Out, MarshalAs(UnmanagedType.BStr)] out string pstrDeviceName);
    }
}
