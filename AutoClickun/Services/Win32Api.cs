using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoClickun.Services
{
    public class Win32Api
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Dùng để detect click chuột khi đang ở chế độ Pick Location
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;

        public static void ClickAtPosition(Point pos, int offsetPixels)
        {
            int finalX = pos.X;
            int finalY = pos.Y;

            if (offsetPixels > 0)
            {
                var rand = new System.Random();
                finalX += rand.Next(-offsetPixels, offsetPixels + 1);
                finalY += rand.Next(-offsetPixels, offsetPixels + 1);
            }

            System.Windows.Forms.Cursor.Position = new Point(finalX, finalY);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}