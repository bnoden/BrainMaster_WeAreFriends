using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    static float walk = 1.0f, sprint = walk+1.0f, step;
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

    public void Attack() {
        if (Input.GetButtonDown("Attack")) {
            Debug.Log("SMAAAAAAAAAAAAASH!");
        }
    }

    public void Jump() {
        if (Input.GetButtonDown("Jump")) { GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0); }

        if (Input.GetButtonDown("Jump")) {
            if (GetComponent<Rigidbody2D>().velocity.y > -1.0f && GetComponent<Rigidbody2D>().velocity.y < 0.5f) {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 4, 0);
                jumpFX.Play();
            }
        }
    }

    public void Move(float speed) {
        playerPos = transform.position;
        
        if (Input.GetKey(KeyCode.LeftArrow)) { playerPos.x-=step; }
        if (Input.GetKey(KeyCode.RightArrow)) { playerPos.x+=step; }

        transform.position = playerPos;
    }




}
