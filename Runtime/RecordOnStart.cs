#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Recorder;
using UnityEngine;

namespace Meangpu.Recorder.Video
{
    public class CameraPC_Record : MonoBehaviour
    {
        RecorderWindow _recorderWindow;

        private RecorderWindow GetRecorderWindow() => (RecorderWindow)EditorWindow.GetWindow(typeof(RecorderWindow));

        private void Start()
        {
            _recorderWindow = GetRecorderWindow();
            StartRecord();
        }

        public void StartRecord()
        {
            if (!_recorderWindow.IsRecording()) _recorderWindow.StartRecording();
        }

        public void StopRecord()
        {
            if (_recorderWindow.IsRecording()) _recorderWindow.StopRecording();
        }
    }

}
#endif