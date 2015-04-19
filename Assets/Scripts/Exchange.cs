using UnityEngine;
using System.Collections;

public class Exchange : MonoBehaviour {
    private GameObject shooter;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void exchangePosition(GameObject target)
    {
        Vector3 targetPosition = target.transform.position;
        target.transform.position = shooter.transform.position;
        shooter.transform.position = targetPosition;
    }

    public void setShooter(GameObject shooter)
    {
        this.shooter = shooter;
    }
}
