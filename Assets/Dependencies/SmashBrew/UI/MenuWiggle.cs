﻿using UnityEngine;
using System.Collections;
using InControl;

namespace Hourai.SmashBrew.UI {

    public class MenuWiggle : MonoBehaviour {

        [SerializeField]
        private InputControlTarget _horizontalAxis = InputControlTarget.RightStickX;

        [SerializeField]
        private InputControlTarget _verticalAxis = InputControlTarget.RightStickY;

        [SerializeField]
        private Vector2 _scale = new Vector2(30, 30);

        /// <summary>
        /// Unity Callback. Called once every frame.
        /// </summary>
        void Update() {
            Debug.Log(_scale);
            Vector2 distortion = Vector2.zero;
            foreach (InputDevice device in InputManager.Devices) {
                if (device == null)
                    continue;
                float x = device.GetControl(_horizontalAxis);
                float y = device.GetControl(_verticalAxis);
                if (Mathf.Abs(distortion.x) < Mathf.Abs(x))
                    distortion.x = x;
                if (Mathf.Abs(distortion.y) < Mathf.Abs(y))
                    distortion.y = y;
            }
            distortion = Vector2.ClampMagnitude(distortion, 1f);
            distortion.x *= _scale.x;
            distortion.y *= _scale.y;
            transform.rotation = Quaternion.Euler(distortion);
        }

    }

}