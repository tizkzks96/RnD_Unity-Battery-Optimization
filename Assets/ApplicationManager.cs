using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour
{
    private int lastRequestedFrame = 0;
    public TMP_Text frameRateText;

    private void Awake()
    {
        Application.targetFrameRate = 60;

        RequestFullFrameRate(); //Force the instance to be created
    }

    public void RequestFullFrameRate()
    {
        lastRequestedFrame = Time.frameCount;
    }
    private const int BUFFER_FRAMES = 3;
    private const int LOW_POWER_FRAME_INTERVAL = 60;
    private void Update()
    {
        RequestFullFrameRate();

        //OnDemandRendering.renderFrameInterval = (Time.frameCount - lastRequestedFrame) < BUFFER_FRAMES ? 1 : LOW_POWER_FRAME_INTERVAL;

        float frameRate = Mathf.Round((1f / Time.deltaTime) / OnDemandRendering.renderFrameInterval);
        frameRateText.text = $"Frame Rate: {frameRate} FPS";
    }

    public void ApplyFrame(int targetFrame)
    {
        OnDemandRendering.renderFrameInterval = targetFrame;
        //Application.targetFrameRate = targetFrame;
    }
}
