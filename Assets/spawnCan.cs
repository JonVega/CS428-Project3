using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnCan : MonoBehaviour
{

	public GameObject spawn;
    public GameObject spawnController;

    // Start is called before the first frame update
    void Start()
    {

        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        spawn.SetActive(false);
        GameObject x = (GameObject)Instantiate(spawn, new Vector3(5.827f,0.397f, 3.34f), Quaternion.identity);
        Debug.Log("can start position is: " + x.transform.position);
        //x.transform.position = new Vector3(0f,0f, 0f);
        x.SetActive(true);
        
        spawnController.SetActive(false);
    }
}
