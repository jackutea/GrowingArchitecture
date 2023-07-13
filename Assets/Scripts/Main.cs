using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grow {

    public class Main : MonoBehaviour {

        Controller controller;

        void Start() {

            controller = new Controller();

            var ctx = new Context();
            controller.Inject(ctx);

            controller.GameEnter();

        }

        void Update() {

            if (controller != null) {
                controller.GameTick(Time.deltaTime);
            }

        }

    }
}
