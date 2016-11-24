using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
    private void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void OnMouseDown()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
}
