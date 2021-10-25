using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehaviour : MonoBehaviour
{
    private GameObject player;
    private GameObject[] sphere;
    private float range1, range2;
    private float minDistance = 5f;

    // Start is called before the first frame update
    void Start() {
        player = GameObject.Find("player");
        sphere = GameObject.FindGameObjectsWithTag("sphere");
    }

    // Update is called once per frame
    void Update() {
        range1 = Vector3.Distance(transform.position, player.transform.position);
        if (range1 < minDistance) {
            transform.localScale -= new Vector3 (0.002f,0.002f,0.002f);
        }
        foreach(GameObject i in sphere) {
            range2 = Vector3.Distance(transform.position, i.transform.position);
            if (range2 < minDistance) {
                transform.localScale += new Vector3 (0.002f,0.002f,0.002f);
            }
        }
    }
}
