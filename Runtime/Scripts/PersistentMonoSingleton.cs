using UnityEngine;

namespace UnityCommunity.UnitySingleton
{
    /// <summary>
    /// This singleton is persistent across scenes by calling <see cref="UnityEngine.Object.DontDestroyOnLoad(Object)"/>.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class PersistentMonoSingleton<T> : MonoSingleton<T> where T : MonoSingleton<T>
    {
        /// <summary>
        /// if this is true, this singleton will auto detach if it finds itself parented on awake
        /// </summary>
        [Tooltip("if this is true, this singleton will auto detach if it finds itself parented on awake")]
        [SerializeField] private bool UnparentOnAwake = true;
        
        #region Protected Methods

        protected override void OnInitializing()
        {
            if (UnparentOnAwake) {
                transform.SetParent(null);
            }
            base.OnInitializing();
            if (Application.isPlaying)
            {
                DontDestroyOnLoad(gameObject);
            }
        }

        #endregion
    }
}