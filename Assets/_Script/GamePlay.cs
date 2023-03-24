using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay : MonoBehaviour
{
    public int diem = 0;
    public Text diemUI;

    private void Start()
    {
        diemUI.text = diem.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            diem++;
            diemUI.text = diem.ToString();
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        Vector3 objectPosition = Camera.main.WorldToViewportPoint(transform.position);

        if (objectPosition.x < 0 || objectPosition.x > 1 || objectPosition.y < 0 || objectPosition.y > 1)
        {
            //StartCoroutine(FadeOutAndDestroy(gameObject));
            SceneManager.LoadScene(0);
        }
    }
}
