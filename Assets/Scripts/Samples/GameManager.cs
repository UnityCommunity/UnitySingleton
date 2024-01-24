using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityCommunity.UnitySingleton.Samples
{

    public class GameManager : PersistentMonoSingleton<GameManager>
    {

        [SerializeField]
        protected string m_PlayerName;

        protected virtual void Start()
        {
            SceneManager.LoadScene("Main Menu");
        }

        public string GetPlayerName()
        {
            return m_PlayerName;
        }

    }

}