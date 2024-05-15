using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        var position = transform.localPosition;

        position.x +=_speed ;
        
        transform.localPosition = position;
    }
}
