# WpfApp2

This project demonstrates an issue with LibVLCSharp.WPF video playback when changing themes in a WPF application using WPF-UI.

## Issue Description

When switching between light and dark themes, the video playback area disappears. (The ForegroundWindow that LibVLCSharp.WPF creates goes on top of the video area basically)

## Prerequisites

- Visual Studio 2022 or later
- .NET 8.0 SDK
- Git

## How to Run

1. Clone the repository:
   ```
   git clone https://github.com/DanNegoescuLexacom/WpfApp2.git
   ```

2. Open the solution in Visual Studio.

3. Restore NuGet packages (Visual Studio should do this automatically).

4. Build and run the application (F5 or Debug > Start Debugging).

## Steps to Reproduce the Issue

1. Launch the application.
2. Click the "Play" button to start video playback.
3. Toggle the "Dark Mode" switch to change the theme.
4. Observe how the video playback area reacts to the theme change.

## Expected Behavior

The video should continue playing seamlessly when the theme changes, maintaining its visibility and position.

## Actual Behavior

The video disappears (The ForegroundWindow that LibVLCSharp.WPF creates goes on top of the video area basically)

## Notes

This demo uses a sample video from the internet. If you encounter issues with the video loading, you may need to replace the URL in `MainWindow.xaml.cs` with a different video source.
