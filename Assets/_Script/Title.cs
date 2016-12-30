using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

    public Manager manager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.anyKeyDown) {
            manager.LoadNextLevel();
        }
	}
}
