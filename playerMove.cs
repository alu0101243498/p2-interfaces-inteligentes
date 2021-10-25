using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed = .1f;
    private Rigidbody rigid;
    private int puntuacion = 0;
    private GameObject[] cylinderA;
    private Vector3 corrector;
    //private float speedRun = 20f;
    //private GameObject[] cylinder2Set;

    void Start() {
        rigid = GetComponent<Rigidbody> ();
        cylinderA = GameObject.FindGameObjectsWithTag("cylinderA");
        //cylinder2Set = GameObject.FindGameObjectsWithTag("Cylinder2");
    }

    // Update is called once per frame
    void FixedUpdate() {
        // Movimiento del personaje
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        rigid.AddForce(moveDirection * speed);

        /*
        // Cilindros que se alejan al acercarse el jugador
        foreach(GameObject i in cylinder2Set) {
            range = Vector3.Distance(transform.position, i.transform.position);
            if (range < minDistance) {
                transform.position = Vector3.MoveTowards(i.transform.position, transform.position, -1 * speedRun * Time.deltaTime);
                transform.position = -Vector3.MoveTowards(transform.position, i.transform.position, speedRun * Time.deltaTime);
            }
        }*/

        // Al pulsar espacio lo mueve hacia fuera de él
        corrector = new Vector3(3f, 0f, 3f);
        if (Input.GetKey(KeyCode.Space)) {
            foreach(GameObject i in cylinderA) {
                i.transform.position = transform.position + corrector; 
            }
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Cylinder1") {
            col.gameObject.transform.localScale += new Vector3 (0.2f,0.2f,0.2f);
            puntuacion++;
            Debug.Log("Puntuacion: " + puntuacion);
        }
    }
}
