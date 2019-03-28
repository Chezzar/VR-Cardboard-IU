using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubMovePlayer : MonoBehaviour {

    Transform player;
    Rigidbody playerRB;
    Vector3 playerVector;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").gameObject.transform;
        playerRB = player.GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        playerRB.AddForce(playerVector);
    }

    // Update is called once per frame
    public void PlayerMovEnter_X (float x) {


        //playerVector = new Vector3(x, 0, 0);

        if (this.transform.position.x > player.transform.position.x)
        {
            Debug.Log("Up");
            player.SendMessage("Up", 1);
        }

        else if (this.transform.position.x < player.transform.position.x) {

            Debug.Log("Down");
            player.SendMessage("Down", 1);
        }
            

    }

    public void PlayerMovEnter_Z(float x)
    {


        //playerVector = new Vector3(x, 0, 0);

        if (this.transform.position.z < player.transform.position.z)
        {
            Debug.Log("Left");
            player.SendMessage("Left", 1);
        }

        else if (this.transform.position.z > player.transform.position.z)
        {

            Debug.Log("Right");
            player.SendMessage("Right", 1);
        }


    }

    public void PlayerMovExit()
    {

        Debug.Log("Detenido");
        player.gameObject.SendMessage("Exit");


    }

}
