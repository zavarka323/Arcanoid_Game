using UnityEngine;

public class BallControl : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidbody;

    [SerializeField]
    Sprite smallDamagedSprite;
    [SerializeField]
    Sprite bigDamagedSprite;

    void Start()
    {
        rigidbody.velocity = new Vector2 (Random.Range(2f,8f),Random.Range(2f,8f));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Lose"))
            Debug.Log ("LOOOOSER! ");
        if (col.gameObject.CompareTag("Block"))
            Destroy(col.gameObject);
        if (col.gameObject.CompareTag("Block1"))
        {
            col.gameObject.tag = "Block";
            col.gameObject.GetComponent<SpriteRenderer>().sprite = bigDamagedSprite;
        }
        if (col.gameObject.CompareTag("Block2"))
        {
            col.gameObject.tag = "Block1";
            col.gameObject.GetComponent<SpriteRenderer>().sprite = smallDamagedSprite;
        }
    }

}
