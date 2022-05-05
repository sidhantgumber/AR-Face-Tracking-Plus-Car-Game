using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.ARFoundation;


public class FaceDetector : MonoBehaviour
{
    public TextMeshProUGUI welcomeText;
    public GameObject startGameScreen;
    ARFaceManager faceManager;
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
        faceManager.facesChanged += OnFaceChanged;
    }

   
    void Update()
    {
        
    }

    void OnFaceChanged(ARFacesChangedEventArgs args)
    {
        if(args.added.Count == 1)
        {
            OnFaceVisible();
        }
        if(args.removed.Count == 1)
        {
            OnFaceNotVisible();
        }
    }
    void OnFaceVisible()
    {
        welcomeText.text = "That face is not pretty";
        startGameScreen.SetActive(true);
    }

    void OnFaceNotVisible()
    {
        welcomeText.text = "Dil pe mat le shakal dikha";
        startGameScreen.SetActive(false);
    }
    
}
