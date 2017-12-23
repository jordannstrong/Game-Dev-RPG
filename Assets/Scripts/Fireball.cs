using System.Collections;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public Fighter player;
    public KeyCode key;
    public int StunTime;
    public AnimationClip special_attack;
    public GameObject fireball;
    public Transform FireballSpawn;
    public double damage_percentage;
    public double range;
    public bool inAction;
    public GameObject ParticlePrefab;
    private GameObject instantiated;
    private Vector3 lastPos;
    private bool usemove = true;
    public float waittime;
    public AnimationClip idle;
    public GameObject explosion;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(lastPos, transform.position) > 0.01f)
        {
            lastPos = transform.position;

        }

        if (Input.GetKeyDown(key) && usemove && Time.time > waittime)
        {
            GetComponent<Animation>().Play(special_attack.name);

            usemove = false;
            player.resetAttack();
            player.Special_attack = true;
            inAction = true;

            lastPos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);

            instantiated = (GameObject)Instantiate(fireball, FireballSpawn.position, FireballSpawn.rotation);

            GetComponent<AudioSource>().Play();
            StopCoroutine("Destroy");    // Interrupt in case it's running
            StartCoroutine("Destroy");
        }

        if (inAction)
        {
            if (player.opponent != null)
            {
                player.Attack(StunTime, damage_percentage, key);
            }
            if (GetComponent<Animation>()[player.attack.name].time > 0.9 * GetComponent<Animation>()[player.attack.name].length)
            {
                inAction = false;
                player.Special_attack = false;
            }
        }

    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(waittime);
        if (instantiated != null)
        {
            Destroy(instantiated);
            usemove = true;
        }
        player.Special_attack = false;
        inAction = false;
    }
 
}
