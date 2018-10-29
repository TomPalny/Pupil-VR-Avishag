using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_game_object : MonoBehaviour {

    //public Scene spacesScene;
    private GameObject[] rootGameobjects = null;
    private List<GameObject> sceneElements = null;
    private int index = 0;

    private void Start()
    {
        Scene scene = SceneManager.GetSceneByName("Spaces for Pupil") ;
        sceneElements = new List<GameObject>();
        rootGameobjects = scene.GetRootGameObjects();
        
        foreach (GameObject o in rootGameobjects)
        {
            if (o.tag.Equals("Untagged"))
            {
                sceneElements.Add(o);
                o.SetActive(false);
            }
        }

    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sceneElements[index].SetActive(false);
            index += 1;
            if (index >= sceneElements.Count)
            {
                index = 0;
            }
            sceneElements[index].SetActive(true);
        }
	}
}
