using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAxis : MonoBehaviour {

    public float movSpeed = 5;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal"); //asse x -> tasto A/D ; produce [-1, 1]
        float v = Input.GetAxis("Vertical"); //asse z -> tasto W/S ; produce [-1, 1]
        Vector3 direction = new Vector3(h, 0f, v);
        direction.Normalize();

        transform.Translate(direction * movSpeed * Time.deltaTime);
    }
}
