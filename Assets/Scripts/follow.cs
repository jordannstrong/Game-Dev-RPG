
 using UnityEngine;
 using System.Collections;
 
 public class follow : MonoBehaviour
{
 private GameObject player;
 public float speed;
 public Vector3 position;
 private float distance;
 //public Transform initialPosition;
 public float moveSpeed;
 public float visionRange;
 public AnimationClip run;
 public AnimationClip idle;
	public static bool attack = false;

 // Use this for initialization
 void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
               //transform.position = initialPosition.position;
        }
 	
 // Update is called once per frame
 void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
              if (distance < 5)
        {
            transform.position = transform.position;
        }
        else if (distance < visionRange)
        {
            Quaternion newRotation = Quaternion.LookRotation (position - transform.position);
						newRotation.z = 0f;
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
             }
         }
 }