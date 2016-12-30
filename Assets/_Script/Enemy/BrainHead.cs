using UnityEngine;
using System.Collections;

public class BrainHead : MonoBehaviour {

    public GameObject player;

    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        Jump();
        Move();
    }

    public void Jump() {
        //if (playerPos.x%8.0 == 0) { GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0); }

        if (player.transform.position.x%4.0 == 0) {
            if (GetComponent<Rigidbody2D>().velocity.y > -1.0f && GetComponent<Rigidbody2D>().velocity.y < 0.5f) {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 4, 0);
            }
        }
    }

    public void Move() {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.02f);
    }
    
}
