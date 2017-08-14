using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateClone : MonoBehaviour
{
    public Transform parent;
    public GameObject cloneCube;
    private GameController gameController;
    public Vector3 position;

    private void Start()
    {
        gameController = GetComponent<GameController>();
        InvokeRepeating("SpawnObject", 2.5f,2.5f);
    }

    private void randomPosition()
    {
        float x = Random.Range(-8.0f, 8.0f);
        float z = Random.Range(-8.0f, 8.0f);
        position = new Vector3(x, 0.9f, z);
    }

    private void CreateGameClone()
    {
        Instantiate(cloneCube, position, Quaternion.identity, parent);
    }

    private void SpawnObject()
    {
        if (gameController.basladi == true)
        {
            if (gameController.finished == false)
            {
                randomPosition();
                CreateGameClone();
            }
        }
    }
}
