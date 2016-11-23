using UnityEngine;
using System.Collections;

public class SpawnBlocks : MonoBehaviour
{

    public GameObject dBlock;
    private GameObject blockInst;
    private Vector3 blockPos;
    private const float _speed = 7f;

    // test

    // Use this for initialization
    private void Start ()
	{
	    blockPos = new Vector3(x: Random.Range(1f, 1.5f), y: Random.Range(-3f, 1f), z: 0f);
	    blockInst = Instantiate(dBlock, new Vector3(x: 5f, y: -6f, z: 0), Quaternion.identity) as GameObject;
	    blockInst.transform.localScale = new Vector3(RandScale(), blockInst.transform.localScale.y,
	        blockInst.transform.localScale.z);

	}

	// Update is called once per frame
    private void Update () {
	    if (blockInst.transform.position != blockPos)
	    {
	        blockInst.transform.position = Vector3.MoveTowards(blockInst.transform.position, blockPos,
	            Time.deltaTime * _speed);

	    }

	}

    private static float RandScale()
    {
        return Random.Range(1.2f, Random.Range(0, 100) > 80 ? 2f : 1.5f);
    }
}
