using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStartLevel : MonoBehaviour {
	void Update() {
		if (Input.anyKeyDown) {
			Application.LoadLevelAdditive (1);
		}
	}
}
