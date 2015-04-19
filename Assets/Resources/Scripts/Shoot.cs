using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    private GameObject bullet;
    public int shootKey;

	void Start () {
	
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(shootKey)) shoot();
	}

    public void shoot()
    {
        bullet = Instantiate(bulletPrefab, transform.GetChild(0).transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Exchange>().setShooter(gameObject);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 50, ForceMode.Impulse);
    }
}
