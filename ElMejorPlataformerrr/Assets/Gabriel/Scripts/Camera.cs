using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform _objetivo;


    private void Update()
    {
        this.transform.position = new Vector3(_objetivo.position.x, this._objetivo.position.y, this.transform.position.z);
    }
}
