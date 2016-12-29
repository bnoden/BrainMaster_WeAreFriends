using UnityEngine;
using System.Collections;

public class InstaDeath : MonoBehaviour {

    public Manager manager;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D obj) {
        if (obj.gameObject.tag == "Player") {
            manager.LoadLevel("Lv01");
        }
    }


}
