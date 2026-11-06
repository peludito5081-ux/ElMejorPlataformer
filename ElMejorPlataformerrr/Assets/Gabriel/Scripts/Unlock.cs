using UnityEngine;

public class Unlock: MonoBehaviour
{
    public LlavE controlLlave;
    public GameObject Victoria;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && controlLlave.llaveObtenida)
        {
            Victoria.SetActive(true);
            gameObject.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
