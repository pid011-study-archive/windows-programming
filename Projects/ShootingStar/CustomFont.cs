using System;
using System.Drawing;
using System.Drawing.Text;
using ShootingStar.Properties;

namespace ShootingStar
{
    internal static class CustomFont
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(
            IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        public static FontFamily NeoDgm { get; }

        static CustomFont()
        {
            NeoDgm = InitNeoDgm();
        }

        private static FontFamily InitNeoDgm()
        {
            var fonts = new PrivateFontCollection();

            var fontData = Resources.neodgm_pro;

            var fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Resources.neodgm_pro.Length);
            AddFontMemResourceEx(fontPtr, (uint)Resources.neodgm_pro.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return fonts.Families[0];
        }
    }
}
