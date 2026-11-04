using System.Collections;
using UnityEngine;

public class Levadizo : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 posicionInicial;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;

        posicionInicial = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(CaerPuente());
        }
    }
     IEnumerator CaerPuente()
    {
        float tiempo = 0.5f;
        while ( tiempo>0)

        {
            transform.position = posicionInicial + (Vector3)Random.insideUnitCircle * 0.05f;

            tiempo -= Time.deltaTime;
            yield return null;

        }

        transform.position = posicionInicial;
        rb.bodyType = RigidbodyType2D.Dynamic;

    }
}
