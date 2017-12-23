using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool boss1 = true;
	public bool boss2 = true;
	public bool boss3 = true;
	public GameObject final;

	// Use this for initialization
	void Start () {
		boss1 = true;
		boss2 = true;
		boss3 = true;
	}

	// Update is called once per frame
	void Update () {
		if (!(boss1 || boss2 || boss3))
		{
			final.SetActive (true);
		}
	}
}
