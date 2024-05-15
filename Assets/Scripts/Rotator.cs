using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotationAngle;

    private void Update()
    {
        transform.RotateAround(transform.up, _rotationAngle);
    }
}
