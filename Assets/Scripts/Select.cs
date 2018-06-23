using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour {

    public GameObject CurrentObject = null;
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Ray cameraRay = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        RaycastHit cameraHit;

        if (Physics.Raycast(cameraRay, out cameraHit))
        {
            //Debug.Log(cameraHit.collider.gameObject + ": You found me!");
            if (Input.GetMouseButtonUp(0))
            {
                CurrentObject = cameraHit.collider.gameObject;
                Debug.Log(cameraHit.collider.gameObject + ": You clicked me!");
            }
        }
    }
}
