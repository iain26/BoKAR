using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mgr : MonoBehaviour {
    
    Ray ray;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.touchCount > 0)
        {
            ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "ObjectOnMap")
                {
                    Application.LoadLevel(hit.collider.name + "Scene");
                }
            }
        }
    }
}
