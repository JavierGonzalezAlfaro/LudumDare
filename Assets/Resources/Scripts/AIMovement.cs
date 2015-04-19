using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour {
    public Transform[] target = new Transform[6];
    private NavMeshAgent agent;
    private float[] limits = new float[4];

	// Use this for initialization
	void Start () {
        agent = transform.GetComponent<NavMeshAgent>();
        agent.SetDestination(target[Random.Range(0, target.Length)].position);
        limits[0] = -45;
        limits[1] = -15;
        limits[2] = -192;
        limits[3] = -143;
	}
	
	// Update is called once per frame
	void Update () {
        if (arriveDestination())
        {
            if (GetComponent<AIShoot>().isInTarget()) GetComponent<AIShoot>().shoot();
            if(Random.Range(0,2) == 0){
                agent.SetDestination(target[Random.Range(0, target.Length)].position);
            }
            else
            {
                agent.SetDestination(new Vector3(Random.Range(limits[0],limits[1]), transform.position.y, Random.Range(limits[2],limits[3])));
            }
        }
	}

    public bool arriveDestination()
    {
        return agent.destination.x == transform.position.x && agent.destination.z == transform.position.z;
    }
}
