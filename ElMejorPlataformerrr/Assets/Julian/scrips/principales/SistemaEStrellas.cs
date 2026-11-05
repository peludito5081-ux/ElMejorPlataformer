using UnityEngine;

public class SistemaEstrellas : MonoBehaviour
{
    [Header("Contador de estrellas")]
    [SerializeField] private int _puntos = 0;

    [Header("Interfaz")]
    [SerializeField] private UIManager _uiManager;

    [Header("Desbloqueo")]
    [SerializeField] private GameObject _objetoDesbloqueable;
    [SerializeField] private int _puntosNecesarios = 3;

    private void Start()
    {
        _uiManager.ActualizarPuntos(_puntos);

        ComprobarDesbloqueo();
    }

    public void SumarPuntos(int cantidad)
    {
        if (cantidad <= 0) return;

        _puntos += cantidad;

        _uiManager.ActualizarPuntos(_puntos);

        ComprobarDesbloqueo();
    }

    private void ComprobarDesbloqueo()
    {
        if (_puntos >= _puntosNecesarios)
        {
            _objetoDesbloqueable.SetActive(true);
        }
    }
}