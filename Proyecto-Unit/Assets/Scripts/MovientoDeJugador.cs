using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovientoDeJugador : MonoBehaviour
{


    public float speed=5;
    float movientoHorizontal;
    public float maxX = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        movientoHorizontal = Input.GetAxis("Horizontal");
        if ((movientoHorizontal > 0 && transform.position.x < maxX) || (movientoHorizontal < 0 && transform.position.x > -maxX))
        {
            transform.position += Vector3.right * movientoHorizontal * speed * Time.deltaTime;
        }
    }
}
