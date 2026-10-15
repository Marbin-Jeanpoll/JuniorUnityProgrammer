using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float speed = 500;

    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Time.deltaTime);     
    }
}
