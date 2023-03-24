using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed; // Tốc độ di chuyển của đối tượng

    private Rigidbody2D rb;

    private void Start()
    {
        // Lấy component Rigidbody2D của đối tượng
        this.speed = Random.Range(1f, 6f);
        rb = GetComponent<Rigidbody2D>();

        // Thêm lực đẩy ban đầu để di chuyển đối tượng từ trái sang phải
        //rb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        this.Move();
    }

    void Move()
    {
        rb.AddForce(Vector2.right * speed * Time.deltaTime, ForceMode2D.Impulse);
    }
}
