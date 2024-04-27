using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public TMP_Dropdown dropdown;
    // Start is called before the first frame update
    void Start()
    {
        textMesh.text = "<color=blue>update</color>";
        dropdown.onValueChanged.AddListener((t)=>{
            Debug.Log(dropdown.options[t].text);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
