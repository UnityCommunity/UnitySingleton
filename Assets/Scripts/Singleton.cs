using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> where T : Singleton<T>, new()
{

    #region Fields

    /// <summary>
    /// The instance.
    /// </summary>
    private static T instance;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the instance.
    /// </summary>
    /// <value>The instance.</value>
    public static T Instance
    {
        get
        {
            if (Instance == null)
            {
                //ensure that only one thread can execute
                lock (typeof(T))
                {
                    if (Instance == null)
                    {
                        instance = new T();
                        instance.Init();
                    }
                }
            }

            return instance;
        }
    }


    #endregion

    #region Methods

    public static void CreateInstance()
    {
        DestroyInstance();
        instance = Instance;
    }

    public static void DestroyInstance()
    {
        if (instance == null) return;

        instance.Clear();
        instance = default(T);
    }

    protected void Init()
    {
        OnInit();
    }

    public void Clear()
    {
        OnClear();
    }

    protected virtual void OnInit()
    {
    }

    protected virtual void OnClear()
    {
    }
    #endregion

}