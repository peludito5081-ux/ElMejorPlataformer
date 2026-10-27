using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private Image _barraza;
    public void SumarFillAmount(float amount)
    {
        _barraza.fillAmount += amount;
        _barraza.fillAmount = _barraza.fillAmount + amount;
    }

    public void RestarFillAmount(float amount)
    {
        _barraza.fillAmount =_barraza.fillAmount - amount;
    }

    public void ColorBarra(Color color)
    {
        _barraza.color = color;
    }
}
