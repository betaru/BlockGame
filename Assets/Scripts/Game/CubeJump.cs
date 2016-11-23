using UnityEngine;
using System.Collections;

public class CubeJump : MonoBehaviour
{

    public GameObject mainCube;
    private bool animate;
    private const float ScratchSpeed = 0.8f;
    private float StartTime;
    private const float cubeScratchLimit = 0.4f;

    private void FixedUpdate()
    {
        if (animate && mainCube.transform.localScale.y > cubeScratchLimit)
            PressCube(-ScratchSpeed);
        else if (!animate)
            if (mainCube.transform.localScale.y < 1f)
                PressCube(ScratchSpeed * 3f);
            else if (mainCube.transform.localScale.y != 1f)
                mainCube.transform.localScale = new Vector3(1f, 1f, 1f);
    }

    private void OnMouseDown()
    {
        if (!mainCube.GetComponent<Rigidbody>()) return;
        animate = true;
        StartTime = Time.time;
    }

    private void OnMouseUp()
    {
        if (!mainCube.GetComponent<Rigidbody>()) return;
        animate = false;

        //Junp
        float force;
        var diff = Time.time - StartTime;
        if (diff < 3f)
            force = 190 * diff;
        else
            force = 300f;

        if (force < 60f)
            force = 60f;

        mainCube.GetComponent<Rigidbody>().AddRelativeForce(mainCube.transform.up * force);
        mainCube.GetComponent<Rigidbody>().AddRelativeForce(mainCube.transform.right * force);
    }

    private void PressCube( float force)
    {
        mainCube.transform.localPosition += new Vector3(0f, force * Time.deltaTime, 0f);
        mainCube.transform.localScale += new Vector3(0f, force * Time.deltaTime, 0f);
    }
}
