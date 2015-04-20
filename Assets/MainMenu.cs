using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void soloGame()
    {
        Application.LoadLevel("FactoryIADemo");
    }

    public void multiGame()
    {
        Application.LoadLevel("FactoryOnline");
    }
}
