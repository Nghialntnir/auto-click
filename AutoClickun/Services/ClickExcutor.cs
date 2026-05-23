using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using AutoClickun.Models;

namespace AutoClickun.Services
{
    public class ClickExcutor
    {
        private Random _rand = new Random();

        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;

        /// <summary>
        /// Thực thi danh sách kịch bản click một cách bất đồng bộ
        /// </summary>
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
            await Task.Run(() =>
            {
                int currentLoop = 0;

                while (isRepeatUntilStopped || currentLoop < numRepeatTimes)
                {
                    if (token.IsCancellationRequested) break;

                    foreach (var action in scriptList)
                    {
                        if (token.IsCancellationRequested) break;

                        // 1. XỬ LÝ THỜI GIAN NGỦ (CÓ OFFSET)
                        int finalSleepTime = action.DelayMs;
                        if (enableOffsetSleep && offsetSleepMs > 0)
                            finalSleepTime += _rand.Next(0, offsetSleepMs + 1);

                        finalSleepTime = Math.Max(10, finalSleepTime);
                        Thread.Sleep(finalSleepTime);

                        // 2. XỬ LÝ TỌA ĐỘ CLICK (CÓ OFFSET)
                        int finalX = action.Position.X;
                        int finalY = action.Position.Y;

                        if (enableOffsetXY && offsetXYPixels > 0)
                        {
                            finalX += _rand.Next(-offsetXYPixels, offsetXYPixels + 1);
                            finalY += _rand.Next(-offsetXYPixels, offsetXYPixels + 1);
                        }

                        Cursor.Position = new Point(finalX, finalY);

                        // 3. PHÁT LỆNH CLICK
                        int clicks = action.ClickCount;
                        for (int c = 0; c < clicks; c++)
                        {
                            if (token.IsCancellationRequested) break;

                            Win32Api.mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            Win32Api.mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                            // Khoảng cách giữa 2 click trong double-click (~50ms)
                            if (c < clicks - 1)
                                Thread.Sleep(50);
                        }
                    }

                    currentLoop++;
                }
            }, token);
        }
    }
}