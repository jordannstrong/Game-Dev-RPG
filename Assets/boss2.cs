﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss2 : MonoBehaviour {
	public GameManager gm;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void onDestroy() {
		gm.boss2 = false;
	}
}
