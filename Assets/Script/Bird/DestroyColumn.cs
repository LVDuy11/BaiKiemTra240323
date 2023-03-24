using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyColumn : MonoBehaviour
{
    void Start()
    {
        Vector3 objectPosition = Camera.main.WorldToViewportPoint(transform.position);
        Debug.Log(Camera.main.WorldToViewportPoint(transform.position));
    }

    void Update()
    {
        Vector3 objectPosition = Camera.main.WorldToViewportPoint(transform.position);

        if (objectPosition.x < 0 || objectPosition.x > 1)
        {
            // Nếu đối tượng ra khỏi màn hình thì gọi hàm để làm nó biến mất
            Destroy(gameObject);
        }
    }
}
