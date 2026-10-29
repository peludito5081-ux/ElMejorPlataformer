using TMPro;
using UnityEngine;

public class ConteoPuntos : MonoBehaviour
{
    public TMP_Text txtPoints;
    public int puntos = 0;
    public void SumarPuntos()
    {
        if (puntos < 100)
        {
            puntos += 4;

            if (puntos > 100)
            {
                Debug.Log("Ola");
            }
            txtPoints.text = puntos.ToString() + "/100";
        }
    }
}
