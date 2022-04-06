// UseShellExecute makes it run with any native process, for example if you set it to a weblink, it will open up a webbrowser instead of giving you an error.
  
  Process.Start(new ProcessStartInfo { FileName = "https://google.com", UseShellExecute = true });
