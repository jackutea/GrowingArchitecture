using Grow.BattleApplication;

namespace Grow.TownBusiness {

    public class TownController {

        TownContext ctx;

        public TownController() { 
            this.ctx = new TownContext();
        }

        public void Inject(BattleApp battleApp) {
            ctx.battleApp = battleApp;
        }

        public void GameEnter() {
            // battleApp.Spawn(); // 初期做法
            // battleApp.SetterAPI.Spawn // 晚期做法
        }

        public void GameTick(float dt) {

        }

    }

}