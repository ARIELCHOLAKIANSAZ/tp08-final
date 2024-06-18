using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] obj;
    int pos = 0;
    // Update is called once per frame
    private void Start()
    {
        HideAll();
        ShowOne(pos);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangePos(-1);
            HideAll();
            ShowOne(pos);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangePos(1);
            HideAll();
            ShowOne(pos);
        }
    }

    void HideAll()
    {
        foreach(GameObject obje in obj)
        {
            obje.SetActive(false);
        }
    }
    void ShowOne(int obje)
    {
        obj[obje].SetActive(true);
    }
    void ChangePos(int val)
    {
        if (pos == -1)
            pos = 0;
        else if (pos == obj.Length)
            pos = obj.Length - 1;
        else
            pos += val;
    }
}
