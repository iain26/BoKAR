using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDataScript : MonoBehaviour {

    public Scene MapScene;

	// Use this for initialization
	void Start ()
    {
        DontDestroyOnLoad(gameObject);

        GameObject[] GDarray = GameObject.FindGameObjectsWithTag("GameData");

        if (GDarray.Length > 1)
        {
            Destroy(gameObject);
        }
	}

    public void LoadMap()
    {
        //Application.LoadLevel("Map");
        SceneManager.LoadScene(1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
