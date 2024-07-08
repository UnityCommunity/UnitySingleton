using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace UnityCommunity.UnitySingleton
{

    public enum SingletonInitializationStatus
    {
        None,
        Initializing,
        Initialized
    }

    /// <summary>
    /// The singleton implementation for classes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Singleton<T> : ISingleton where T : Singleton<T>, new()
    {

        #region Fields

        /// <summary>
        /// The instance.
        /// </summary>
        private static T instance;

        /// <summary>
        /// The initialization status of the singleton's instance.
        /// </summary>
        private SingletonInitializationStatus initializationStatus = SingletonInitializationStatus.None;

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
                if (instance == null)
                {
                    //ensure that only one thread can execute
                    lock (typeof(T))
                    {
                        if (instance == null)
                        {
                            instance = new T();
                            instance.InitializeSingleton();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Gets whether the singleton's instance is initialized.
        /// </summary>
        public virtual bool IsInitialized => this.initializationStatus == SingletonInitializationStatus.Initialized;

        #endregion

        #region Protected Methods

        protected virtual void OnInitializing()
        {

        }

        protected virtual void OnInitialized()
        {

        }

        #endregion

        #region Public Methods

        public virtual void InitializeSingleton()
        {
            if (this.initializationStatus != SingletonInitializationStatus.None)
            {
                return;
            }

            this.initializationStatus = SingletonInitializationStatus.Initializing;
            OnInitializing();
            this.initializationStatus = SingletonInitializationStatus.Initialized;
            OnInitialized();
        }

        public virtual void ClearSingleton() { }

        public static void CreateInstance()
        {
            DestroyInstance();
            instance = Instance;
        }

        public static void DestroyInstance()
        {
            if (instance == null)
            {
                return;
            }

            instance.ClearSingleton();
            instance = default(T);
        }

        #endregion

    }

}