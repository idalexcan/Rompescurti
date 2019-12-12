using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text advice;
    public Transform playerTransform;
    public GameObject winText;

    void Awake()
    {
        instance = this;
        
        foreach (var item in GameObject.FindGameObjectsWithTag("Obstaacle"))
        {
            item.transform.localScale = new Vector3(item.transform.localScale.x, 5, item.transform.localScale.z);
        }
        foreach (var item in GameObject.FindGameObjectsWithTag("WithRigid"))
        {
            if (item.GetComponent<MeshCollider>())
            {
                item.GetComponent<MeshCollider>().enabled = false;
            }
        }
    }

    void Update()
    {
        
    }
}
