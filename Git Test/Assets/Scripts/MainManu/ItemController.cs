using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI startLabel;
    public TMPro.TextMeshProUGUI quitLabel;
    uint selected;
    // Start is called before the first frame update
    void Start()
    {
        selected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            selected += 1;
            Select();
        }
        if (Input.GetKeyDown("down"))
        {
            selected -= 1;
            Select();
        }
        if (Input.GetKeyDown("return") || Input.GetKeyDown("space"))
        {
            Debug.Log(selected % 2);
        }
    }

    void Select()
    {
        uint n = selected % 2;
        if (n == 0)
        {
            startLabel.transform.position += new Vector3(10, 0, 0);
            quitLabel.transform.position += new Vector3(-10, 0, 0);
        }
        if(n == 1)
        {
            startLabel.transform.position += new Vector3(-10, 0, 0);
            quitLabel.transform.position += new Vector3(10, 0, 0);
        }
    
    }
}
