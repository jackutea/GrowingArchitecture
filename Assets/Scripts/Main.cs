using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Grow {

    public class Main : MonoBehaviour {

        BattleController battleController;
        TownController townController;

        void Start() {

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
