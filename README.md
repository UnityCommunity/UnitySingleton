| [Getting Started](#getting-started) | [Features](#features) | [License](#license) | [Resources](#resources) | [Download](#download) |
|-------------------------------------|-----------------------|---------------------|-------------------------|-----------------------|

# Unity Singleton

The best way to implement singleton pattern in Unity. By using this pattern you will be able to define Global variables and classes and use their methods and properties in Global. This pattern is a must have for most of the games that made using Unity engine.

:book: [Learn More about Singleton pattern](https://en.wikipedia.org/wiki/Singleton_pattern)

## Features

- Works in both Development and Production
- Instantiates Singleton objects if they aren't available by Lazy Load
- You can configure fields in the inspector for singleton objects in the preload scene

## Getting Started

- [Download the Project](#download).
- Open the Project in Unity.
- Create your own Singleton classes by extending the Generic [:sparkles: Singleton :sparkles:](https://github.com/UnityCommunity/UnitySingleton/blob/master/Assets/Scripts/Singleton.cs) class. [:rocket: Check out the example GameManager](https://github.com/UnityCommunity/UnitySingleton/blob/master/Assets/Scripts/GameManager.cs)
- Attach your singleton classes to the GameManager game object in the _Preload scene.
- Edit the variables inside the inspector
- Run the game and enjoy!

## Usage

Add `using UnityCommunity.UnitySingleton;` for using the classes.

- Use `Singleton<T>` for plain C# classes.
- Use `MonoSingleton<T>` if you want a Scene-based singleton which is not persistent across scenes.
- Use `PersistentMonoSingleton<T>` if you want a Global and persistent singleton across scenes.

## Download

Run the following command in terminal or command prompt to clone the repository:

```bash
git clone https://github.com/UnityCommunity/UnitySingleton.git
```

Or [:fire: Download the master branch as zip](https://github.com/UnityCommunity/UnitySingleton/archive/master.zip).

## Resources

- [:book: UnityGeek Singleton Article](http://www.unitygeek.com/unity_c_singleton/)
- [:book: Stackoverflow Answer](https://stackoverflow.com/questions/35890932/unity-game-manager-script-works-only-one-time/35891919#35891919)
- [:book: Unity Offical Wiki Singleton](http://wiki.unity3d.com/index.php/Singleton)
- [:book: Singleton.cs Gist](https://gist.github.com/EmpireWorld/11ff050fc1affc733ea74a497ce42961)
- [:book: Wikipedia](https://en.wikipedia.org/wiki/Singleton_pattern)

## License

MIT @ [Unity Community](https://github.com/UnityCommunity)

Made with :heart: by [Unity Community](https://github.com/UnityCommunity)
