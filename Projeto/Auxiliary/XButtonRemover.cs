using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DimStock.Auxiliary
{
    public static class XButtonRemover
    {

        public const int MF_BYPOSITION = 0x400;

        [DllImport("User32")] public static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")] public static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")] public static extern int GetMenuItemCount(IntPtr hWnd);
    }
}
