using UnityEngine;
using System.Collections;

public class CubeJump : MonoBehaviour
{

    public GameObject MainCube;
    private bool _animate;
    private const float _ScratchSpeed = 0.8f;
    private float _startTime;
    private static readonly Vector3 _cubeScaleDefault = new Vector3(1f, 1f, 1f);
    private const float _minForceSpeed = 60f;
    private const float _maxForceSpeed = 300f;
    private const float _midSpeedCoeff = 190;
    private const float _diffMin = 3f;
    private const float _cubeScaleMin = 1f;
    private const float _SpeedUpper = 3f;
    private const float _CubeScaleFast = 1f;
    private const float _CubeScratchLimit = 0.4f;

    private void FixedUpdate()
    {
        if (_animate && MainCube.transform.localScale.y > _CubeScratchLimit)
            PressCube(-_ScratchSpeed);
        else if (!_animate)
            if (MainCube.transform.localScale.y < _CubeScaleFast)
                PressCube(_ScratchSpeed * _SpeedUpper);
            else if (MainCube.transform.localScale.y != _cubeScaleMin)
                MainCube.transform.localScale = _cubeScaleDefault;
    }

    private void OnMouseDown()
    {
        if (!MainCube.GetComponent<Rigidbody>()) return;
        _animate = true;
        _startTime = Time.time;
    }

    private void OnMouseUp()
    {
        if (!MainCube.GetComponent<Rigidbody>()) return;
        _animate = false;

        //Junp
        float force;
        var diff = Time.time - _startTime;
        if (diff < _diffMin)
            force = _midSpeedCoeff * diff;
        else
            force = _maxForceSpeed;

        if (force < _minForceSpeed)
            force = _minForceSpeed;

        MainCube.GetComponent<Rigidbody>().AddRelativeForce(MainCube.transform.up * force);
        MainCube.GetComponent<Rigidbody>().AddRelativeForce(MainCube.transform.right * force);
    }

    private void PressCube( float force)
    {
        MainCube.transform.localPosition += new Vector3(0f, force * Time.deltaTime, 0f);
        MainCube.transform.localScale += new Vector3(0f, force * Time.deltaTime, 0f);
    }
}
