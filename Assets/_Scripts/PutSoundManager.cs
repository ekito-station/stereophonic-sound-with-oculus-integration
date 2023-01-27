using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PutSoundManager : MonoBehaviour
{
    public Camera arCamera;
    public float front;
    public GameObject oculusSphere;
    public GameObject standardSphere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnOculusButtonClicked()
    {
        Transform camTrans = arCamera.transform;
        Vector3 spherePos = camTrans.position + front * camTrans.forward;
        Instantiate(oculusSphere, spherePos, Quaternion.identity);
    }

    public void OnStandardButtonClicked()
    {
        Transform camTrans = arCamera.transform;
        Vector3 spherePos = camTrans.position + front * camTrans.forward;
        Instantiate(standardSphere, spherePos, Quaternion.identity);
    }

    public void OnClearButtonClicked()
    {
        SceneManager.LoadScene("PutSound");
    }
}
