using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyClone : MonoBehaviour {

    private GameObject gameControllerObject;
    private GameController gameController;

	// Use this for initialization
	void Start () {
        gameControllerObject = GameObject.Find("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gameController.finished == true)
            Destroy(gameObject);
	}
}
