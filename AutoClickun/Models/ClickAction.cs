using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClickun.Models
{
    public class ClickAction
    {
        public Point Position { get; set; }     // Tọa độ X, Y
        public int DelayMs { get; set; }        // Thời gian chờ sau khi click (mili-giây)

        public override string ToString()
        {
            return $"📍 Location: ({Position.X}, {Position.Y}) | ⏳ Waiting: {DelayMs}ms";
        }
    }
}
