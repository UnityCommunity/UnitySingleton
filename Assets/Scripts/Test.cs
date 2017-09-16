using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

	void Start ()
	{
		Debug.Log ( GameManager.Instance.GetPlayerName () );
	}
	
}
