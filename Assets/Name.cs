using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Name : MonoBehaviour
{
    public TextMeshProUGUI nameUI;
    public string name1;
    // Start is called before the first frame update
    void Start()
    {
        name1 = PersistentData.Instance.GetName();
        GameObject.Find("Player").GetComponent<TextMeshProUGUI>().SetText(name1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
