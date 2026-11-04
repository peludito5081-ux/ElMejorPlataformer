using TMPro;
using UnityEngine;

public class ConteoPuntos : MonoBehaviour
{
    public TMP_Text txtPoints;
    public int puntos = 0;
    public GameObject Victoria;
    public void SumarPuntos()
    {
        if (puntos < 100)
        {
            puntos += 4;

            if (puntos >= 100)
            {
                puntos = 0;
                txtPoints.text = puntos.ToString() + "Obtuviste una llave";
            }
            else
            {
                txtPoints.text = puntos.ToString() + "/100";
            }   
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")&& puntos >= 100)
        {
            Victoria.SetActive(true);
        }
    }
}
