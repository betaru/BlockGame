using UnityEngine;
using System.Collections;

public class SpawnStars : MonoBehaviour {

    public GameObject star;

	// Use this for initialization
	void Start ()
	{
	    StartCoroutine(Spawn());
	}

    private IEnumerator Spawn ()
    {
        while (true)
        {
            var pos = Camera.main.ScreenToWorldPoint(new Vector3(Random.Range(0, Screen.width),
                Random.Range(0, Screen.height), Camera.main.farClipPlane) / 2);
            Instantiate(star, pos, Quaternion.Euler (0, 0, Random.Range (0f, 360f)));
            yield return new WaitForSeconds(5.1f);
        }
	}
}
