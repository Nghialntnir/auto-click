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
        public int DelayMs { get; set; }      // Thời gian chờ trước khi click (ms)

        /// <summary>
        /// Số lần click: 1 = Single click, 2 = Double click
        /// </summary>
        public int ClickCount { get; set; }

        public override string ToString()
        {
            string clickLabel = $"🖱️×{ClickCount}";
            return $"⏳ Waiting: {DelayMs}ms  {clickLabel}\n📍 Location: ({Position.X}, {Position.Y})";
        }
    }
}