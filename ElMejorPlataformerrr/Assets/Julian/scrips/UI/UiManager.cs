using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Image _barra;
    [SerializeField] private Image _barraAzul;
    [SerializeField] int _puntosVida;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] int _puntosEscudo = 0;
    [SerializeField] int _escudoMaximo = 100;
    [SerializeField] private TextMeshProUGUI _textoPuntos;

public void ActualizarPuntos(int puntos)
    {
        _textoPuntos.text = "estrellas: " + puntos;
    }

    public void SumarFillAmount(float amount)

    {
        _barra.fillAmount += amount;
       
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount = _barra.fillAmount - amount;
       
    }

    public void ActualizarBarraEscudo(int escudoActual, int escudoMaximo)
    {
        if (_barraAzul == null)
        {
            Debug.LogError("no se ha asignado la barra de escudo en Iumanager");
        }

        if (_escudoMaximo <= 0) return;
        {
            _barraAzul.fillAmount = Mathf.Clamp01((float)escudoActual / _escudoMaximo);
        }

    }

    public void ColorBarra(Color color)
    {
        _barra.color = color;

    }
} 

