using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int puntos = 0;
    public int puntosNecesarios = 100;

    public GameObject objetoDesbloqueable;
    public TMP_Text textoPuntos;

    public bool objetoDesbloqueado = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (objetoDesbloqueable != null)
        {
            objetoDesbloqueable.SetActive(false);
        }

        ActualizarTexto();
    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;

        ActualizarTexto();

        if (puntos >= puntosNecesarios && !objetoDesbloqueado)
        {
            objetoDesbloqueado = true;

            if (objetoDesbloqueable != null)
            {
                objetoDesbloqueable.SetActive(true);
            }

            Debug.Log("¡Objeto desbloqueado!");
        }
    }

    private void ActualizarTexto()
    {
        if (textoPuntos != null)
        {
            textoPuntos.text = "Puntos: " + puntos;
        }
    }
}

