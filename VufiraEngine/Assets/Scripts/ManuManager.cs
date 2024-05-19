using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject panel;
    void Start()
    {
        panel = GameObject.Find("Panel");
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void estadoPanel(bool val)
    {
       panel.SetActive(val);
    }
}
