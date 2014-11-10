using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace JeopardyTimer
{
    class Program
    {

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;


        public const int VK_LCONTROL = 0xA2;
        public const int VK_RCONTROL = 0xA3;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public static TimerBar timerBar;
        public static ScoreBoard scoreBoard;

        private static System.Windows.Forms.Timer updater = new System.Windows.Forms.Timer();

        public static Stopwatch timer = new Stopwatch();


        public static int[] playerPoints = new int[4];

        public static int playerNumber = -1;



        public static void Main()
        {

            _hookID = SetHook(_proc);
            timerBar = new TimerBar();
            scoreBoard = new ScoreBoard();
            updater.Interval = 50;
            updater.Tick += (x, y) => { timerBar.Refresh(); scoreBoard.updateText(); };
            updater.Start();
            Application.Run(new UAppContext());
            UnhookWindowsHookEx(_hookID);
        }


        public static void playSound(System.IO.UnmanagedMemoryStream sound)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
            player.Play();
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);


        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                Keys key = (Keys)Marshal.ReadInt32(lParam);

                switch (key)
                {
                    case Keys.D1:
                    case Keys.D2:
                    case Keys.D3:
                    case Keys.D4:
                    case Keys.D5:
                    case Keys.D6:
                    case Keys.D7:
                    case Keys.D8:
                    case Keys.D9:
                        //Console.WriteLine("keystate." + (GetKeyState(VK_LCONTROL) == (short) -127));
                        if (scoreBoard.ShouldUpdateText())
                        {
                            if (playerNumber == -1)
                            {

                                if ((int)(key) - (int)Keys.D1 < 4)
                                {
                                    playerNumber = (int)(key) - (int)Keys.D1;
                                }
                            }
                            else
                            {
                                playerPoints[playerNumber] += 100 * (((int)(key) - (int)Keys.D1) + 1);
                                playerNumber = -1;
                            }
                        }
                        break;
                    case Keys.Oemtilde:
                        playerNumber = -1;
                        break;
                    case Keys.Space:
                        if (timerBar.Visible || timerBar.Opacity == .5)
                        {
                            if (timerBar.Opacity == .5)
                            {

                                timerBar.Opacity = 100;
                                timerBar.FormBorderStyle = FormBorderStyle.None;
                            }
                            timerBar.Visible = false;
                            timer.Stop();
                            timer.Reset();

                        }
                        else
                        {
                            timer.Reset();
                            timer.Start();
                            timerBar.Visible = true;
                        }
                        break;
                    case Keys.LControlKey:
                    case Keys.RControlKey:
                    case Keys.Control:
                    case Keys.ControlKey:
                        timerBar.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                        scoreBoard.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                        break;
                    case Keys.D:
                        playSound(Properties.Resources.jdaily2x);
                        break;
                    case Keys.J:
                        playSound(Properties.Resources.jfinalj);
                        break;
                    case Keys.K:
                        playSound(Properties.Resources.final_J_theme);
                        break;
                }
            }
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                Keys key = (Keys)Marshal.ReadInt32(lParam);
                switch (key)
                {
                    case Keys.LControlKey:
                    case Keys.RControlKey:
                    case Keys.Control:
                    case Keys.ControlKey:
                        timerBar.FormBorderStyle = FormBorderStyle.None;
                        scoreBoard.FormBorderStyle = FormBorderStyle.None;
                        break;
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }




        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern short GetKeyState(int nVirtKey);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}