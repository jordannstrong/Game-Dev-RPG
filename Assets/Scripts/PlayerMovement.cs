using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public CharacterController CharControl;
    public AnimationClip run;
    public AnimationClip idle;
    public float speed;
    private float maxSpeed = 5f;
    private Vector3 input;
    private Vector3 spawn;
    private RaycastHit hit;

    // Use this for initialization
    void Start()
    {
    }

    void Update()
    {
            var x = 0f;
            if (Input.GetKey(KeyCode.W))
                {
                    input = Vector3.forward;
                          }
                     else if (Input.GetKey(KeyCode.A))
                {
                    input = Vector3.left;
                          }
                      else if (Input.GetKey(KeyCode.D))
                {
                input = Vector3.right;
                }
                else if (Input.GetKey(KeyCode.S))
                {
                input = Vector3.back;
                }
                CharacterController controller = GetComponent<CharacterController>();
                if (controller.isGrounded)
                {
                input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                input = transform.TransformDirection(input);
                input *= speed;
                if (Input.GetButton("Jump"))
                {
                input.y = 5;
                }
                }
            //input.y -= 20.0f * Time.deltaTime;
            //controller.Move(input * Time.deltaTime);
            /*var x = 0f;
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
            transform.Translate(0, 0, z);*/
        }

        void FixedUpdate()
        {
        }
    }
 