// ----------------------------------------------------
// COPYRIGHT (C) <TJG> ALL RIGHTS RESERVED. SEE THE LIC
// ENSE FILE FOR THE FULL LICENSE GOVERNING THIS CODE. 
// ----------------------------------------------------

//using System;
//using System.Runtime.InteropServices;
//using System.Security;
//using System.Text;

//[StructLayout(LayoutKind.Sequential)]
//public struct COPYDATASTRUCT
//{
//    public IntPtr dwData;
//    public int cbData;
//    public IntPtr lpData;
//}

//[SuppressUnmanagedCodeSecurity]
//public class Native
//{
//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg,
//        IntPtr wParam, ref COPYDATASTRUCT lParam);

//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    public static extern IntPtr SendMessage(IntPtr hWnd, int Msg,
//        IntPtr wParam, IntPtr lParam);

//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

//    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//    public static extern int SendMessageTimeout(IntPtr hWnd, uint Msg, IntPtr wParam
//    , ref COPYDATASTRUCT lParam, SendMessageTimeoutFlags fuFlags, uint uTimeout, out UIntPtr lpdwResult);

//    [Flags]
//    public enum SendMessageTimeoutFlags : uint
//    {
//        SMTO_NORMAL = 0x0,
//        SMTO_BLOCK = 0x1,
//        SMTO_ABORTIFHUNG = 0x2,
//        SMTO_NOTIMEOUTIFNOTHUNG = 0x8
//    }

//    [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Auto)]
//    public static extern long GetClassName(IntPtr hwnd, StringBuilder lpClassName, long nMaxCount);
//}

