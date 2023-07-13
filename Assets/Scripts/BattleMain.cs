using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grow {

    public class ClientMain : MonoBehaviour {

        BattleController battleController;
        TownController townController;

        void Awake() {

            // ==== Instantiate ====
            battleController = new BattleController();
            townController = new TownController();

            var ctx = new Context();

            // ==== Injection ====
            battleController.Inject(ctx);
            townController.Inject(ctx);

            // ==== Start ====
            battleController.GameEnter();

        }

        void Update() {

            if (battleController != null) {
                battleController.GameTick(Time.deltaTime);
            }

        }

    }
}
