using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapingScript : MonoBehaviour {
    public Material SwapingMaterial;
	// Use this for initialization
	void Start () {
		
	}
	public void swap()
    {
        Material tmpMat = gameObject.GetComponent<Renderer>().material;
        gameObject.GetComponent<Renderer>().material = SwapingMaterial;
        SwapingMaterial = tmpMat;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
