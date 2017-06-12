# DbgInterruptor
A debuger Interruptor for dotnet core debug on remote *nix host by GDB 

## Usage

change your `static void Main(string[] args)` like fllowing

```csharp
public static void Main(string[] args)
{
  // MUST add here(first)
  DbgInterruptor.Wait();
    
  // your other code
}
```

start your remote debugger. 

```csharp
DbgInterruptor.Break();
```
