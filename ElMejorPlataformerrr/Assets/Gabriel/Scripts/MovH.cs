using Unity.VisualScripting;
using UnityEngine;

public class MovH : MonoBehaviour
{
    public float velocidad = 2f;
    public float distancia = 3f;

    private Vector3 posInicial;

    void Start()
    {
        posInicial = transform.position;
    }

    void Update()
    {
        float mov = Mathf.PingPong(Time.time * velocidad, distancia);
        transform.position = posInicial + Vector3.left * mov;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }

    }
}

