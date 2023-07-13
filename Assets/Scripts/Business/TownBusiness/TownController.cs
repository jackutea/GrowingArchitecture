namespace Grow {

    public class TownController {

        TownContext ctx;
        RoleDomain roleDomain;

        public TownController() { 
            this.ctx = new TownContext();
            this.roleDomain = new RoleDomain();
        }

        public void Inject(BattleApp battleApp) {
            ctx.battleApp = battleApp;
        }

        public void GameEnter() {
            roleDomain.SpawnRole();
        }

        public void GameTick(float dt) {

        }

    }

}