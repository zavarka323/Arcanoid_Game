using UnityEngine;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidbody;

    [SerializeField]
    AudioSource audioSource;

    [SerializeField]
    AudioClip[] audioClip;

    [SerializeField]
    Sprite[] damagedBlockSprite;

    [SerializeField]
    GameObject effect;

    [SerializeField]
    GameObject gameOverUI;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity = new Vector2 (Random.Range(3f,10f), Random.Range(3f,10f) );       
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Lose"))
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0.0f;
            return;
        }
        if (col.gameObject.CompareTag("Block"))
        {
            GameObject obj = Instantiate(effect, transform.position, transform.rotation);
            var v = obj.GetComponent<ParticleSystem>().main;
            v.startColor = col.transform.GetComponent<SpriteRenderer>().color;
            Destroy(col.gameObject);
            audioSource.PlayOneShot(audioClip[1]);
        }
        if (col.gameObject.CompareTag("Block1"))
        {
            col.transform.GetComponent<SpriteRenderer>().sprite = damagedBlockSprite[1];
            col.gameObject.tag = "Block";            
            audioSource.PlayOneShot(audioClip[2]);
        }
        if (col.gameObject.CompareTag("Block2"))
        {
            col.transform.GetComponent<SpriteRenderer>().sprite = damagedBlockSprite[0];
            col.gameObject.tag = "Block1";            
            audioSource.PlayOneShot(audioClip[2]);
        }
        if (col.gameObject.CompareTag("Platform"))
            audioSource.PlayOneShot(audioClip[0]);
    }
    
}
