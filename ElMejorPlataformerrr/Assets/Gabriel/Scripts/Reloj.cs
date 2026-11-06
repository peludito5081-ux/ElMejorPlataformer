using UnityEngine;
using TMPro;
using static UnityEngine.Rendering.DebugUI;
public class Reloj : MonoBehaviour
{
    public TMP_Text Textotiempo;
    public float tiempo = 240f;
    public GameObject panelGG;

    public void SumarTiempo()
    {
        tiempo += 20f;
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
            panelGG.SetActive(true);
        }
    }

}

