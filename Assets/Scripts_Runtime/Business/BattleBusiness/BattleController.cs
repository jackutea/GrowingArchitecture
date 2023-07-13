using Grow.BattleApplication;

namespace Grow.BattleBusiness {

    public class BattleController {

        BattleContext context;

        public BattleController() { 
            this.context= new BattleContext();
        }

        public void Inject(BattleApp battleApp) {
            this.context.battleApp = battleApp;
        }

        public void GameEnter() {
            // battleApp.Spawn(); // 初期做法
            // battleApp.SetterAPI.Spawn // 晚期做法
        }

        public void GameTick(float dt) {

        }

    }

}