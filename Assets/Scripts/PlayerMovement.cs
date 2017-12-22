using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed;
	public GameObject deathParticles;
	public AnimationClip run;
	public AnimationClip idle;

	private float maxSpeed = 5f;
	private Vector3 input;
	private Vector3 spawn;


	// Use this for initialization
	void Start () {
	}

	void Update()
	{
		var x = 0f;
		var z = 0f;
		if (Input.GetKey(KeyCode.LeftShift)) {
			x = Input.GetAxis ("Horizontal") * Time.deltaTime * 15.0f;
			z = Input.GetAxis ("Vertical") * Time.deltaTime * 15.0f;
		} else {
			x = Input.GetAxis ("Horizontal") * Time.deltaTime * 5.0f;
			z = Input.GetAxis ("Vertical") * Time.deltaTime * 5.0f;
		}

		if (x != 0 || z != 0) {

			GetComponent<Animation> ().CrossFade (run.name);
		}
			else 
			{

				GetComponent<Animation>().CrossFade(idle.name);
			}
		transform.Translate(x, 0, 0);
		transform.Translate(0, 0, z);
	}

	void FixedUpdate () {
	}
}
