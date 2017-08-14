using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour {

    public GameObject controlGameObject;
    [HideInInspector] public GameController gameController;

    private void Start()
    {
        gameController = controlGameObject.GetComponent<GameController>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            Destroy(other.gameObject);
            gameController.geriSayim += 2f;
            gameController.puan += 1;

        }   
    }
}
