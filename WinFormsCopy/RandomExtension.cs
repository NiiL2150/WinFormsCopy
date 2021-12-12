using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCopy
{
    internal static class RandomExtension
    {
        public static Color NextColor(this Random random)
        {
            KnownColor[] knownColors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            Color[] colors = new Color[knownColors.Length];
            int i = 0;
            foreach (KnownColor knowColor in knownColors)
            {
                colors[i] = Color.FromKnownColor(knowColor);
                i++;
            }

            return colors[random.Next()];
        }
    }
}
