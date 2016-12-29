using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    static float walk = 2.0f, sprint = walk+2.0f, step;
    public Vector3 playerPos;
    public AudioSource jumpFX;

    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        step = Time.deltaTime*walk;

        if(Input.GetKey(KeyCode.LeftShift)) {
            step = Time.deltaTime*sprint;
        }

        Jump();
        Move(step);
    }

    public void Jump() {
        if (Input.GetKeyUp(KeyCode.Space)) {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        if (Input.GetKeyDown(KeyCode.Space)) {
            if(Input.GetKey(KeyCode.LeftShift)) {
        }
            if (GetComponent<Rigidbody2D>().velocity.y > -0.5f && GetComponent<Rigidbody2D>().velocity.y < 0.5f) {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 8, 0);
                jumpFX.Play();
            }
        }
    }

    public void Move(float speed) {
        bool UP = Input.GetKey(KeyCode.UpArrow), DOWN = Input.GetKey(KeyCode.DownArrow),
            LEFT = Input.GetKey(KeyCode.LeftArrow), RIGHT = Input.GetKey(KeyCode.RightArrow);
        
        playerPos = transform.position;
        
        if (LEFT) {
            playerPos.x-=step;
        }
        if (RIGHT) {
            playerPos.x+=step;
        }
        transform.position = playerPos;
    }




}
