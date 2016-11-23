using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DetectClicks : MonoBehaviour {
    public Text playTxt, gameName;
    public GameObject buttons, m_cube, block, SpawnBlocks;

    private bool clicked;

    private void OnMouseDown ()
    {
        if (clicked) return;
        clicked = true;
        playTxt.gameObject.SetActive(false);
        gameName.text = "0";
        buttons.GetComponent<ScrollObjects>().speed = -5f;
        buttons.GetComponent<ScrollObjects>().checkPos = -150f;
        m_cube.GetComponent<Animation>().Play("StartGameCube");
        block.GetComponent<Animation>().Play("ReturnBLock");
        SpawnBlocks.GetComponent<SpawnBlocks>().enabled = true;
        m_cube.AddComponent<Rigidbody>();
    }
}
