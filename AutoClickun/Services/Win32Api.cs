using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoClickun.Services
{
    public class Win32Api
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        // Hàm thực hiện click tại tọa độ cụ thể kèm theo độ lệch ngẫu nhiên (Offset)
        public static void ClickAtPosition(Point pos, int offsetPixels)
        {
            int finalX = pos.X;
            int finalY = pos.Y;

            // Nếu có cài đặt offset, lấy ngẫu nhiên một khoảng lệch trong phạm vi
            if (offsetPixels > 0)
            {
                Random rand = new Random();
                finalX += rand.Next(-offsetPixels, offsetPixels + 1);
                finalY += rand.Next(-offsetPixels, offsetPixels + 1);
            }

            // Di chuyển chuột đến vị trí đích
            System.Windows.Forms.Cursor.Position = new Point(finalX, finalY);

            // Phát lệnh click
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
