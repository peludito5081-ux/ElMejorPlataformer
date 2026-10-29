using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   

    [SerializeField] int _puntosVida = 100;
    [SerializeField] int _vidaMaxima = 100;

    [SerializeField] int _puntosEscudo = 0;
    [SerializeField] int _escudoMaximo = 100;

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject panelDerrota;

    public int PuntosVida => _puntosVida;
    public int PuntosEscudo => _puntosEscudo;

    private void Start()
    {
        panelDerrota.SetActive(false);

        _puntosVida = Mathf.Clamp(_puntosVida, 0, _vidaMaxima);
        _puntosEscudo = Mathf.Clamp(_puntosEscudo, 0, _escudoMaximo);
    }

  
    public void SumarVida(int vida)
    {
        _puntosVida = Mathf.Clamp(
            _puntosVida + vida, 0, _vidaMaxima);
    }

    // Sumar escudo sin recuperar vida
    public void SumarEscudo(int escudo)
    {
        if (escudo <= 0) return;

        _puntosEscudo = Mathf.Clamp(
            _puntosEscudo + escudo, 0, _escudoMaximo);
    }

    // Recibir daño: primero escudo, después vida
    public void RestarVida(int daño)
    {
        if (daño <= 0 || _puntosVida <= 0) return;

        // Calcular cuánto daño absorbe el escudo
        int dañoAlEscudo = Mathf.Min(_puntosEscudo, daño);

        _puntosEscudo -= dañoAlEscudo;

        // El daño que sobra pasa a la vida
        int dañoRestante = daño - dañoAlEscudo;

        _puntosVida = Mathf.Max(0, _puntosVida - dañoRestante);
    }

    private void Update()
    {
        if (_puntosVida >= 80)
        {
            _uiManager.ColorBarra(Color.green);
        }
        else if (_puntosVida >= 40)
        {
            _uiManager.ColorBarra(Color.yellow);
        }
        else
        {
            _uiManager.ColorBarra(Color.red);
        }

        if (_puntosVida <= 0 && !panelDerrota.activeSelf)
        {
            panelDerrota.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

