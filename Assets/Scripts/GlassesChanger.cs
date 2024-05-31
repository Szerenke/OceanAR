using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlassesChanger : MonoBehaviour
{
    public List<Button> glassesButtons;
    public static string CurrentTag { get; private set; } = "";
    private List<string> tags = new List<string>(){ "cat", "mask" , "stars" };

    // Start is called before the first frame update
    void Start()
    {
        foreach (var button in glassesButtons)
        {
            button.onClick.AddListener(() => SetGlasses(button.name));
        }
    }

    void SetGlasses(string currentTag)
    {       
        foreach (string glassesTag in tags)
        {
            GameObject glasses = GameObject.FindWithTag(glassesTag);

            if (glasses != null)
            {
                SetMeshRenderer(glasses, currentTag, glassesTag);
            }            
        }
    }

    void SetMeshRenderer(GameObject glasses, string currentTag, string glassesTag)
    {
        if (glassesTag.Equals(currentTag))
        {
            CurrentTag = glassesTag;
            glasses.GetComponent<MeshRenderer>().enabled = true;                   
        } else
        {
            glasses.GetComponent<MeshRenderer>().enabled = false;
        }
    }

}
