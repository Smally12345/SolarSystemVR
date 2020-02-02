using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotation : MonoBehaviour
{
	public float xangle, yangle, zangle;
    //public float speed;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 	   	target.transform.Rotate(xangle, yangle, zangle, Space.Self);
    }
}
