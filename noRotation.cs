using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noRotation : MonoBehaviour
{
    private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody> ();    
    }

    // Update is called once per frame
    void Update()
    {
        rigid.freezeRotation = true;
    }
}
