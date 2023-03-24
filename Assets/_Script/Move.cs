using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10;
    public float horizontal;
    public float vertical;


    private void Update()
    {
        this.Movemnet();
    }

    public void Movemnet()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 movement = new(horizontal, vertical,0);
        transform.position += movement * speed * Time.deltaTime;
    }
}
