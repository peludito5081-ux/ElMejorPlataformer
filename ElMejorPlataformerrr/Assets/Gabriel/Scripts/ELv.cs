using UnityEngine;

public class ELv : MonoBehaviour
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
        transform.position = posInicial + Vector3.up * mov;
    }
}
