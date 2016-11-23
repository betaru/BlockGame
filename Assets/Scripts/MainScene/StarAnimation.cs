using UnityEngine;
using System.Collections;

public class StarAnimation : MonoBehaviour {

    private SpriteRenderer star;
    private const float _movementSpeed = 0.1f;

    // Use this for initialization
    void Start () {
        star = GetComponent<SpriteRenderer>();
        Destroy(gameObject, 4.9f);
    }
	
	// Update is called once per frame
	void Update () {
        star.color = new Color(star.color.r, 
            star.color.g, star.color.b, Mathf.PingPong(Time.time/2.5f, 1.0f));
        // move star
        transform.position += transform.up * Time.deltaTime * _movementSpeed;
	}
}
