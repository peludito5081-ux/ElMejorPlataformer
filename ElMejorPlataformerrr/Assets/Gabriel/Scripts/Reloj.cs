using UnityEngine;
using TMPro;
public class Reloj : MonoBehaviour
{
    public TMP_Text Textotiempo;
    public float tiempo = 120f;

    public void SumarTiempo()
    {
        tiempo += 10f;
    }
    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            int minutos = Mathf.FloorToInt(tiempo / 60);
            int segundos = Mathf.FloorToInt(tiempo % 60);
            Textotiempo.text = minutos.ToString("00") + ":" + segundos.ToString("00");

        }
        else
        {
            tiempo = 0;
            Textotiempo.text = "00:00";
            Time.timeScale = 0f;
        }
    }

}

