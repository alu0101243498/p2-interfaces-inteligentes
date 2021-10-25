using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCylinder : MonoBehaviour
{
    private float speedRun = 10f;
    private float range;
    private GameObject target;
    private float minDistance = 3f;

    void Start() {
        target = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update() {
        range = Vector3.Distance(transform.position, target.transform.position);
        if (range < minDistance) {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, -1 * speedRun * Time.deltaTime);
            //transform.position = -Vector3.MoveTowards(target.position, transform.position, speedRun * Time.deltaTime);
        }
    }
}
