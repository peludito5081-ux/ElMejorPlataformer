using UnityEngine;

public class DetectorSuelo : MonoBehaviour
{
    public bool estaEnSuelo;

    private void OnTriggerStay2D(Collider2D collision)
    {
        // if (collision.CompareTag("Terreno SUELO"))
        {
            estaEnSuelo = true;
            Debug.Log("El objeto está sobre el suelo.");
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        {
            // Opcional: Verificar también el tag al salir para evitar conflictos con otros triggers
            // if (collision.CompareTag("Suelo"))
            {
                estaEnSuelo = false;
                Debug.Log("Estoy saltando o cayendo");
            }
        }
    }
}