using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour {
    public Transform[] target = new Transform[6];
    private NavMeshAgent agent;
    private float time = 5;
    private float[] limits = new float[4];
    /*private GameObject[] enemies;
    private int targetSelector*/

	// Use this for initialization
	void Start () {
        //enemies = GameObject.FindGameObjectsWithTag("Player");
        agent = transform.GetComponent<NavMeshAgent>();
        agent.SetDestination(target[Random.Range(0, 5)].position);
        limits[0] = -45;
        limits[1] = -15;
        limits[2] = -192;
        limits[3] = -143;
	}
	
	// Update is called once per frame
	void Update () {
        if (arriveDestination2())
        {
            if(Random.Range(0,2) == 0){
                agent.SetDestination(target[Random.Range(0, 6)].position);
            }
            else
            {
                agent.SetDestination(new Vector3(Random.Range(limits[0],limits[1]), transform.position.y, Random.Range(limits[2],limits[3])));
            }
        }
	}

    public bool arriveDestination()
    {
        //return agent.destination.x == transform.position.x && agent.destination.z == transform.position.z;
        return agent.destination.x + 5 >= transform.position.x && agent.destination.x - 5 <= transform.position.x && agent.destination.z + 5 >= transform.position.z && agent.destination.z - 5 <= transform.position.z;
    }
    public bool arriveDestination2()
    {
        return agent.destination.x == transform.position.x && agent.destination.z == transform.position.z;
        //return agent.destination.x + 5 >= transform.position.x && agent.destination.x - 5 <= transform.position.x && agent.destination.z + 5 >= transform.position.z && agent.destination.z - 5 <= transform.position.z;
    }

    public NavMeshAgent getAgent()
    {
        return agent;
    }


}
