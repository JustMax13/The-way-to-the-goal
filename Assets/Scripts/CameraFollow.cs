using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothSpeed = 5f;

    private Vector3 _offset;

    private void Awake()
    {
        if (_target == null)
        {
            Debug.LogError("Не вказано точку відслідковування");
            return;
        }

        _offset = transform.position - _target.position;
    }

    private void LateUpdate()
    {
        if (_target != null)
        {
            Vector3 targetPosition = _target.position + _offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, _smoothSpeed * Time.deltaTime);

            transform.position = smoothedPosition;
        }
    }
}