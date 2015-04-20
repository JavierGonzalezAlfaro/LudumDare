using UnityEngine;
using System.Collections;

public class Slider : MonoBehaviour {

    private float timer;
    private float direction;
	// Use this for initialization
	void Start () {
        timer = 10;
        direction = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            changeDirection();
            timer = 10;
        }
	}

    void OnTriggerStay(Collider player)
    {
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z+direction);
    }

    void changeDirection()
    {
        direction *= -1;
    }
}
