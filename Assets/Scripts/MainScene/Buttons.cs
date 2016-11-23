using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
