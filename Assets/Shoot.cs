﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
