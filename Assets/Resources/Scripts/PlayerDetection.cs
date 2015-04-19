using UnityEngine;
using System.Collections;

public class PlayerDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Exchange>().exchangePosition(other.gameObject);
        }
        /*if (other.tag != "DangerPoint" && other.tag != "Slider") Destroy(gameObject);*/
    }

}
