using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoController
{
    public class SerialClass
    {
        private IntPtr SerialPort;
        public string name;
        public uint Baudrate;
        public bool IsOpen;

        [DllImport("SerialLib.dll")]
        private static extern IntPtr SerialConnect(string com, uint baudrate);

        [DllImport("SerialLib.dll")]
        private static extern bool SerialWrite(IntPtr SerialPortHandle, IntPtr bytes, int NumBytesToWrite);

        public SerialClass (string name, int baud)
        {
            this.name = name;
            this.Baudrate = (uint)baud;
            this.IsOpen = false;
        }
        public void Open ()
        {
            if (!IsOpen)
                SerialPort = SerialConnect(name, Baudrate);
            if (!(SerialPort == IntPtr.Zero))
                this.IsOpen = true;
        }
        public void Write (byte[] buffer, int bSize)
        {
            if (IsOpen)
            {
                int size = Marshal.SizeOf(buffer[0]) * bSize;
                IntPtr pnt = Marshal.AllocHGlobal(size);
                try
                {
                    // Copy the array to unmanaged memory.
                    Marshal.Copy(buffer, 0, pnt, bSize);
                }
                finally
                {
                    // Free the unmanaged memory.
                    // Marshal.FreeHGlobal(pnt);
                }
                if (!SerialWrite(this.SerialPort, pnt, bSize))
                {
                    MessageBox.Show("Error!! can't write to serial port");
                }
                Marshal.FreeHGlobal(pnt);
            }
        }
    }
}
