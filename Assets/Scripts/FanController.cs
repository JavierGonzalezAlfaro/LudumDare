using UnityEngine;
using System.Collections;

public class FanController : MonoBehaviour {
	public GameObject[] fans = new GameObject[3];
	public Light[] lights = new Light[2];
	private bool rotating = false;
	private bool redLights = false;


	void Start(){
		changeLights(Color.green);
		StartCoroutine ("Rotator");
	}
	
	IEnumerator Rotator(){
		while (true) {
			if(rotating){
				yield return new WaitForSeconds(6);
				changeLights(Color.green);
				changeRotation();
			}
			else{
				if(redLights){
					changeLights(Color.red);
					redLights = false;
					yield return new WaitForSeconds(3);
					changeRotation();
				} else {
					redLights =  true;
					yield return new WaitForSeconds(17);
				}
			}
		}
	}

	void changeLights (Color color)
	{
		foreach (Light light in lights) {
			light.color = color;
		}
	}

	void changeRotation(){
		foreach (GameObject fan in fans){
			fan.GetComponent<Rotate>().rotateStronger = !fan.GetComponent<Rotate>().rotateStronger;
			rotating = !rotating;
		}
	}
}
