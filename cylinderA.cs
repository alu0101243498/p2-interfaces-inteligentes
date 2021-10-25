using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderA : MonoBehaviour
{
    private float range;
    private GameObject target;
    public float speed = 10f;
    public float minDistance = 5f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        range = Vector3.Distance(transform.position, target.transform.position);
        if (Input.GetKey(KeyCode.Space)) {
            if (range < minDistance) {
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, -1 * speed  * Time.deltaTime);
            }
        }
    }
}
