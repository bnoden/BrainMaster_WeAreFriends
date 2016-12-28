using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public GameObject player;
    public Vector3 playerPos;
    static float walk = 2.0f;
    static float sprint = walk+2.0f;
    static float step;

	// Use this for initialization
	void Start () {
	    playerPos = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	    Move();
	}

    public void Attack() {
        if (Input.GetButtonDown("Attack")) {
            Debug.Log("SMAAAAAAAAAAAAASH!");
        }
    }

    public void Move() {
        Attack();
        step = Time.deltaTime*walk;
        if(Input.GetKey(KeyCode.LeftShift)) {
            step = Time.deltaTime*sprint;
        }
        if(Input.GetKey(KeyCode.UpArrow)) {
            playerPos.y+=step;
        }
        if(Input.GetKey(KeyCode.DownArrow)) {
            playerPos.y-=step;
        }
        if(Input.GetKey(KeyCode.LeftArrow)) {
            playerPos.x-=step;
        }
        if(Input.GetKey(KeyCode.RightArrow)) {
            playerPos.x+=step;
        }
        player.transform.position = playerPos;
    }




}
