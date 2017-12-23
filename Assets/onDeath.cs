using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDeath : MonoBehaviour {

	public GameObject gt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onDestroy()
	{
		gt.SetActive (true);
	}
}
