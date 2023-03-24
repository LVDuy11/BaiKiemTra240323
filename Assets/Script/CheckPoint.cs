using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckPoint : MonoBehaviour
{

    void Start()
    {
        Vector3 objectPosition = Camera.main.WorldToViewportPoint(transform.position);
        Debug.Log(objectPosition.ToString());
    }

    void Update()
    {
        Vector3 objectPosition = Camera.main.WorldToViewportPoint(transform.position);

        if (objectPosition.x < 0 || objectPosition.x > 1 || objectPosition.y < 0 || objectPosition.y > 1)
        {
            //StartCoroutine(FadeOutAndDestroy(gameObject));
            Destroy(gameObject);
        }
    }

    IEnumerator FadeOutAndDestroy(GameObject objectToDestroy)
    {
        SpriteRenderer spriteRenderer = objectToDestroy.GetComponent<SpriteRenderer>();
        Color color = spriteRenderer.color;

        while (color.a > 0)
        {
            color.a -= Time.deltaTime;
            spriteRenderer.color = color;
            yield return null;
        }

        // Xóa đối tượng
        Destroy(objectToDestroy);
    }


    private void OnMouseDown()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Collider2D collider = GetComponent<Collider2D>();

        //    if (collider != null && collider.CompareTag("Player"))
        //    {
        //        Debug.Log("Đã click vào đối tượng có tag là 'Player'");
        //        StartCoroutine(FadeOutAndDestroy(collider.gameObject));
        //    }
        //}
    }



    
}
