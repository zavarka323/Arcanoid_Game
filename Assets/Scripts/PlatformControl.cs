using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    [SerializeField]
    [Range(10f,100f)]
    float speed = 40f;
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));
        transform.position = new Vector3 (Mathf.Clamp(transform.position.x,-6.75f, 6.75f), 
        transform.position.y, transform.position.z);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        animator.Play("Platform");
    }
}
