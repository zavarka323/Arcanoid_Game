using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody ballRigidbody;

    void Start()
    {
        ballRigidbody.velocity = Vector3.up * Random.Range(speed/5f, speed/2f) + Vector3.right * Random.Range(speed/5f, speed/2f);
    }

    [SerializeField]
    [Range(10f,100f)]
    float speed = 40f;
    void Update()
    {
        transform.position += Input.GetAxis("Horizontal") * Vector3.right * speed * Time.deltaTime;
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x,-19f,19f), transform.position.y, transform.position.z); 
    }
}
