using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarModel : MonoBehaviour {
    [SerializeField]
    int m_currentMaterialID = 0;
    int currentMaterialID {
        get {
            return m_currentMaterialID;
        }
        set
        {
            m_currentMaterialID = value;
            Material[] matCache = rendererToChange.materials;
            matCache[materialIdToChange] = materialsToChange[m_currentMaterialID];
            rendererToChange.materials = matCache;

        }
    }
    [SerializeField] MeshRenderer rendererToChange;
    [SerializeField] int materialIdToChange;
    [SerializeField] Material[] materialsToChange;

    private void Start()
    {
        currentMaterialID = 0;
    }
    public void ChangeColor()
    {
        currentMaterialID = (currentMaterialID + 1) % materialsToChange.Length;
    }

}
