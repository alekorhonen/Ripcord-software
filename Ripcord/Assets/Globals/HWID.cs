using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Ripcord.Assets.Globals
{
    public class HWID
    {
        [Flags()]
        private enum DockInfo
        {
            DOCKINFO_DOCKED = 0x2,
            DOCKINFO_UNDOCKED = 0x1,
            DOCKINFO_USER_SUPPLIED = 0x4,
            DOCKINFO_USER_DOCKED = 0x5,
            DOCKINFO_USER_UNDOCKED = 0x6
        }

        [StructLayout(LayoutKind.Sequential)]
        private class HW_PROFILE_INFO
        {
            [MarshalAs(UnmanagedType.U4)]
            public Int32 dwDockInfo;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 39)]
            public string szHwProfileGuid;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szHwProfileName;
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool GetCurrentHwProfile(IntPtr lpHwProfileInfo);
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern long GetVolumeInformationA(string PathName, StringBuilder VolumeNameBuffer, Int32 VolumeNameSize, ref Int32 VolumeSerialNumber, ref Int32 MaximumComponentLength, ref Int32 FileSystemFlags, StringBuilder FileSystemNameBuffer, Int32 FileSystemNameSize);

        private static HW_PROFILE_INFO ProfileInfo()
        {
            HW_PROFILE_INFO profile = null;
            IntPtr profilePtr = IntPtr.Zero;
            try
            {
                profile = new HW_PROFILE_INFO();
                profilePtr = Marshal.AllocHGlobal(Marshal.SizeOf(profile));
                Marshal.StructureToPtr(profile, profilePtr, false);

                if (!GetCurrentHwProfile(profilePtr))
                {
                    throw new Exception("Error cant get current hw profile!");
                }
                else
                {
                    Marshal.PtrToStructure(profilePtr, profile);
                    return profile;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            finally
            {
                if (profilePtr != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(profilePtr);
                }
            }
        }

        private static string GetVolumeSerial(string strDriveLetter)
        {
            int serNum = 0, maxCompLen = 0, VolFlags = 0;
            StringBuilder VolLabel = new StringBuilder(256), FSName = new StringBuilder(256);
            GetVolumeInformationA(strDriveLetter + ":\\", VolLabel, VolLabel.Capacity, ref serNum, ref maxCompLen, ref VolFlags, FSName, FSName.Capacity);
            return Convert.ToString(serNum);
        }

        private static string MD5(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            using (var md5 = new MD5CryptoServiceProvider())
                bytes = md5.ComputeHash(bytes);
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }

        public static string Generate()
        {
            var profileInfo = ProfileInfo();
            var profileGuid = profileInfo.szHwProfileGuid.ToString();
            var volumeSerial = GetVolumeSerial(Environment.SystemDirectory.Substring(0, 1));
            return MD5(profileGuid + volumeSerial);
        }

    }
}
