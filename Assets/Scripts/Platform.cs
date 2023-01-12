using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]
    [Range(10f,100f)]
    float speed = 20f;

    void Update()
    {
        transform.Translate(speed * Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x, -7.6f, 7.6f), 
        transform.position.y, transform.position.z);
    }
}
