using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour {

	private Muwer muwer;
	// Use this for initialization
	void Start () {
        muwer = Muwer.rid;
	}

    public void Jump()
    {
        muwer.Jump();
    }
    public void Muve(float nap)
    {
        muwer.muve = new Vector3(0, muwer.muve.y, nap);
    }
	void Update () {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Muve(Input.GetAxis("Horizontal"));
        }
		
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.Tab))
        {
            //Interface.rid.Menu();
        }
    }
}
