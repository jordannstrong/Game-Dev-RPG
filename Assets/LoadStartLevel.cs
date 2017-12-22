using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStartLevel : MonoBehaviour {
	void OnTriggerEnter(Collider ChangeScene)
	{
		if(ChangeScene.gameObject.CompareTag("Player"))
		{
			Application.LoadLevelAdditive(1); 
		}
	}
}
