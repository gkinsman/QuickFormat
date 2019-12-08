
# <img src="/QuickFormat.App/icon3.png" width="70px" /> Quick Format

A tiny .NET Core 3.1 app that pulls JSON from the clipboard and formats it.

## Usage
Clone the repo, run `Publish.ps1` from the root, and run `out\QuickFormat.App.exe`. Pin that to the taskbar and it will always open the latest published version.

On opening, this tool will pull whatever is on the clipboard into a string, and attempt to parse it as JSON. If it's valid, then it will be formatted and displayed. If it's not valid, the window will show nothing.

Once the window is open, the contents aren't changed again.

## Theme
Change the theme in App.xaml
`...themes/dark.red.xaml" ...`
