using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoClickun.Models;

namespace AutoClickun.Services
{
    public class ClickExcutor
    {
        private Random _rand = new Random();

        /// <summary>
        /// Thực thi danh sách kịch bản click một cách bất đồng bộ
        /// </summary>
        /// <param name="scriptList">Danh sách các hành động cần click</param>
        /// <param name="isRepeatUntilStopped">Lặp vô hạn hay chỉ chạy 1 lần</param>
        /// <param name="numRepeatTimes">Số lần lặp (nếu chọn chạy hữu hạn)</param>
        /// <param name="enableOffsetXY">Bật chống bot tọa độ không</param>
        /// <param name="offsetXYPixels">Biên độ lệch tọa độ (pixel)</param>
        /// <param name="enableOffsetSleep">Bật chống bot độ trễ không</param>
        /// <param name="offsetSleepMs">Biên độ lệch thời gian (ms)</param>
        /// <param name="token">Mã hủy luồng để dừng click ngay khi bấm STOP</param>
        public async Task StartExecutionAsync(
            List<ClickAction> scriptList,
            bool isRepeatUntilStopped,
            int numRepeatTimes,
            bool enableOffsetXY,
            int offsetXYPixels,
            bool enableOffsetSleep,
            int offsetSleepMs,
            CancellationToken token)
        {
            // Chạy vòng lặp trên một luồng nền tách biệt hoàn toàn với UI
            await Task.Run(() =>
            {
                int currentLoop = 0;

                // Vòng lặp tổng của cả kịch bản
                while (isRepeatUntilStopped || currentLoop < numRepeatTimes)
                {
                    // Kiểm tra xem người dùng có bấm STOP (yêu cầu hủy luồng) chưa
                    if (token.IsCancellationRequested) break;

                    // Duyệt tuần tự qua từng hành động trong kịch bản
                    foreach (var action in scriptList)
                    {
                        if (token.IsCancellationRequested) break;

                        // 1. XỬ LÝ TỌA ĐỘ CLICK (CÓ OFFSET)
                        int finalX = action.Position.X;
                        int finalY = action.Position.Y;

                        if (enableOffsetXY && offsetXYPixels > 0)
                        {
                            finalX += _rand.Next(-offsetXYPixels, offsetXYPixels + 1);
                            finalY += _rand.Next(-offsetXYPixels, offsetXYPixels + 1);
                        }

                        // Di chuyển chuột đến vị trí thực tế sau khi tính sai số
                        Cursor.Position = new Point(finalX, finalY);

                        // 2. PHÁT LỆNH CLICK HỆ THỐNG
                        Win32Api.mouse_event(0x02, 0, 0, 0, 0); // MOUSEEVENTF_LEFTDOWN
                        Win32Api.mouse_event(0x04, 0, 0, 0, 0); // MOUSEEVENTF_LEFTUP

                        // 3. XỬ LÝ THỜI GIAN NGỦ (CÓ OFFSET)
                        int finalSleepTime = action.DelayMs;

                        if (enableOffsetSleep && offsetSleepMs > 0)
                        {
                            // Cộng hoặc trừ ngẫu nhiên một khoảng mili-giây
                            finalSleepTime += _rand.Next(-offsetSleepMs, offsetSleepMs + 1);
                        }

                        // Kiểm tra an toàn chặn dưới để tránh lỗi Windows ngủ số âm
                        finalSleepTime = Math.Max(10, finalSleepTime);

                        // Đóng băng luồng nền trong khoảng thời gian biến thiên
                        Thread.Sleep(finalSleepTime);
                    }

                    currentLoop++;
                }
            }, token);
        }
    }
}