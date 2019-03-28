using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerVR : MonoBehaviour {

    public float speed;
    Rigidbody rb;
    Vector3 mov = new Vector3(0,0,0);

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(mov * speed);

	}

    void Up(float x) {

        mov += new Vector3(x,0,0);
    }

    void Down(float x)
    {

        mov += new Vector3(x, 0, 0) * -1;
    }

    void Left(float z) {

        mov += new Vector3(0, 0, z) * -1;

    }

    void Right(float z)
    {

        mov += new Vector3(0, 0, z);

    }

    void Exit() {

        mov += new Vector3(0,0,0);
    }

}
