using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject boss1;
	public GameObject boss2;
	public GameObject boss3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("zippermouth_c_PF (2)") != null && GameObject.Find("spider_myOldOne (1)") != null && GameObject.Find("wolf_02") != null)
		{
			GameObject.Find ("portal").SetActive (true);
		}
	}
}
