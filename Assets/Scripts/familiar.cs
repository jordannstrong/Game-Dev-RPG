using UnityEngine;
using System.Collections;

public class familiar : MonoBehaviour {

	public float speed;
	public float range;
	public float chaseRange;
	public Transform player;
	public CharacterController control;
	public AnimationClip run;
	public LevelSystem playerLevel;
	public AnimationClip idle;
	public int maxHealth;
	public int health;
	public int damage;
	public int exp_Value;
	public AnimationClip die;
	public AnimationClip attacks;
	public double ImpactTime = 0.36;
	private bool impacted = false;
	private Fighter opponent;
	private int stunTime;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
	}

	bool inRange(float range)
	{
		if (Vector3.Distance (transform.position, player.position) < range) 
		{
		 return true;
		} else
		return false;
	}

	void chase()
	{
		transform.LookAt (player.position);
		//transform.position += transform.forward * speed * Time.deltaTime;
		control.SimpleMove (transform.forward * speed);
		GetComponent<Animation>().Play (run.name);
	}
	
	void attack()
	{
		GetComponent<Animation>().Play (attacks.name);

		if (GetComponent<Animation>() [attacks.name].time > ImpactTime && !impacted && GetComponent<Animation>()[attacks.name].time < 0.9*GetComponent<Animation>()[attacks.name].length) 
		{
			impacted =true;
			opponent.Get_Hit(damage);
		}
	}

















}


























