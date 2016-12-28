using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public GameObject player;
    Vector3 offset;

    

	// Use this for initialization
	void Start () {
	    offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
	    MoveCam();
	}
    
    void MoveCam() {

        float Xmin = -0.6f;
        float Xmax = 10.0f;
        float Ymin = -1.0f;
        float Ymax = 3.0f;
        Vector3 playerPos = player.transform.position;
        Vector3 camPos = transform.position;

        camPos.x = Mathf.Clamp(playerPos.x, Xmin, Xmax);
        camPos.y = Mathf.Clamp(playerPos.y, Ymin, Ymax);

        transform.position = camPos;
    }




}
