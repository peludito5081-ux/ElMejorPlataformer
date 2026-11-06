using TMPro;
using UnityEngine;

public class ConteoPuntos : MonoBehaviour
{
    public TMP_Text txtPoints;
    public int puntos = 0;
    public GameObject Victoria;
    public LlavE llave;
    public void SumarPuntos()
    {
        if (puntos < 100)
        {
            puntos += 4;

            if (puntos >= 100)
            {
                puntos = 100;
                txtPoints.text = puntos.ToString() + "Obtuviste una llave";
                llave.AparecerLlave(puntos);
            }
            else
            {
                txtPoints.text = puntos.ToString() + "/100";
            }

        }
    }
}

