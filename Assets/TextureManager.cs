using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureManager : MonoBehaviour {
    public Material SwapingMaterial;
    public KeyCode swappingKey = KeyCode.Space;
	// Use this for initialization
	void Start () {
		
	}
	public void swap()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
        {
            if (go.GetComponent<Renderer>())
            {
                if (go.GetComponent<SwapingScript>())
                {
                    go.GetComponent<SwapingScript>().swap();
                }
                else
                {
                    SwapingScript tmp_script =  go.AddComponent<SwapingScript>();
                    tmp_script.SwapingMaterial = SwapingMaterial;
                    tmp_script.swap();
                }
            }
        }
    }
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(swappingKey))
        {
            swap();
        }
    }
}
