using UnityEngine;
using System.Collections;

public class ScrollObjects : MonoBehaviour {
    public float speed = 1.5f;
    public float checkPos = 0;
    private RectTransform rec;

    private void Start()
    {
        rec = GetComponent<RectTransform>();
    }

    private void Update ()
    {
        if (rec.offsetMin.y == checkPos) return;
        rec.offsetMin += new Vector2(rec.offsetMin.x, speed);
        rec.offsetMax += new Vector2(rec.offsetMax.x, speed);
    }
}
