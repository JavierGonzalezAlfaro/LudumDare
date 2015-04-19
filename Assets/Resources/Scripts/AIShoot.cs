using UnityEngine;
using System.Collections;

public class AIShoot : MonoBehaviour {

    private GameObject[] enemies;
    private int targetSelector;
    private bool inTarget = false;

	void Start () {
        enemies = GameObject.FindGameObjectsWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void shoot()
    {
        targetSelector = Random.Range(0, enemies.Length);
        while (enemies[targetSelector].gameObject.name == gameObject.name)
        {
            targetSelector = Random.Range(0, enemies.Length);
        }
        transform.LookAt(enemies[targetSelector].transform.position);
        GetComponent<Shoot>().shoot();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DangerPoint")
        {
            inTarget = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        inTarget = false;
    }

    public bool isInTarget()
    {
        return inTarget;
    }
}
