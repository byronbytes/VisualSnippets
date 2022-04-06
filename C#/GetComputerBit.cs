  // Set a public string to anything that you want as a placeholder
   public static string bit = "?";
        
        // Gets the computer's bit (64 or 32)
        public static void ComputerBit()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                bit = "64-bit";
            } 
            else
            {
                bit = "32-bit";
            }
        }

// What this does is checks if the computer is a 64-bit OS, and if it isn't it sets the string to 32 bit.
