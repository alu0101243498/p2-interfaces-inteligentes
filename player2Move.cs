using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Move : MonoBehaviour
{
    public float speed = .1f;
    private Rigidbody rigid;

    // Start is called before the first frame update
    void Start() {
        rigid = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetKey(KeyCode.I)) {
            Vector3 playerPosition = transform.position;
            playerPosition.z += 0.1f;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.J)) {
            Vector3 playerPosition = transform.position;
            playerPosition.x -= 0.1f;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.L)) {
            Vector3 playerPosition = transform.position;
            playerPosition.x += 0.1f;
            transform.position = playerPosition;
        }
        if (Input.GetKey(KeyCode.M)) {
            Vector3 playerPosition = transform.position;
            playerPosition.z -= 0.1f;
            transform.position = playerPosition;
        }
    }
}
