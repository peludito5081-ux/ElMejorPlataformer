using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float velocidad = 2f;
    public float distanciaMaxima = 5f;

    private Vector3 posicionInicial;
    private int direccion = 1;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        posicionInicial = transform.position;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Mover el slime
        transform.Translate(
            Vector2.right * direccion * velocidad * Time.deltaTime
        );

        // Calcular la distancia desde el inicio
        float distancia = Mathf.Abs(
            transform.position.x - posicionInicial.x
        );

        // Si llega a la distancia máxima, cambiar de dirección
        if (distancia >= distanciaMaxima)
        {
            direccion *= -1;

            // Cambiar hacia dónde mira el slime
            if (spriteRenderer != null)
            {
                spriteRenderer.flipX = direccion < 0;
            }

            // Actualizar el punto de referencia
            posicionInicial = transform.position;
        }
    }
}