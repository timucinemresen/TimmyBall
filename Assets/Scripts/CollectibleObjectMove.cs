using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Kullanıcının toplayabileceği küplerin kendi ekseninde dönmesini sağlar

public class CollectibleObjectMove : MonoBehaviour {

    private float speed = 4.0f;

    private void Update()
    {
        transform.Rotate(new Vector3(15, 25, 20) * speed * Time.deltaTime );
    }
}
