using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    private Transform _target;
    private float _smoothSpeed = 0.025f;

    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = _target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);
        transform.position = smoothPosition;

        transform.LookAt(_target);
    }

}
