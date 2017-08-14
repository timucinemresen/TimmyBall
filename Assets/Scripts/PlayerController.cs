using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Topun klavyeyle hareket etmesini sağlar.
public class PlayerController : MonoBehaviour {

    public float speedPlayer = 8.5f;
    public Rigidbody rb;

    private CollectItems collectItems;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        collectItems = GetComponent<CollectItems>();
    }

    private void FixedUpdate()
    {
        if (collectItems.gameController.finished == false)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

            rb.AddForce(movement * speedPlayer);
        }
    }
}
