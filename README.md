## NOTICE
Open Beta Start - 24.10.23 

## What is Invise?

Invise is a [CefSharp](https://github.com/cefsharp/CefSharp/) based open source C# anti-detect web browser!

## Showcase
![first](https://github.com/EugeneSunrise/Invise/assets/56397706/375dd435-1258-49a8-8834-f1cc7faa8d20)
![second](https://github.com/EugeneSunrise/Invise/assets/56397706/83f0a8f9-e5b7-462c-ac6f-2690ab79fe5b)
![third](https://github.com/EugeneSunrise/Invise/assets/56397706/b31830d2-0876-46f4-a7a5-2c9ed7ee7247)

## Spec

- .NET 6
- Clean WPF
- MVVM

## Architecture

The project is structured using the Model-View-ViewModel (MVVM) architectural pattern, which is common in WPF applications. The main components include:

- **ViewModels**: Classes such as `InviseBrowserViewModel`, `InviseProfilesViewModel`, and `BaseViewModel` that handle the logic and manage data for the UI.
- **Models**: Classes like `InviseProfile`, `ProxySettings`, `WebRTCSettings`, `Fingerprint`, and `IpInfoResult` that represent the application data.
- **Views**: XAML files like `InviseBrowserView.xaml` that define the UI.
- **Services**: Classes providing functionalities and settings, including `Setting`, `DelegateCommand`, `RelayCommand`, and UI components such as `AutoStackPanel` and `AutoGrid`.
- **Core**: Contains Chrome API related classes for handling requests, resources, lifespan settings, and models for configurations.
- **Scripts**: JavaScript files like `fakeinject.js` that are injected into web pages.

## Features

- Multi Profiles
- WPF-friendly UI like Chrome
- Platform selection: Windows, MacOS and Linux support has not been added yet
- Proxy Setup: HTTP, SOCKS5 auth support has not been added yet
- Setup Cookie - Full support will be added in the next updates
- Setup Useragent 
- Configuring WebRTC
- Configuring WebGL
- Setup Timezone
- Setup Language
- Setup Geolocation with proxy
- Configuring Processor cores
- Configuring Memory size
- Configuring Resolution
- Configuring Media devices
- Other equally important features

## Compiling

**Compile as AnyCpu or Download last stable version from [Releases](https://github.com/EugeneSunrise/Invise/releases)**

## Project Details

The application's settings are stored in `settings.json`, managed by the `Setting` class. Views are managed by the `ViewManager` class, while the `InviseBrowser` class is a custom web browser based on `ChromiumWebBrowser`.

For more detailed information about project components and their responsibilities, please refer to the sections above.

## What will be added in the next updates?

- MacOS - Linux platform selection for your profile
- SOCKS4 - SOCKS5 AUTH Support
- Cookie Handler
- Other opportunities for profile settings
- Bookmarks
- Chrome extensions support
- Download option
- Some optimization for profile history work
- Add Mediator pattern
- Other Chrome-browser features

## Support the project financially

TRX(Tron): `TGztJ8FSwKNSrigESddGq6euHa9UgtkujG`

BTC(Bitcoin): `bc1q9ym4ac67x9c2slg64lq3u8wczdadj4tep7y2fw`

ETH(Ethereum): `0xb9Fa2B5661238eC9D825bdb0379Db5b035179282`

**Thanks to your support You can let me know which features You expect most to have the highest priority!**