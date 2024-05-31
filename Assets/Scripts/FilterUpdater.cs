using UnityEngine;

public class FilterUpdater : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (!GlassesChanger.CurrentTag.Equals(""))
        {
            GameObject.FindWithTag(GlassesChanger.CurrentTag).GetComponent<MeshRenderer>().enabled = true;
            GameObject.FindWithTag(GlassesChanger.CurrentTag).GetComponent<MeshRenderer>().material = ColorChanger.currentMaterial;
        }
    }
}
