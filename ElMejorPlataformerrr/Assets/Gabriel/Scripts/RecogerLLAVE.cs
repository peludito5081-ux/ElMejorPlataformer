using UnityEngine;

public class RecogerLlAVE : MonoBehaviour
{
    public LlavE controlLlave;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controlLlave.llaveObtenida = true;
            gameObject.SetActive(false);
        }
    }
}
