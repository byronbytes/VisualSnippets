using System.Runtime.InteropServices; // Import needed for this to work

 public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")] 
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam); // Sends message to the 
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture(); // Gets when you hold form down


        private void panel2_MouseDown(object sender, MouseEventArgs e) // The class must have a MouseEventArgs event for it to work.
        {
            if (e.Button == MouseButtons.Left) // If the mouse button is left
            {
                ReleaseCapture(); // Gets when you hold the form down
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); // Sends the message that it's draggable
            }
        }
        
        
