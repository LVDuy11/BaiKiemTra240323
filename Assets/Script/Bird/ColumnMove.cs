using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    public float speed = 3; // Tốc độ di chuyển của đối tượng


    private void FixedUpdate()
    {
        this.Move();
    }

    void Move()
    {
        this.transform.position += speed*Time.fixedDeltaTime*Vector3.left;
    }
}
