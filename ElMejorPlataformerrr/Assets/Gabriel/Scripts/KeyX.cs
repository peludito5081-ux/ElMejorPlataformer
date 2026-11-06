using TMPro;
using UnityEngine;

public class KeyX : MonoBehaviour
{
    public TMP_Text txtPoints;
    public TMP_Text txtKey;
    public int puntos = 0;
    public int llave = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SumarPuntos()
    {
        if (puntos == 100)
            {
                txtKey.text = llave.ToString() + "/100";

            }
    }
}
