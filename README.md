# DesignPatterns

A collection of classic Gang-of-Four design patterns implemented in C#, each as its own
project within the `DesignPatterns.sln` solution:

- **Adapter**, **Command**, **Decorator**, **Facade**, **Factory** (Abstract Factory &
  Factory Method), **Observer**, **Singleton**, **Strategy**, **Template Method**,
  **Visitor**, and a **Composite** to-do list.

## Status

> **Heads-up:** these projects are currently **legacy .NET Framework 4.7** (non-SDK-style
> `.csproj`). They build with Visual Studio / MSBuild on Windows. A migration to
> SDK-style projects on **.NET 10** is planned — see the modernization PR and
> [.NET Upgrade Assistant](https://learn.microsoft.com/dotnet/core/porting/upgrade-assistant-overview).

## Build

Open `DesignPatterns.sln` in Visual Studio and build, or from a Windows developer prompt:

```
msbuild DesignPatterns.sln
```

## License

MIT — see [LICENSE](LICENSE).
