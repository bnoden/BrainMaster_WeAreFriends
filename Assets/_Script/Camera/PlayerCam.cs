using UnityEngine;
using System.Collections;

public class PlayerCam : MonoBehaviour {

    public GameObject player;
    Vector3 offset;

    float Xmin = -2.0f;
    float Xmax = 146.0f;
    float Ymin = -1.0f;
    float Ymax = 8.0f;

	// Use this for initialization
	void Start () {
	    offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
	    MoveCam();
	}
    
    void MoveCam() {
        Vector3 playerPos = player.transform.position;
        Vector3 camPos = transform.position;
        camPos.x = Mathf.Clamp(playerPos.x, Xmin, Xmax);
        camPos.y = Mathf.Clamp(playerPos.y, Ymin, Ymax);

        transform.position = camPos;
    }

    public void SetXmin(float x) {
        Xmin = x;
    }

    public float GetXmin() { return Xmin; }




}
