using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region MouseHook
        [Flags]
        public enum SPIF
        {
            None = 0x00,
            /// <summary>Writes the new system-wide parameter setting to the user profile.</summary>
            SPIF_UPDATEINIFILE = 0x01,
            /// <summary>Broadcasts the WM_SETTINGCHANGE message after updating the user profile.</summary>
            SPIF_SENDCHANGE = 0x02,
            /// <summary>Same as SPIF_SENDCHANGE.</summary>
            SPIF_SENDWININICHANGE = 0x02
        }

        // http://stackoverflow.com/questions/24737775/toggle-enhance-pointer-precision
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", SetLastError = true)]
        public static extern bool SystemParametersInfoGet(uint action, uint param, IntPtr vparam, SPIF fWinIni);
        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo", SetLastError = true)]
        public static extern bool SystemParametersInfoSet(uint action, uint param, IntPtr vparam, SPIF fWinIni);

        public const UInt32 SPI_GETMOUSE = 0x0003;
        public const UInt32 SPI_SETMOUSE = 0x0004;

        #endregion
            
        public MainWindow()
        {
            InitializeComponent();
            Setup();
        }
        private void Setup()
        {
           ((CheckBox)FindName("cb_MouseAccel")).IsChecked = GetMouseAccel();
           ((CheckBox)FindName("cb_DarkMode")).IsChecked = IsDarkTheme();
        }

        #region Mouse Acceleration
        public static bool ToggleMouseAccel(bool b)
        {
            int[] mouseParams = new int[3];
            // Get the current values.
            SystemParametersInfoGet(SPI_GETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            // Modify the acceleration value as directed.
            mouseParams[2] = b ? 1 : 0;
            // Update the system setting.
            return SystemParametersInfoSet(SPI_SETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), SPIF.SPIF_SENDCHANGE);
        }
        public static bool GetMouseAccel()
        {
            int[] mouseParams = new int[3];
            SystemParametersInfoGet(SPI_GETMOUSE, 0, GCHandle.Alloc(mouseParams, GCHandleType.Pinned).AddrOfPinnedObject(), 0);
            return mouseParams[2] == 1;
        }
        private void cb_MouseAccelButton_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox box = (CheckBox) sender;

#pragma warning disable CS8629 // Nullable value type may be null.
            ToggleMouseAccel((bool)box.IsChecked);
#pragma warning restore CS8629 // Nullable value type may be null.
        }

        #endregion

        #region Dark Mode

        private static bool IsDarkTheme()
        {
            using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");
            var value = key?.GetValue("AppsUseLightTheme");
            return !(value is int i && i > 0);
        }

        private static void SetLightTheme(bool b)
        {
            using var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", true);
            key?.SetValue("AppsUseLightTheme", b ? 0 : 1, RegistryValueKind.DWord);
        }

        private void cb_DarkMode_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox box = (CheckBox)sender;

            #pragma warning disable CS8629 // Nullable value type may be null.
            SetLightTheme((bool)box.IsChecked);
            #pragma warning restore CS8629 // Nullable value type may be null.
        }
        #endregion

        #region VSC Installation
        private void btn_InstallVSC_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            runFile("T:\\Nits\\_____VSCode_Install_HTML_Python\\install1.bat", true);
            runFile("T:\\Nits\\_____VSCode_Install_HTML_Python\\install2.bat", false);
        }

        static void runFile(string path, bool waitForExit)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = @""+path;
            p.StartInfo = pi;

            try
            {
                p.Start();

                if (waitForExit) p.WaitForExit();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void btn_changeBg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                ((Label)FindName("txt_background")).Content = openFileDialog.FileName.ToString();
                SetWallpaper(openFileDialog.FileName.ToString());
            }
                
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(
        UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        public static void SetWallpaper(String path)
        {
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path,
                SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }
    }
}
