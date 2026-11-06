using UnityEngine;

public class LlavE : MonoBehaviour
{
    public GameObject Player;
    public GameObject llave;
    public bool llaveObtenida = false;

    public int puntosNecesarios = 100;

    public void AparecerLlave(int puntos)
    {
        if (puntos >= puntosNecesarios)
        {
            llave.transform.position =
                Player.transform.position + new Vector3(0, 2.5f, 0);

            llave.SetActive(true);
        }
    }
}

