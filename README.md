| [Getting Started](#getting-started) | [Features](#features) | [License](#license) | [Resources](#resources) | [Download](#download) |
| ----------------------------------- | --------------------- | ------------------- | ----------------------- | --------------------- |

# Unity Singleton

The best way to implement singleton pattern in Unity. By using this pattern you will be able to define Global variables and classes and use their methods and properties in Global. This pattern is a must-have for most of the games that made using Unity engine.

📖 [Learn More about Singleton pattern](https://en.wikipedia.org/wiki/Singleton_pattern)

## Features

- Works in both Development and Production
- Instantiates Singleton objects if they aren't available by Lazy Load
- You can configure fields in the inspector for singleton objects in the preload scene

## Getting Started

This package can be added to your project via [Git UPM](https://docs.unity3d.com/6000.0/Documentation/Manual/upm-ui-giturl.html).
To add this package, copy:

```shell
https://github.com/UnityCommunity/UnitySingleton.git
```

and add it as a git package in the Unity Package Manager by clicking on the "+" icon on the top left of the Package Manager Window, and selecting "Install package from git URL".

Once you have the package installed, you may

- Create your own Singleton classes by extending the Generic [✨ Singleton ✨](Runtime/Scripts/Singleton.cs) class. (🚀 Check out the example [GameManager](Samples~/Scripts/GameManager.cs) in the example [\_Preload scene](Samples~/Scenes/_Preload.unity).)
- Attach your singleton classes to a GameManager game object in a \_Preload scene of your own.
- Edit the variables inside the inspector
- Run the game and enjoy!

## Usage

Add `using UnityCommunity.UnitySingleton;` for using the classes.

- Use `Singleton<T>` for plain C# classes.
- Use `MonoSingleton<T>` if you want a Scene-based singleton which is not persistent across scenes.
- Use `PersistentMonoSingleton<T>` if you want a Global and persistent singleton across scenes.

## Common Issues

1. "Some objects were not cleaned up when closing the scene. (Did you spawn new GameObjects from OnDestroy?)"
	This issue is caused when trying to unsubscribe from an event in OnDestroy/OnDisable. It happens because the singleton is destroyed before trying to unsubscribe, which spawns a new one as the scene is getting disabled, producing this error.
	
	To fix this error, check the `<T>.HasInstance` bool on the singleton in an if statement before unsubscribing from events.

## Contribute

Please refer to [CONTRIBUTING.md](CONTRIBUTING.md) for more information on how to contribute to this project.

## Download

Run the following command in terminal or command prompt to clone the repository:

```bash
git clone https://github.com/UnityCommunity/UnitySingleton.git
```

Or [🔥 Download the master branch as zip](https://github.com/UnityCommunity/UnitySingleton/archive/master.zip).

## Resources

- [📖 Wikipedia](https://en.wikipedia.org/wiki/Singleton_pattern)
- [📖 On the \_Preload Scene](https://stackoverflow.com/questions/35890932/unity-game-manager-script-works-only-one-time/35891919#35891919)
- [▶️ Deep dive into the Singleton Pattern](https://www.youtube.com/watch?v=mpM0C6quQjs)

## License

MIT @ [Unity Community](https://github.com/UnityCommunity)

Made with ❤️ by [Unity Community](https://github.com/UnityCommunity)
