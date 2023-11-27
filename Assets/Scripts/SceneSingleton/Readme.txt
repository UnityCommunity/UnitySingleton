Hello.

Here is the supplementary content for the Singleton Pattern tutorial: Scene Singleton Pattern.

The Scene Singleton Pattern ensures that there is only one instance of a class in a given scene, but it does not require that the instance continues to exist after a scene switch. After switching scenes, the instance you access will be a new one, unique to the current scene.

This pattern is very useful when you need to manage specific resources or functionality within a single scene, but you don't want these resources or functionality to persist during scene switches.

To use the Scene Singleton Pattern in the current scene, you just need to call the Instance property of the scene singleton class, following the example of SceneTest.cs.

Hope you enjoy it.

Thanks.