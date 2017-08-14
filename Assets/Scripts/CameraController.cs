using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Kamerayı topla birlikte hareket ettirmeye yarar.
public class CameraController : MonoBehaviour {

    private GameObject player;
    private Vector3 cameraKonumu;

    private void Awake()
    {
        player = GameObject.Find("Player");
    }
    private void Start()
    {
        cameraKonumu = this.transform.position - player.transform.position;
    }

    private void Update()
    {
        this.transform.position = cameraKonumu + player.transform.position;
    }
}
