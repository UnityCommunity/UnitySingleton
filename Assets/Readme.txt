Hi.

This is a tutorial to learn how to implement singleton pattern in Unity.

You just need to have a preload scene, the preload scene is included in Scenes folder and named _Preload for better naviation.
The _Preload scene must be at first in the Build Settings window. Go to File/Build Settings... and make sure the _Preload scene is at first.

In the _Preload scene we have a game object named Singleton, this object is the main game object in the whole game that won't destroy on scene changes.
You can add more singleton scripts by attaching them to this singleton game object.

Then you can access the singleton scripts and objects in global.

Also you can run the game in any scene you like in development, because the singleton objects will be instantiated at runtime if they aren't available.
But make sure to run the production game from the _Preload scene to use the preconfigured settings and use the inspector.

Hope you enjoy it.

Resources:

	https://stackoverflow.com/questions/35890932/unity-game-manager-script-works-only-one-time/35891919#35891919
	https://github.com/UnityCommunity
	https://github.com/BayatGames

Thanks.
