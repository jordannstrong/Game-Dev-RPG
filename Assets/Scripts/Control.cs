 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class Control : MonoBehaviour
{ 
 	public AnimationClip run;
 	public AnimationClip idle;
 
 	public float speed = 5;
 	public float gravity = -5;
 
 	float velocityY = 0; 
 
 	CharacterController controller;
 
 	void Start()
 	{
 		controller = GetComponent<CharacterController>();
 	}
 
 	void Update()
 	{
 		velocityY += gravity* Time.deltaTime;
 
 		Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
 		input = input.normalized;
 
 		Vector3 delta = Vector3.zero;
  		if (Input.GetKey(KeyCode.W)) { 
 			delta += transform.forward* speed;
 		}  else if (Input.GetKey(KeyCode.S)) {
 			delta += -transform.forward* speed;
 		}
 
 		if (Input.GetKey(KeyCode.D)) {
 			delta += transform.right* speed;
 		} else if (Input.GetKey(KeyCode.A)) {
 			delta += -transform.right* speed;
 		}
 
 		controller.SimpleMove(delta);
 
 		if (delta != Vector3.zero) {
 			GetComponent<Animation>().CrossFade(run.name);
 		}
 		else 
 		{
  		GetComponent<Animation>().CrossFade(idle.name);
 	}
 }}