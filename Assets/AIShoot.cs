using UnityEngine;
using System.Collections;

public class AIShoot : MonoBehaviour {

    private GameObject[] enemies;
    private int targetSelector;
    private bool shooted;
    private bool arrive;

	void Start () {
        enemies = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "DangerPoint")
        {
            Debug.Log("Llego");
/*Debug.Log(" destino: "+GetComponent<AIMovement>().getAgent().destination.x + "   " + GetComponent<AIMovement>().getAgent().destination.z);
            Debug.Log(" player: " + transform.position.x + "   " + transform.position.z);*/
            Debug.Log(GetComponent<AIMovement>().arriveDestination());
            if(GetComponent<AIMovement>().arriveDestination()){
                Debug.Log("Llego del todo");
                targetSelector = Random.Range(0, enemies.Length);
                while (enemies[targetSelector].gameObject.name == gameObject.name)
                {
                    targetSelector = Random.Range(0, enemies.Length);
                }
                transform.LookAt(enemies[targetSelector].transform.position);
                GetComponent<Shoot>().shoot();
            }
        }
    }
}
