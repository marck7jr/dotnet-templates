# .NET Templates

This repository contains .NET Templates created by [Lucimarck J S Dias](https://github.com/marck7jr) using the [Template Engine](https://github.com/dotnet/templating/). Custom templates can be used from `dotnet new` and [Visual Studio 2022](https://visualstudio.microsoft.com/vs/).

## Getting Started

Since [.NET 6](https://dotnet.microsoft.com/en-us/), the template installation can be done by the .NET CLI. To install any template available inside this repository, you can execute `dotnet new --install` passing the a _path_ targeting a root **.csproj** file. Considering that you have [.NET 6 or above](https://dotnet.microsoft.com/en-us/) installed, from the root of this repository, you install any available template like the example below.

**Example**

```
dotnet new --install .\src\csharp\clean-arch
```

For the uninstallation, you can execute the command `dotnet new --uninstall` exatcly the same way for the installation process.

**Example**

```
dotnet new --uninstall .\src\csharp\clean-arch
```

Considering that .NET provides the possibility to publish _nuget_ packages for templates distribution, in the future maybe they will be added here.

# Templates

Inside this repository there are some templates organized by their respective supported .NET language.

### Architectures

Here are the templates created following some popular development architectures.

| Name | Short name | Languages | Tags |
| -- | -- | -- | -- |
| .NET Clean Architecture Project | clean-arch | [C#] | Common/Library/Web/WebAPI |

# FAQ

#### I reinstalled the template locally, but the changes that I made wasn't applied, what I could do?

Uninstall the template and run the .NET CLI command `dotnet new --list` or open Visual Studio 2022 and wait for the templates listing to finish, this will force to remove all references from older version. After that, reinstall the template and relaunch the template listing command. Now the templated instaled will sync with your current changes.

# Related projects

You should take a look at these related projects:

- [Template Engine](https://github.com/dotnet/templating/)
- [Template Samples](https://github.com/dotnet/dotnet-template-samples)
- [.NET Core](https://github.com/dotnet/core)
- [ASP.NET](https://github.com/aspnet)
- [Mono](https://github.com/mono)